using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Hammock;
using Hammock.Serialization;

namespace TweetSharp.Serialization
{
    internal class JsonSerializer : SerializerBase
    {
#if NET40
        private static readonly DefaultJsonSerializer _dynamicDeserializer;

        static JsonSerializer()
        {
            _dynamicDeserializer = new DefaultJsonSerializer();
        }
#endif

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

            if (content.Equals("END STREAMING"))
            {
                return (T)(ITwitterModel)new TwitterUserStreamEnd();
            }

            return DeserializeContent<T>(content);
        }

        internal T DeserializeContent<T>(string content)
        {
            if(typeof(T) == typeof(TwitterTrends))
            {
                return DeserializeTrends<T>(content);
            }

            if(typeof(T) == typeof(TwitterLocalTrends))
            {
                var instance = JArray.Parse(content);
                var inner = instance.First.ToString();
                return DeserializeSingle<T>(inner);
            }

            if (typeof(T) == typeof(TwitterStreamArtifact))
            {
                content = content.Trim('\n');
                if (content.StartsWith("{\"friends\":["))
                {
                    var friends = (JArray) JObject.Parse(content)["friends"];
                    if (friends != null)
                    {
                        var result = new TwitterUserStreamFriends {RawSource = content};
                        var ids = friends.Select(token => token.Value<long>()).ToList();
                        result.Ids = ids;
                        return (T) (ITwitterModel) result;
                    }
                }
                    // {"delete":{"status":{"user_id_str":"14363427","id_str":"45331017418014721","id":45331017418014721,"user_id":14363427}}}
                else if (content.StartsWith("{\"delete\":{\"status\":"))
                {
                    var deleted = JObject.Parse(content)["delete"]["status"];
                    if (deleted != null)
                    {
                        var result = new TwitterUserStreamDeleteStatus
                                         {
                                             RawSource = content,
                                             StatusId = deleted["id"].Value<long>(),
                                             UserId = deleted["user_id"].Value<int>()
                                         };
                        return (T) (ITwitterModel) result;
                    }
                }
                else if (content.StartsWith("{\"delete\":{\"direct_message\":"))
                {
                    var deleted = JObject.Parse(content)["delete"]["direct_message"];
                    if (deleted != null)
                    {
                        var result = new TwitterUserStreamDeleteDirectMessage
                        {
                            RawSource = content,
                            DirectMessageId = deleted["id"].Value<long>(),
                            UserId = deleted["user_id"].Value<int>()
                        };
                        return (T)(ITwitterModel)result;
                    }
                }
                else
                {
                    var artifact = JObject.Parse(content);
                    if (artifact["target_object"] != null)
                    {
                        return DeserializeUserStreamEvent<T>(content);
                    }

                    if (artifact["user"] != null)
                    {
                        var tweet = DeserializeSingle<TwitterStatus>(content);
                        var @event = new TwitterUserStreamStatus { Status = tweet, RawSource = content };
                        return (T)(ITwitterModel)@event;
                    }

                    if(artifact["direct_message"] != null)
                    {
                        var json = artifact["direct_message"].ToString();
                        var dm = DeserializeSingle<TwitterDirectMessage>(json);
                        var @event = new TwitterUserStreamDirectMessage { DirectMessage = dm, RawSource = json };
                        return (T)(ITwitterModel)@event;
                    }

                    var unknown = new TwitterStreamArtifact();
                    unknown.RawSource = content;
                    return (T)(ITwitterModel)unknown;
                }
            }

            if (typeof(T) == typeof(IEnumerable<ITwitterModel>))
            {
                return DeserializeTrends<T>(content);
            }

            var wantsCollection = typeof(IEnumerable).IsAssignableFrom(typeof(T));
            
            var deserialized = wantsCollection
                                   ? DeserializeCollection<T>(content)
                                   : DeserializeSingle<T>(content);
           
            return deserialized;
        }

        private T DeserializeUserStreamEvent<T>(string content)
        {
            var @event = DeserializeSingle<TwitterUserStreamEventBase>(content);

            var target = JObject.Parse(content);
            
            var result = new TwitterUserStreamEvent(@event);

            var targetObject = target["target_object"];

            var json = targetObject.ToString();

            if(targetObject["recipient_screen_name"] != null)
            {
                result.TargetObject = DeserializeSingle<TwitterDirectMessage>(json);
            }
            else if(targetObject["slug"] != null)
            {
                result.TargetObject = DeserializeSingle<TwitterList>(json);
            }
            else
            {
                result.TargetObject = DeserializeSingle<TwitterStatus>(json);
            }

            return (T)(ITwitterModel)result;
        }

        private T DeserializeTrends<T>(string content)
        {
            var instance = JObject.Parse(content);
            var inner = instance["trends"];
            if(inner != null)
            {
                var result = new TwitterTrends { RawSource = content };

                var asOf = instance["as_of"] != null ? instance["as_of"].ToString() : "0";
                result.AsOf = Convert.ToInt64(asOf).FromUnixTime();

                var dateBuckets = inner.Children();
                    
                foreach(var dateBucket in dateBuckets.OfType<JProperty>())
                {
                    var date = dateBucket.Name;
                    var value = dateBucket.Value.ToString();
                        
                    var trends = DeserializeCollection<IEnumerable<TwitterTrend>>(value);
                    foreach(var trend in trends)
                    {
                        trend.TrendingAsOf = Convert.ToDateTime(date);    
                    }
                        
                    result.Trends.AddRange(trends);
                }

                return (T)(IEnumerable)result;
            }

            return DeserializeSingle<T>(content);
        }

