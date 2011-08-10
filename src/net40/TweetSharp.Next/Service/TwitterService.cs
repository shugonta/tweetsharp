using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using Hammock;
using Hammock.Serialization;
using Hammock.Web;
using TweetSharp.Serialization;

#if SILVERLIGHT
using Hammock.Silverlight.Compat;
#endif

namespace TweetSharp
{
    /// <summary>
    /// Defines a contract for a <see cref="TwitterService" /> implementation.
    /// </summary>
    /// <seealso href="http://dev.twitter.com/doc" />
    public partial class TwitterService
    {
        public bool TraceEnabled { get; set; }

        public string Proxy { get; set; }

        public bool IncludeEntities { get; set; }
        
        private TwitterServiceFormat _format;
        
        private readonly RestClient _client;

        private readonly JsonSerializer _json;
#if !SILVERLIGHT
        private readonly XmlSerializer _xml;
#endif

        public string UserAgent
        {
            get { return _client.UserAgent; }
            set
            {
                _client.UserAgent = value;
                _oauth.UserAgent = value;
            }
        }

        private IDeserializer _customDeserializer;
        private ISerializer _customSerializer;
        public IDeserializer Deserializer
        {
            get
            {
                if(_customDeserializer != null)
                {
                    return _customDeserializer;
                }
                switch(Format)
                {
                    case TwitterServiceFormat.Json:
                        return _json;
#if !SILVERLIGHT
                    case TwitterServiceFormat.Xml:
                        return _xml;
#endif
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            set { _customDeserializer = value; }
        }

        public ISerializer Serializer
        {
            get
            {
                if (_customSerializer != null)
                {
                    return _customSerializer;
                }
                switch (Format)
                {
                    case TwitterServiceFormat.Json:
                        return _json;
#if !SILVERLIGHT
                    case TwitterServiceFormat.Xml:
                        return _xml;
#endif
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            set { _customSerializer = value; }
        }
        
        private string _consumerKey;
        private string _consumerSecret;
        private string _token;
        private string _tokenSecret;

#if !WINDOWS_PHONE
        private void SetResponse(RestResponseBase response)
        {
            Response = new TwitterResponse(response);
        }
#endif

 #if !SILVERLIGHT
        static TwitterService()
        {
            ServicePointManager.Expect100Continue = false;
        }
#endif

#if !WINDOWS_PHONE
        public virtual TwitterResponse Response { get; private set; }
#endif

        public TwitterService(TwitterClientInfo info) : this()
        {
            _consumerKey = info.ConsumerKey;
            _consumerSecret = info.ConsumerSecret;
            IncludeEntities = info.IncludeEntities;

            _info = info;
        }

        public TwitterService(string consumerKey, string consumerSecret) : this()
        {
            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
        }

        public TwitterService(string consumerKey, string consumerSecret, string token, string tokenSecret) : this()
        {
            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
            _token = token;
            _tokenSecret = tokenSecret;
        }

        public TwitterService()
        {
            _json = new JsonSerializer();
#if !SILVERLIGHT
            _xml = new XmlSerializer();
#endif

            FormatAsString = ".json";

            _client = new RestClient
                          {
                              Authority = Globals.RestAPIAuthority,
                              QueryHandling = QueryHandling.AppendToParameters,
                              VersionPath = "1",
                              Serializer = _json,
                              Deserializer = _json,
                              DecompressionMethods = DecompressionMethods.GZip,
                              UserAgent = "TweetSharp",
                              Proxy = Proxy,
#if !SILVERLIGHT
                              FollowRedirects = true,
#endif
#if SILVERLIGHT
                              HasElevatedPermissions = true
#endif
                          };

            _oauth = new RestClient
                         {
                             Authority = Globals.RestAPIAuthority,
                             Proxy = Proxy,
                             UserAgent = "TweetSharp",
#if SILVERLIGHT
                             HasElevatedPermissions = true
#endif
                         };

            _userStreamingClient = new RestClient
            {
                Authority = Globals.UserStreamingAPIAuthority,
                Proxy = Proxy,
                VersionPath = "2",
                Serializer = _json,
                Deserializer = _json,
                DecompressionMethods = DecompressionMethods.GZip,
                UserAgent = "TweetSharp",
#if !SILVERLIGHT
                FollowRedirects = true,
#endif
#if SILVERLIGHT
                HasElevatedPermissions = true
#endif
            };

            _searchStreamingClient = new RestClient
            {
                Authority = Globals.SearchStreamingAPIAuthority,
                Proxy = Proxy,
                VersionPath = "1",
                Serializer = _json,
                Deserializer = _json,
                DecompressionMethods = DecompressionMethods.GZip,
                UserAgent = "TweetSharp",
#if !SILVERLIGHT
                FollowRedirects = true,
#endif
#if SILVERLIGHT
                HasElevatedPermissions = true
#endif
            };

            InitializeService();
        }

        private void InitializeService()
        {
            IncludeEntities = true;
        }

        private readonly Func<RestRequest> _noAuthQuery
            = () =>
                  {
                      var request = new RestRequest();
                      return request;
                  };

        private readonly TwitterClientInfo _info;

        private RestRequest PrepareHammockQuery(string path)
        {
            RestRequest request;
            if (string.IsNullOrEmpty(_token) || string.IsNullOrEmpty(_tokenSecret))
            {
                request = _noAuthQuery.Invoke();
            }
            else
            {
                var args = new FunctionArguments
                {
                    ConsumerKey = _consumerKey,
                    ConsumerSecret = _consumerSecret,
                    Token = _token,
                    TokenSecret = _tokenSecret
                };
                request = _protectedResourceQuery.Invoke(args);
            }
            request.Path = path;

            SetTwitterClientInfo(request);
            
            return request;
        }

        private void SetTwitterClientInfo(RestBase request)
        {
            if (_info == null) return;
            if(!_info.ClientName.IsNullOrBlank())
            {
                request.AddHeader("X-Twitter-Name", _info.ClientName);
                request.UserAgent = _info.ClientName;
            }
            if (!_info.ClientVersion.IsNullOrBlank())
            {
                request.AddHeader("X-Twitter-Version", _info.ClientVersion);
            }
            if (!_info.ClientUrl.IsNullOrBlank())
            {
                request.AddHeader("X-Twitter-URL", _info.ClientUrl);
            }
        }

        public T Deserialize<T>(ITwitterModel model) where T : ITwitterModel
        {
            return Deserialize<T>(model.RawSource);
        }

        public T Deserialize<T>(string content)
        {
            var response = new RestResponse<T> { StatusCode = HttpStatusCode.OK };
            response.SetContent(content);

            if(_customDeserializer != null)
            {
                return _customDeserializer.Deserialize(response);
            }

            switch(Format)
            {
                case TwitterServiceFormat.Json:
                    return _json.DeserializeContent<T>(content);
#if !SILVERLIGHT
                case TwitterServiceFormat.Xml:
                    return _xml.DeserializeContent<T>(content);
#endif
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public TwitterServiceFormat Format
        {
            get { return _format; }
            set
            {
                if (_format == value)
                {
                    return;
                }
                _format = value;
                FormatAsString = string.Concat(".", Format.ToString().ToLowerInvariant());
                switch(Format)
                {
                    case TwitterServiceFormat.Json:
                        if(_customSerializer == null)
                        {
                            _client.Serializer = _json;
                        }
                        if(_customDeserializer == null)
                        {
                            _client.Deserializer = _json;
                        }
                        break;
#if !SILVERLIGHT
                    case TwitterServiceFormat.Xml:

                        if(_customSerializer == null)
                        {
                            _client.Serializer = _xml;
                        }
                        if(_customDeserializer == null)
                        {
                            _client.Deserializer = _xml;
                        }
                        break;
#endif
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        internal string FormatAsString { get; private set; }

        private string ResolveUrlSegments(string path, List<object> segments)
        {
            if (segments == null) throw new ArgumentNullException("segments");

            // Support alternate client authorities here

            if (path.Equals("search"))
            {
                _client.Authority = Globals.SearchAPIAuthority;
                _client.VersionPath = null;
            }
            else
            {
                _client.Authority = Globals.RestAPIAuthority;
                _client.VersionPath = "1";
            }

            for (var i = 0; i < segments.Count; i++)
            {
                // Currently only trends takes DateTimes
                if (segments[i] is DateTime)
                {
                    segments[i] = ((DateTime) segments[i]).ToString("yyyy-MM-dd");
                }

                if (typeof (IEnumerable).IsAssignableFrom(segments[i].GetType()) && !(segments[i].GetType() == typeof (string)))
                {
                    ResolveEnumerableUrlSegments(segments, i);
                }
            }

            path = PathHelpers.ReplaceUriTemplateTokens(segments, path);

            PathHelpers.EscapeDataContainingUrlSegments(segments);

            if(IncludeEntities)// && !path.Contains("/lists"))
            {
                segments.Add(segments.Count() > 1 ? "&include_entities=" : "?include_entities=");
                segments.Add("1");
            }

            segments.Insert(0, path);

            return string.Concat(segments.ToArray()).ToString(CultureInfo.InvariantCulture);
        }

        private static void ResolveEnumerableUrlSegments(IList<object> segments, int i)
        {
            var collection = (IEnumerable<object>) segments[i];
            var total = collection.Count();
            var sb = new StringBuilder();
            var count = 0;
            foreach (var item in collection)
            {
                sb.Append(item.ToString());
                if (count < total - 1)
                {
                    sb.Append(",");
                }
                count++;
            }
            segments[i] = sb.ToString();
        }

#if !WINDOWS_PHONE
        private IAsyncResult WithHammock<T>(Action<T, TwitterResponse> action, string path) where T : class
        {
            var request = PrepareHammockQuery(path);

            return WithHammockImpl(request, action);
        }

        private IAsyncResult WithHammock<T>(Action<T, TwitterResponse> action, string path, params object[] segments) where T : class
        {
            return WithHammock(action, ResolveUrlSegments(path, segments.ToList()));
        }

        private IAsyncResult WithHammock<T>(WebMethod method, Action<T, TwitterResponse> action, string path) where T : class
        {
            var request = PrepareHammockQuery(path);
            request.Method = method;

            return WithHammockImpl(request, action);
        }

        private IAsyncResult WithHammock<T>(WebMethod method, Action<T, TwitterResponse> action, string path, params object[] segments) where T : class
        {
            return WithHammock(method, action, ResolveUrlSegments(path, segments.ToList()));
        }

        private IAsyncResult WithHammockImpl<T>(RestRequest request, Action<T, TwitterResponse> action) where T : class
        {
            return _client.BeginRequest(
                request, new RestCallback<T>((req, response, state) =>
                {
                    if (response == null)
                    {
                        return;
                    }
                    SetResponse(response);
                    var entity = response.ContentEntity;
                    action.Invoke(entity, new TwitterResponse(response));
                }));
        }
        
        private IAsyncResult BeginWithHammock<T>(WebMethod method, string path, params object[] segments)
        {
            path = ResolveUrlSegments(path, segments.ToList());
            var request = PrepareHammockQuery(path);
            request.Method = method;
            var result = _client.BeginRequest<T>(request);
            return result;
        }

        private T EndWithHammock<T>(IAsyncResult result)
        {
            var response = _client.EndRequest<T>(result);
            SetResponse(response);
            return response.ContentEntity;
        }

        private T EndWithHammock<T>(IAsyncResult result, TimeSpan timeout)
        {
            var response = _client.EndRequest<T>(result, timeout);
            return response.ContentEntity;
        }
#endif

#if !SILVERLIGHT
        private T WithHammock<T>(string path)
        {
            var request = PrepareHammockQuery(path);

            return WithHammockImpl<T>(request);
        }

        private T WithHammock<T>(string path, params object[] segments)
        {
            return WithHammock<T>(ResolveUrlSegments(path, segments.ToList()));
        }
        
        private T WithHammock<T>(WebMethod method, string path)
        {
            var request = PrepareHammockQuery(path);
            request.Method = method;

            return WithHammockImpl<T>(request);
        }

        private T WithHammock<T>(WebMethod method, string path, params object[] segments)
        {
            return WithHammock<T>(method, ResolveUrlSegments(path, segments.ToList()));
        }

        private T WithHammockImpl<T>(RestRequest request)
        {
            var response = _client.Request<T>(request);
            
            SetResponse(response);

            var entity = response.ContentEntity;
            return entity;
        }
#endif

#if WINDOWS_PHONE
        private void WithHammock<T>(Action<T, TwitterResponse> action, string path) where T : class
        {
            var request = PrepareHammockQuery(path);
            
            WithHammockImpl(request, action);
        }
        
        private void WithHammock<T>(Action<T, TwitterResponse> action, string path, params object[] segments) where T : class
        {
            WithHammock(action, ResolveUrlSegments(path, segments.ToList()));
        }

        private void WithHammock<T>(WebMethod method, Action<T, TwitterResponse> action, string path) where T : class
        {
            var request = PrepareHammockQuery(path);
            request.Method = method;

            WithHammockImpl(request, action);
        }

        private void WithHammock<T>(WebMethod method, Action<T, TwitterResponse> action, string path, params object[] segments) where T : class
        {
            WithHammock(method, action, ResolveUrlSegments(path, segments.ToList()));
        }

        private void WithHammockImpl<T>(RestRequest request, Action<T, TwitterResponse> action) where T : class
        {
            _client.BeginRequest(
                request, new RestCallback<T>((req, response, state) =>
                {
                    if (response == null)
                    {
                        return;
                    }
                    var entity = response.ContentEntity;
                    action.Invoke(entity, new TwitterResponse(response));
                }));
        }      
#endif

        private static T TryAsyncResponse<T>(Func<T> action, out Exception exception)
        {
            exception = null;
            var entity = default(T);
            try
            {
                entity = action();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            return entity;
        }
    }
}
