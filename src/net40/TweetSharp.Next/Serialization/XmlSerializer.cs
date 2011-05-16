using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Hammock;

#if !NET20
using System.Xml.Linq;
#else
using System.Xml;
using System.IO;
#endif

namespace TweetSharp.Serialization
{
    internal class XmlSerializer : SerializerBase
    {
        public override T Deserialize<T>(RestResponse<T> response)
        {
            if (response == null)
            {
                return default(T);
            }
            if ((int)response.StatusCode >= 500)
            {
                return default(T);
            }

            var content = response.Content;

            return DeserializeContent<T>(content);
        }

#if NET40
        public override dynamic DeserializeDynamic<T>(RestResponse<T> response)
        {
            throw new NotSupportedException();
        }
#endif

        internal T DeserializeContent<T>(string content)
        {
            var wantsCollection = typeof (IEnumerable).IsAssignableFrom(typeof (T));

            var deserialized = wantsCollection
                                   ? DeserializeCollection<T>(content)
                                   : DeserializeSingle<T>(content);

            return deserialized;
        }

        private T DeserializeSingle<T>(string content)
        {
            var deserialized = (T)Deserialize(content, typeof(T));
                
            if (typeof(ITwitterModel).IsAssignableFrom(typeof(T)))
            {
                ((ITwitterModel)deserialized).RawSource = content;
            }

            return deserialized;
        }

        private T DeserializeCollection<T>(string content)
        {
            IList collection;
            var type = ConstructCollection<T>(out collection);
            
#if !NET20
            var root = XDocument.Parse(content).Elements().First();
            if(root.Name.LocalName.Equals("hash"))
            {
                return FailDeserialization<T>(content, type, collection);
            }
            var array = root.Elements();
#else
            var array = new List<string>(0);
            using(var sr = new StringReader(content))
            {
                using (var xr = new XmlTextReader(sr))
                {
                    var root = new XmlDocument();
                    root.Load(xr);
                    
                    if(root.FirstChild.LocalName.Equals("hash"))
                    {
                        return FailDeserialization<T>(content, type, collection);
                    }
                    var children = root.FirstChild.ChildNodes;
                    array.AddRange(from XmlNode child in children select child.InnerXml);
                }
            }
#endif
            try
            {
                foreach (var item in array)
                {
                    var c = item.ToString();
                    AddDeserializedItem(c, type, collection);
                }

                var deserialized = (T)collection;
                return deserialized;
            }
            catch (Exception)
            {
                return FailDeserialization<T>(content, type, collection);
            }
        }

        private static T FailDeserialization<T>(string content, Type type, IList collection)
        {
            Trace.TraceError(string.Concat("TweetSharp: Could not parse content into 'IEnumerable<", type.Name, ">' : '", content));

            AddEmptyItem(content, type, collection);

            var deserialized = (T)collection;
            return deserialized;
        }

        private void AddDeserializedItem(string c, Type type, IList collection)
        {
            var d = Deserialize(c, type);
            ((ITwitterModel)d).RawSource = c;
            collection.Add(d);
        }

        private static void AddEmptyItem(string c, Type type, IList collection)
        {
            var d = Activator.CreateInstance(type);
            ((ITwitterModel)d).RawSource = c;
            collection.Add(d);
        }

        private static Type ConstructCollection<T>(out IList collection)
        {
            var type = typeof(T).GetGenericArguments()[0];
            var collectionType = typeof(List<>).MakeGenericType(type);
            collection = (IList)Activator.CreateInstance(collectionType);
            return type;
        }

        public override object Deserialize(RestResponse response, Type type)
        {
            return Deserialize(response.Content, type);
        }

        public object Deserialize(string content, Type type)
        {
            var root = ResolveRootName(type);
            return DeserializeXmlWithRoot(content, type, root);
        }

        private static string ResolveRootName(Type type)
        {
            var root = type.Name.ToLowerInvariant();
            return root
                .Replace("twittererror", "hash")
                .Replace("twittersearchresult", "results")
                .Replace("twitter", "");
        }

        public override string Serialize(object instance, Type type)
        {
            var root = type.Name.ToLowerInvariant();

            return SerializeXmlWithRoot(instance, type, root);
        }

        public override string ContentType
        {
            get { return "text/xml"; }
        }
    }
}