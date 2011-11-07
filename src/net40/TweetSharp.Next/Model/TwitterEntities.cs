using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TweetSharp
{
    /*
     <entities>
        <user_mentions>
            <user_mention end="12" start="3">
                <id>972651</id>
                <screen_name>mashable</screen_name>
                <name>Pete Cashmore</name>
            </user_mention>
            <user_mention end="22" start="13">
                <id>13058772</id>
                <screen_name>LinkedIn</screen_name>
                <name>LinkedIn</name>
            </user_mention>
        </user_mentions>
        <urls>
            <url end="83" start="63">
            <url>http://bit.ly/bkB7cA</url>
            </url>
        </urls>
        <hashtags>
            <hashtag end="93" start="84">
            <text>linkedin</text>
            </hashtag>
            <hashtag end="101" start="94">
            <text>tweets</text>
            </hashtag>
            <hashtag end="110" start="102">
            <text>twitter</text>
            </hashtag>
        </hashtags>
        </entities>
     */

#if !SILVERLIGHT
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterEntities : IEnumerable<TwitterEntity>
    {
        [JsonProperty("user_mentions")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual IList<TwitterMention> Mentions { get; set; }
        
        [JsonProperty("hashtags")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual IList<TwitterHashTag> HashTags { get; set; }
      
        [JsonProperty("urls")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual IList<TwitterUrl> Urls { get; set; }

        public TwitterEntities()
        {
            Initialize();
        }

        private void Initialize()
        {
            Mentions = new List<TwitterMention>(0);
            HashTags = new List<TwitterHashTag>(0);
            Urls = new List<TwitterUrl>(0);
        }

        public IEnumerable<TwitterEntity> Coalesce()
        {
#if !WINDOWS_PHONE
            var entities = new List<TwitterEntity>(Mentions.Count() + HashTags.Count() + Urls.Count());
            entities.AddRange((IEnumerable<TwitterEntity>) Mentions);
            entities.AddRange((IEnumerable<TwitterEntity>) HashTags);
            entities.AddRange((IEnumerable<TwitterEntity>) Urls);
            entities.Sort();
#else
            var entities = new List<TwitterEntity>(Mentions.Count() + HashTags.Count() + Urls.Count());
            entities.AddRange(Mentions.Cast<TwitterEntity>());
            entities.AddRange(HashTags.Cast<TwitterEntity>());
            entities.AddRange(Urls.Cast<TwitterEntity>());
            entities.Sort();
#endif

            return entities;
        }

        public IEnumerator<TwitterEntity> GetEnumerator()
        {
            return Coalesce().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

#if !SILVERLIGHT
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class TwitterEntity : IComparable<TwitterEntity>, IComparer<TwitterEntity>
    {
        [JsonProperty("indices")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual IList<int> Indices { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual TwitterEntityType Type { get; protected set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual int StartIndex { get { return Indices.Count > 0 ? Indices[0] : -1; }}

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual int EndIndex { get { return Indices.Count > 1 ? Indices[1] : -1; } }

        public virtual int CompareTo(TwitterEntity other)
        {
            return StartIndex.CompareTo(other.StartIndex);
        }

        public virtual int Compare(TwitterEntity x, TwitterEntity y)
        {
            return x.StartIndex.CompareTo(y.StartIndex);
        }
    }

#if !SILVERLIGHT
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
    [DebuggerDisplay("@{Value}")]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterUrl : TwitterEntity
    {
        [JsonProperty("url")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string Value { get; set; }

        [JsonProperty("expanded_url")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string ExpandedValue { get; set; }

        public TwitterUrl()
        {
            Initialize();
        }

        private void Initialize()
        {
            Type = TwitterEntityType.Url;
        }
    }

#if !SILVERLIGHT
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
    [DebuggerDisplay("@{ScreenName}")]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterMention : TwitterEntity
    {
        [JsonProperty("id")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual long Id { get; set; }

        [JsonProperty("screen_name")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string ScreenName { get; set; }

        [JsonProperty("name")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string Name { get; set; }

        public TwitterMention()
        {
            Type = TwitterEntityType.Mention;
        }
    }

#if !SILVERLIGHT
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
    [DebuggerDisplay("#{Text}")]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterHashTag : TwitterEntity
    {
        [JsonProperty("text")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string Text { get; set; }

        public TwitterHashTag()
        {
            Initialize();
        }

        private void Initialize()
        {
            Type = TwitterEntityType.HashTag;
        }
    }
}
