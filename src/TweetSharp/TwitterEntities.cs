﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TweetSharp
{
	// https://dev.twitter.com/docs/tweet-entities

#if !SILVERLIGHT && !WINRT
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

		[JsonProperty("media")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual IList<TwitterMedia> Media { get; set; }

		public TwitterEntities()
		{
			Initialize();
		}

		private void Initialize()
		{
			Mentions = new List<TwitterMention>(0);
			HashTags = new List<TwitterHashTag>(0);
			Urls = new List<TwitterUrl>(0);
			Media = new List<TwitterMedia>(0);
		}

		public IEnumerable<TwitterEntity> Coalesce()
		{
			var entities = new List<TwitterEntity>(Mentions.Count() + HashTags.Count() + Urls.Count() + Media.Count());
			entities.AddRange(Mentions.Cast<TwitterEntity>());
			entities.AddRange(HashTags.Cast<TwitterEntity>());
			entities.AddRange(Urls.Cast<TwitterEntity>());
			entities.AddRange(Media.Cast<TwitterEntity>());
			entities.Sort();

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

	#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
#if !Smartphone && !NET20
	[DataContract]
#endif
	[JsonObject(MemberSerialization.OptIn)]
	public class TwitterVideoInfo 
	{

		[JsonProperty("aspect_ratio")]
		public IList<int> AspectRatio { get; set; }


		[JsonProperty("duration_millis")]
		public long DurationMs { get; set; }

		[JsonProperty("variants")]
		public IList<TwitterMediaVariant> Variants { get; set; }

	}

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
#if !Smartphone && !NET20
	[DataContract]
#endif
	[JsonObject(MemberSerialization.OptIn)]
	public class TwitterExtendedEntities : IEnumerable<TwitterExtendedEntity>
	{

		[JsonProperty("media")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual IList<TwitterExtendedEntity> Media { get; set; }

		public TwitterExtendedEntities()
		{
			Initialize();
		}

		private void Initialize()
		{
			Media = new List<TwitterExtendedEntity>(0);
		}

		public IEnumerable<TwitterExtendedEntity> Coalesce()
		{
			var entities = new List<TwitterExtendedEntity>(Media.Count());
			entities.AddRange(Media.Cast<TwitterExtendedEntity>());
			entities.Sort();
			return entities;
		}

		public IEnumerator<TwitterExtendedEntity> GetEnumerator()
		{
			return Coalesce().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

#if !SILVERLIGHT && !WINRT
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
		[JsonConverter(typeof(TwitterMediaTypeJsonConverter))]
		public virtual TwitterEntityType EntityType { get; protected set; }

		public virtual int StartIndex { get { return Indices.Count > 0 ? Indices[0] : -1; } }

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

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
#if !Smartphone && !NET20
	[DataContract]
#endif
	[JsonObject(MemberSerialization.OptIn)]
	public class TwitterExtendedEntity : TwitterEntity
	{

		public TwitterExtendedEntity()
		{
			base.EntityType = TwitterEntityType.Media;
		}

		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("id_str")]
		public string IdAsString { get; set; }

		[JsonProperty("media_url")]
		public Uri MediaUrl { get; set; }

		[JsonProperty("media_url_https")]
		public Uri MediaUrlHttps { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }

		[JsonProperty("display_url")]
		public Uri DisplayUrl { get; set; }

		[JsonProperty("expanded_url")]
		public Uri ExpandedUrl { get; set; }

		[JsonProperty("type")]
		[JsonConverter(typeof(TwitterMediaTypeJsonConverter))]
		public TwitterMediaType ExtendedEntityType
		{
			get; set;
		}

		[JsonProperty("video_info")]
		public TwitterVideoInfo VideoInfo { get; set; }

		[JsonProperty("sizes")]
		public TwitterMediaSizes Sizes { get; set; }

	}

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
#if !Smartphone && !NET20
		[DataContract]
		[DebuggerDisplay("@{Url}")]
#endif
	public abstract class TwitterAspectRatio
	{
		public int Height { get; set; }
		public int Width { get; set; }
	}

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
#if !Smartphone && !NET20
		[DataContract]
		[DebuggerDisplay("@{Url}")]
#endif
	public class TwitterMediaVariant
	{
		[JsonProperty("bitrate")]
		public long BitRate { get; set; }
		[JsonProperty("content_type")]
		public string ContentType { get; set; }
		[JsonProperty("url")]
		public Uri Url { get; set; }
	}


#if !SILVERLIGHT && !WINRT
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

		[JsonProperty("display_url")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual string DisplayUrl { get; set; }

		public TwitterUrl()
		{
			Initialize();
		}

		private void Initialize()
		{
			EntityType = TwitterEntityType.Url;
		}
	}

#if !SILVERLIGHT && !WINRT
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
			EntityType = TwitterEntityType.Mention;
		}
	}

#if !SILVERLIGHT && !WINRT
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
			EntityType = TwitterEntityType.HashTag;
		}
	}

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
#if !Smartphone && !NET20
		[DataContract]
		[DebuggerDisplay("{MediaType}:{MediaUrl}")]
#endif
	[JsonObject(MemberSerialization.OptIn)]
	public class TwitterMedia : TwitterEntity
	{
		[JsonProperty("id")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual long Id { get; set; }

		[JsonProperty("id_str")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual string IdAsString { get; set; }

		[JsonProperty("media_url")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual string MediaUrl { get; set; }

		[JsonProperty("media_url_https")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual string MediaUrlHttps { get; set; }

		[JsonProperty("url")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual string Url { get; set; }

		[JsonProperty("display_url")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual string DisplayUrl { get; set; }

		[JsonProperty("expanded_url")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual string ExpandedUrl { get; set; }

		[JsonProperty("type")]
		[JsonConverter(typeof(TwitterMediaTypeJsonConverter))]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual TwitterMediaType MediaType { get; set; }

		[JsonProperty("sizes")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual TwitterMediaSizes Sizes { get; set; }

		public TwitterMedia()
		{
			Initialize();
		}

		private void Initialize()
		{
			EntityType = TwitterEntityType.Media;
		}
	}

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
#if !Smartphone && !NET20
		[DataContract]
#endif
	[JsonObject(MemberSerialization.OptIn)]
	public class TwitterMediaSizes : IEnumerable<TwitterMediaSize>
	{
		[JsonProperty("thumb")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual TwitterMediaSize Thumb { get; set; }

		[JsonProperty("small")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual TwitterMediaSize Small { get; set; }

		[JsonProperty("medium")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual TwitterMediaSize Medium { get; set; }

		[JsonProperty("large")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual TwitterMediaSize Large { get; set; }

		public IEnumerator<TwitterMediaSize> GetEnumerator()
		{
			return Coalesce().GetEnumerator();
		}

		private IEnumerable<TwitterMediaSize> Coalesce()
		{
			var sizes = new List<TwitterMediaSize>();
			if (Thumb != null)
			{
				sizes.Add(Thumb);
			}
			if (Small != null)
			{
				sizes.Add(Small);
			}
			if (Medium != null)
			{
				sizes.Add(Medium);
			}
			if (Large != null)
			{
				sizes.Add(Large);
			}
			return sizes;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
#if !Smartphone && !NET20
		[DataContract]
#endif
	[JsonObject(MemberSerialization.OptIn)]
	public class TwitterMediaSize
	{
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual string Resize { get; set; }

		[JsonProperty("w")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual int Width { get; set; }

		[JsonProperty("h")]
#if !Smartphone && !NET20
				[DataMember]
#endif
		public virtual int Height { get; set; }
	}
}