        private T DeserializeSingle<T>(string content)
        {
            var deserialized = DeserializeJson<T>(content);
                
            if (typeof(ITwitterModel).IsAssignableFrom(typeof(T)))
            {
                ((ITwitterModel)deserialized).RawSource = content;
            }

            // Provide a RawSource for embedded tweets
            if (typeof (T) == typeof (TwitterSearchResult) && content.StartsWith("{\"results\":[{"))
            {
                var array = (JArray) JObject.Parse(content)["results"];
                var result = (TwitterSearchResult)(ITwitterModel)deserialized;
                var collection = result.Statuses;
                for (var i = 0; i < collection.Count(); i++)
                {
                    var status = collection.Skip(i).Take(1).Single();
                    status.RawSource = array[i].ToString();
                }
            }

            return deserialized;
        }

        private T DeserializeCollection<T>(string content)
        {
            if (typeof(T) == typeof(byte[]))
            {
                var binary = (IEnumerable) Encoding.UTF8.GetBytes(content);
                var deserialized = (T)binary;
                return deserialized;
            }

            IList collection;
            var type = ConstructCollection<T>(out collection);

            Type cursor = null;
            var generics = typeof(T).GetGenericArguments();
            if(generics.Length > 0)
            {
                var inner = generics[0];
                cursor = typeof(TwitterCursorList<>).MakeGenericType(inner);    
            }

            try
            {
                JArray array = null;
                JObject instance = null;

                instance = ParseInnerContent<T>("trends", content, cursor, instance, ref array);
                instance = ParseInnerContent<T>("users", content, cursor, instance, ref array);
                instance = ParseInnerContent<T>("lists", content, cursor, instance, ref array);
                instance = ParseInnerContent<T>("ids", content, cursor, instance, ref array);

                if(array == null)
                {
                    array = JArray.Parse(content);
                }

                var model = typeof (ITwitterModel).IsAssignableFrom(type);
                var items = array.Select(item => item.ToString());
                if(model)
                {
                    foreach (var c in items)
                    {
                        AddDeserializedItem(c, type, collection);
                    }    
                }
                else
                {
                    foreach (var c in items)
                    {
                        AddDeserializedItemWithoutRawSource(c, type, collection);
                    }
                }
                
                var deserialized = typeof (T) == cursor
                                       ? BindDeserializedItemsIntoCursorCollection<T>(collection, cursor, instance)
                                       : BindDeserializedItemsIntoCollection<T>(collection);

                return deserialized;
            }
            catch(JsonReaderException readerException) // <-- Likely 502 
            {
                TraceException(readerException, type, content);

                AddEmptyItem(content, type, collection);
                
                var deserialized = (T)collection;

                return deserialized;
            }
            catch (Exception ex) // <-- Likely entity mismatch (error)
            {
                TraceException(ex, type, content);

                AddDeserializedItem(content, type, collection);
                
                var deserialized = (T)collection;

                return deserialized;
            }
        }

        private static JObject ParseInnerContent<T>(string entity, string content, Type cursor, JObject instance, ref JArray array)
        {
            if (!content.Contains(string.Format("\"{0}\"", entity)))
            {
                return instance;
            }
            instance = JObject.Parse(content);
            array = ParseFromCursorListOrObject<T>(entity, content, cursor, instance);
            return instance;
        }

        private static JArray ParseFromCursorListOrObject<T>(string type, string content, Type cursor, JObject instance)
        {
            JArray array;
            if(cursor != null && typeof(T) == cursor)
            {
                array = instance != null
                            ? ((JArray)instance[type] ?? JArray.Parse(content))
                            : JArray.Parse(content);
            }
            else
            {
                array = JArray.Parse(content);
            }
            return array;
        }

        private static void TraceException(Exception ex, Type type, string content)
        {
#if !SILVERLIGHT
            Trace.TraceError(string.Concat("TweetSharp: Could not parse content into 'IEnumerable<", type.Name, ">' : '", content));
            Trace.TraceError(ex.Message);
            Trace.TraceError(ex.StackTrace);
#endif
        }

        private static T BindDeserializedItemsIntoCursorCollection<T>(IEnumerable collection, Type cursor, JObject instance)
        {
#if !SILVERLIGHT
            var list = Activator.CreateInstance(
                    cursor, 0, null, new object[] { collection }, CultureInfo.InvariantCulture
                    );
#else
            var list = Activator.CreateInstance(cursor, new object[] {collection});
#endif
            if(instance != null)
            {
                var next = instance["next_cursor"];
                var previous = instance["previous_cursor"];
                ((ICursored)list).NextCursor = (long?)next;
                ((ICursored)list).PreviousCursor = (long?)previous;
            }

            var deserialized = (T)list;
            return deserialized;
        }

        private static T BindDeserializedItemsIntoCollection<T>(IList collection)
        {
            var deserialized = (T) collection;
            return deserialized;
        }

        private void AddDeserializedItem(string c, Type type, IList collection)
        {
            var d = Deserialize(c, type);
            ((ITwitterModel)d).RawSource = c;  
            collection.Add(d);
        }

        private void AddDeserializedItemWithoutRawSource(string c, Type type, IList collection)
        {
            var d = Deserialize(c, type);
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
            return DeserializeJson(response.Content, type);
        }

        public object Deserialize(string content, Type type)
        {
            return DeserializeJson(content, type);
        }
        
        public override string Serialize(object instance, Type type)
        {
            return SerializeJson(instance, type);
        }

        public override string ContentType
        {
            get { return "application/json"; }
        }
    }
}