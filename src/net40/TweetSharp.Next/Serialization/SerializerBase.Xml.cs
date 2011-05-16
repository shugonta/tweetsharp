using System;
using System.Collections.Generic;
#if NET40
using System.Dynamic;
#endif
using System.IO;
using System.Linq;
using System.Xml;
using Hammock;
using Hammock.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TweetSharp.Serialization
{
    internal partial class SerializerBase
    {
        public virtual T DeserializeXml<T>(string content)
        {
            return (T)DeserializeXml(content, typeof(T));
        }

        public virtual object DeserializeXml(string content, Type type)
        {
            var element = LoadXmlElement(content);

            return DeserializeXmlImpl(element, type);
        }

        private object DeserializeXmlImpl(XmlNode node, Type type)
        {
            var json = JsonConvert.SerializeXmlNode(node);
            var instance = DeserializeJson(json, type);
            return instance;
        }

        private static XmlElement LoadXmlElement(string content)
        {
            var document = new XmlDocument();
            document.Load(new StringReader(content));
            return document.DocumentElement;
        }

        public virtual object DeserializeXmlWithRoot(string content, Type type, string root)
        {
            var source = LoadXmlElement(content);
            var json = JsonConvert.SerializeXmlNode(source);
            var relevant = JObject.Parse(json)[root];

            if(relevant == null)
            {
                return DeserializeJson(json, type);
            }

            var replacer = DeserializeEntities(relevant);
            if(replacer != null)
            {
                relevant["entities"].Replace(replacer);
            }

            var instance = DeserializeJson(relevant.ToString(), type);

            return instance;
        }

        private static JToken DeserializeEntities(JToken relevant)
        {
            var results = new TwitterEntities();

            var entities = relevant["entities"];
            if (entities != null)
            {
                var mentions = entities["user_mentions"];
                if (mentions != null)
                {
                    DeserializeMentions(results, mentions);
                }

                var urls = entities["urls"];
                if(urls != null)
                {
                    DeserializeUrls(results, urls);
                }

                var hashtags = entities["hashtags"];
                if (hashtags != null)
                {
                    DeserializeHashtags(results, hashtags);
                }
            }

            if(results.Count() > 0)
            {
                var replacer = JsonConvert.SerializeObject(results);
                return JObject.Parse(replacer);
            }

            return null;
        }

        private static void DeserializeHashtags(TwitterEntities results, JToken hashtags)
        {
            var value = hashtags.ToString();
            if (value.Equals("Null", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }
            var inner = hashtags["hashtag"];
            if (inner.Type == JTokenType.Array)
            {
                var array = JArray.Parse(inner.ToString());

                foreach (var hashtag in from item in array
                                        let indices = ParseEntityIndices(item)
                                        select ParseHashTag(indices, item))
                {
                    results.HashTags.Add(hashtag);
                }
            }
            switch (inner.Type)
            {
                case JTokenType.Object:
                    {
                        var item = JObject.Parse(inner.ToString());
                        var indices = ParseEntityIndices(item);

                        results.HashTags.Add(ParseHashTag(indices, item));
                    }
                    break;
            }
        }

        private static TwitterHashTag ParseHashTag(IEnumerable<int> indices, JToken item)
        {
            return new TwitterHashTag
                       {
                           Indices = new List<int>(indices),
                           Text = item["text"] != null ? item["text"].ToString().Replace("\"", "") : null
                       };
        }

        private static void DeserializeUrls(TwitterEntities results, JToken urls)
        {
            var value = urls.ToString();
            if (value.Equals("Null", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }
            var inner = urls["url"];
            if (inner.Type == JTokenType.Array)
            {
                var array = JArray.Parse(inner.ToString());

                foreach (var url in from item in array
                                    let indices = ParseEntityIndices(item)
                                    select ParseUrl(indices, item))
                {
                    results.Urls.Add(url);
                }
            }
            switch (inner.Type)
            {
                case JTokenType.Object:
                    {
                        var item = JObject.Parse(inner.ToString());
                        var indices = ParseEntityIndices(item);
                        results.Urls.Add(ParseUrl(indices, item));
                    }
                    break;
            }
        }

        private static TwitterUrl ParseUrl(IEnumerable<int> indices, JToken item)
        {
            return new TwitterUrl
                       {
                           Indices = new List<int>(indices), 
                           Value = item["url"] != null ? item["url"].ToString().Replace("\"", "") : null,
                           ExpandedValue = item["expanded_url"] != null ? item["expanded_url"].ToString().Replace("\"", "") : null,
                       };
        }

        private static void DeserializeMentions(TwitterEntities results, JToken mentions)
        {
            var value = mentions.ToString();

            if (value.Equals("Null", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }
            var inner = mentions["user_mention"];
            if(inner.Type == JTokenType.Array)
            {
                var array = JArray.Parse(inner.ToString());

                foreach (var mention in from item in array
                                        let indices = ParseEntityIndices(item)
                                        select ParseMention(indices, item))
                {
                    results.Mentions.Add(mention);
                }
            }
            switch (inner.Type)
            {
                case JTokenType.Object:
                    {
                        var item = JObject.Parse(inner.ToString());
                        var indices = ParseEntityIndices(item);

                        results.Mentions.Add(ParseMention(indices, item));
                    }
                    break;
            }
        }

        private static TwitterMention ParseMention(IEnumerable<int> indices, JToken item)
        {
            return new TwitterMention
                       {
                           Indices = new List<int>(indices), 
                           Id = Convert.ToInt64(item["id"] != null ? item["id"].ToString().Replace("\"", "") : "0"),
                           Name = item["name"] != null ? item["name"].ToString().Replace("\"", "") : null,
                           ScreenName = item["screen_name"] != null ? item["screen_name"].ToString().Replace("\"", "") : null,
                       };
        }

        private static IEnumerable<int> ParseEntityIndices(JToken item)
        {
            var startToken = item["@start"] != null ? item["@start"].ToString().Replace("\"", "") : "0";
            var endToken = item["@end"] != null ? item["@end"].ToString().Replace("\"", "") : "0";

            var start = Convert.ToInt32(startToken);
            var end = Convert.ToInt32(endToken);

            return new[] { start, end };
        }

        public virtual string SerializeXml(object instance, Type type)
        {
            var json = SerializeJson(instance, type);

            var root = type.Name.ToLowerInvariant();

            return SerializeXmlImpl(instance, type, json, root);
        }

        public virtual string SerializeXmlWithRoot(object instance, Type type, string root)
        {
            var json = SerializeJson(instance, type);

            return SerializeXmlImpl(instance, type, json, root);
        }

        public virtual string SerializeXmlImpl(object instance, Type type, string json, string root)
        {
            json = string.Format("{{\"{0}\":{1} }}", root, json); // <-- {"root":json }

            var document = JsonConvert.DeserializeXmlNode(json);

            using (var stringWriter = new StringWriter())
            {
                using (var xmlTextWriter = new XmlTextWriter(stringWriter))
                {
                    document.WriteTo(xmlTextWriter);

                    return stringWriter.ToString();
                }
            }
        }
    }
}
