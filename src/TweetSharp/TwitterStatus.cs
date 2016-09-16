using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Hammock.Model;
using Newtonsoft.Json;

namespace TweetSharp
{
#if !SILVERLIGHT && !WINRT
    [Serializable]
#endif
#if !Smartphone && !NET20
	[DataContract]
	[DebuggerDisplay("{User.ScreenName}: {Text}")]
#endif
	[JsonObject(MemberSerialization.OptIn)]
	public class TwitterStatus : PropertyChangedBase,
															 IComparable<TwitterStatus>,
															 IEquatable<TwitterStatus>,
															 ITwitterModel,
															 ITweetable
	{
		private DateTime _createdDate;
		private DateTime _retrievedAt;
		private long _id;
		private string _idStr;
		private string _inReplyToScreenName;
		private long? _inReplyToStatusId;
		private long? _inReplyToUserId;
		private bool _isFavorited;
		private bool _isRetweeted;
		private bool _isTruncated;
		private string _source;
		private string _text;
		private TwitterUser _user;
		private TwitterStatus _retweetedStatus;
		private TwitterGeoLocation _location;
		private string _language;
		private TwitterEntities _entities;
		private TwitterExtendedEntities _extendedEntities;
		private bool? _isPossiblySensitive;
		private TwitterPlace _place;
		private int _retweetCount;
		private int _favoriteCount;
		private bool _isQuoteStatus;
		private long? _quotedStatusId;
		private string _quotedStatusIdStr;
		private TwitterStatus _quotedStatus;

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual long Id
		{
			get { return _id; }
			set
			{
				if (_id == value)
				{
					return;
				}

				_id = value;
				OnPropertyChanged("Id");
			}
		}

		[JsonProperty("id_str")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual string IdStr
		{
			get { return _idStr; }
			set
			{
				if (_idStr == value)
				{
					return;
				}

				_idStr = value;
				OnPropertyChanged("IdStr");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual long? InReplyToUserId
		{
			get { return _inReplyToUserId; }
			set
			{
				if (_inReplyToUserId == value)
				{
					return;
				}

				_inReplyToUserId = value;
				OnPropertyChanged("InReplyToUserId");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual long? InReplyToStatusId
		{
			get { return _inReplyToStatusId; }
			set
			{
				if (_inReplyToStatusId == value)
				{
					return;
				}

				_inReplyToStatusId = value;
				OnPropertyChanged("InReplyToStatusId");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual long? QuotedStatusId
		{
			get { return _quotedStatusId; }
			set
			{
				if (_quotedStatusId == value)
				{
					return;
				}

				_quotedStatusId = value;
				OnPropertyChanged("QuotedStatusId");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual string QuotedStatusIdStr
		{
			get { return _quotedStatusIdStr; }
			set
			{
				if (_quotedStatusIdStr == value)
				{
					return;
				}

				_quotedStatusIdStr = value;
				OnPropertyChanged("QuotedStatusIdStr");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual bool IsQuoteStatus
		{
			get { return _isQuoteStatus; }
			set
			{
				if (_isQuoteStatus == value)
				{
					return;
				}

				_isQuoteStatus = value;
				OnPropertyChanged("IsQuoteStatus");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual TwitterStatus QuotedStatus
		{
			get { return _quotedStatus; }
			set
			{
				if (_quotedStatus == value)
				{
					return;
				}

				_quotedStatus = value;
				OnPropertyChanged("QuotedStatus");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual string InReplyToScreenName
		{
			get { return _inReplyToScreenName; }
			set
			{
				if (_inReplyToScreenName == value)
				{
					return;
				}

				_inReplyToScreenName = value;
				OnPropertyChanged("InReplyToScreenName");
			}
		}

		[JsonProperty("truncated")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual bool IsTruncated
		{
			get { return _isTruncated; }
			set
			{
				if (_isTruncated == value)
				{
					return;
				}

				_isTruncated = value;
				OnPropertyChanged("IsTruncated");
			}
		}

		[JsonProperty("favorited")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual bool IsFavorited
		{
			get { return _isFavorited; }
			set
			{
				if (_isFavorited == value)
				{
					return;
				}

				_isFavorited = value;
				OnPropertyChanged("IsFavorited");
			}
		}

		[JsonProperty("favorite_count")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual int FavoriteCount
		{
			get
			{
				return _favoriteCount;
			}
			set
			{
				if (_favoriteCount == value)
				{
					return;
				}

				_favoriteCount = value;
				OnPropertyChanged("FavoriteCount");
			}
		}

		[JsonProperty("retweeted")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual bool IsRetweeted
		{
			get { return _isRetweeted; }
			set
			{
				if (_isRetweeted == value)
				{
					return;
				}

				_isRetweeted = value;
				OnPropertyChanged("IsRetweeted");
			}
		}

		[JsonProperty("retweet_count")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual int RetweetCount
		{
			get
			{
				return _retweetCount;
			}
			set
			{
				if (_retweetCount == value)
				{
					return;
				}

				_retweetCount = value;
				OnPropertyChanged("RetweetCount");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual string Text
		{
			get { return _text; }
			set
			{
				if (_text == value)
				{
					return;
				}

				_text = value;
				_textAsHtml = null;
				_textDecoded = null;
				OnPropertyChanged("Text");
			}
		}

		private string _textAsHtml;
		public virtual string TextAsHtml
		{
			get
			{
				return (_textAsHtml ?? (_textAsHtml = this.ParseTextWithEntities()));
			}
			set
			{
				_textAsHtml = value;
				this.OnPropertyChanged("TextAsHtml");
			}
		}

		private string _textDecoded;
		public virtual string TextDecoded
		{
			get
			{
				if (string.IsNullOrEmpty(Text))
				{
					return Text;
				}
#if WINRT
				return _textDecoded ?? (_textDecoded = System.Net.WebUtility.HtmlDecode(Text));
#elif !SILVERLIGHT && !WINDOWS_PHONE
                return _textDecoded ?? (_textDecoded = System.Compat.Web.HttpUtility.HtmlDecode(Text));
#elif WINDOWS_PHONE
                return _textDecoded ?? (_textDecoded = System.Net.HttpUtility.HtmlDecode(Text));
#else
                return _textDecoded ?? (_textDecoded = System.Windows.Browser.HttpUtility.HtmlDecode(Text));
#endif
			}
			set
			{
				_textDecoded = value;
				OnPropertyChanged("TextDecoded");
			}
		}

		public ITweeter Author
		{
			get { return User; }
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual string Source
		{
			get { return _source; }
			set
			{
				if (_source == value)
				{
					return;
				}

				_source = value;
				OnPropertyChanged("Source");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual TwitterUser User
		{
			get { return _user; }
			set
			{
				if (_user == value)
				{
					return;
				}

				_user = value;
				OnPropertyChanged("TwitterUser");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual TwitterStatus RetweetedStatus
		{
			get { return _retweetedStatus; }
			set
			{
				if (_retweetedStatus == value)
				{
					return;
				}

				_retweetedStatus = value;
				OnPropertyChanged("RetweetedStatus");
			}
		}

		[JsonProperty("created_at")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual DateTime CreatedDate
		{
			get { return _createdDate; }
			set
			{
				if (_createdDate == value)
				{
					return;
				}

				_createdDate = value;
				OnPropertyChanged("CreatedDate");
			}
		}

		/// <summary>
		/// Returns the UTC date and time (from the local system clock) at which this item was deserialised, usually equivalent to the time it was retrieved from Twitter. 
		/// </summary>
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual DateTime RetrievedAt
		{
			get { return _retrievedAt; }
			set
			{
				if (_retrievedAt == value)
				{
					return;
				}

				_retrievedAt = value;
				OnPropertyChanged("RetrievedAt");
			}
		}

		[JsonProperty("geo")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual TwitterGeoLocation Location
		{
			get { return _location; }
			set
			{
				if (_location == value)
				{
					return;
				}

				_location = value;
				OnPropertyChanged("Location");
			}
		}


		[JsonProperty("lang")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual string Language
		{
			get { return _language; }
			set
			{
				if (_language == value)
				{
					return;
				}

				_language = value;
				OnPropertyChanged("Language");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual TwitterEntities Entities
		{
			get { return _entities; }
			set
			{
				if (_entities == value)
				{
					return;
				}

				_entities = value;
				OnPropertyChanged("Entities");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
		[JsonProperty("extended_entities")]
#endif
		public virtual TwitterExtendedEntities ExtendedEntities
		{
			get { return _extendedEntities; }
			set
			{
				if (_extendedEntities == value)
				{
					return;
				}

				_extendedEntities = value;
				OnPropertyChanged("Entities");
			}
		}

		[JsonProperty("possibly_sensitive")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual bool? IsPossiblySensitive
		{
			get { return _isPossiblySensitive; }
			set
			{
				if (_isPossiblySensitive == value)
				{
					return;
				}

				_isPossiblySensitive = value;
				OnPropertyChanged("IsPossiblySensitive");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual TwitterPlace Place
		{
			get { return _place; }
			set
			{
				if (_place == value)
				{
					return;
				}

				_place = value;
				OnPropertyChanged("Place");
			}
		}

#if !Smartphone && !NET20
		[DataMember]
#endif
		public virtual string RawSource { get; set; }

		#region IComparable<TwitterStatus> Members

		public int CompareTo(TwitterStatus other)
		{
			return other.Id == Id ? 0 : other.Id > Id ? -1 : 1;
		}

		#endregion

		#region IEquatable<TwitterStatus> Members

		public bool Equals(TwitterStatus status)
		{
			if (ReferenceEquals(null, status))
			{
				return false;
			}
			if (ReferenceEquals(this, status))
			{
				return true;
			}
			return status.Id == Id;
		}

		#endregion

		public override bool Equals(object status)
		{
			if (ReferenceEquals(null, status))
			{
				return false;
			}
			if (ReferenceEquals(this, status))
			{
				return true;
			}
			return status.GetType() == typeof(TwitterStatus) && Equals((TwitterStatus)status);
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}

		public static bool operator ==(TwitterStatus left, TwitterStatus right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(TwitterStatus left, TwitterStatus right)
		{
			return !Equals(left, right);
		}

		public Uri ToTwitterUrl()
		{
			var builder = new UriBuilder("https", "twitter.com");
			builder.Path = String.Format("{0}/status/{1}", this.Author.ScreenName, this.Id);
			return builder.Uri;
    }
	}
}