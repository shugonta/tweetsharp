using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using Hammock;
#if SILVERLIGHT
using Hammock.Silverlight.Compat;
#else
using System.Collections.Specialized;
#endif

namespace TweetSharp
{
#if !SILVERLIGHT
    [Serializable]
#endif
    public class TwitterResponse
    {
        private readonly RestResponseBase _response;
        private readonly Exception _exception;

        internal TwitterResponse(RestResponseBase response, Exception exception = null)
        {
            _exception = exception;
            _response = response;
        }

        public virtual TwitterRateLimitStatus RateLimitStatus
        {
            get
            {
                var limit = Headers["X-RateLimit-Limit"];
                var remaining = Headers["X-RateLimit-Remaining"];
                var reset = Headers["X-RateLimit-Reset"];

                limit = IsStringANumber(!string.IsNullOrEmpty(limit) ? limit.Trim() : "-1") ? limit : "-1";
                remaining = IsStringANumber(!string.IsNullOrEmpty(remaining) ? remaining.Trim() : "-1") ? remaining : "-1";
                reset = IsStringANumber(!string.IsNullOrEmpty(reset) ? reset.Trim() : "-1") ? reset : "0";
                
                return !(new[] { limit, remaining, reset }).AreNullOrBlank()
                           ? new TwitterRateLimitStatus
                           {
                               HourlyLimit = Convert.ToInt32(limit, CultureInfo.InvariantCulture),
                               RemainingHits = Convert.ToInt32(remaining, CultureInfo.InvariantCulture),
                               ResetTimeInSeconds = Convert.ToInt64(reset, CultureInfo.InvariantCulture),
                               ResetTime = Convert.ToInt64(reset, CultureInfo.InvariantCulture).FromUnixTime()
                           }
                           : null;
            }
        }

        private static bool IsStringANumber(IEnumerable<char> limit)
        {
            return limit.All(c => char.IsNumber(c));
        }

        public virtual NameValueCollection Headers
        {
            get { return _response.Headers; }
        }

        public virtual HttpStatusCode StatusCode
        {
            get { return _response.StatusCode; }
            set { _response.StatusCode = value; }
        }

        public virtual bool SkippedDueToRateLimitingRule
        {
            get { return _response.SkippedDueToRateLimitingRule; }
            set { _response.SkippedDueToRateLimitingRule = value; }
        }

        public virtual string StatusDescription
        {
            get { return _response.StatusDescription; }
            set { _response.StatusDescription = value; }
        }

        public virtual string Response
        {
            get { return _response.Content; }
        }

        public virtual string RequestMethod
        {
            get { return _response.RequestMethod; }
            set { _response.RequestMethod = value; }
        }

        public virtual Uri RequestUri
        {
            get { return _response.RequestUri; }
            set { _response.RequestUri = value; }
        }

        public virtual DateTime? ResponseDate
        {
            get { return _response.ResponseDate; }
            set { _response.ResponseDate = value; }
        }

        public virtual DateTime? RequestDate
        {
            get { return _response.RequestDate; }
            set { _response.RequestDate = value; }
        }

        public virtual Exception InnerException
        {
            get { return _exception ?? _response.InnerException; }
        }
    }
}