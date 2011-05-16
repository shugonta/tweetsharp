using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Hammock.Model;
using Newtonsoft.Json;

namespace TweetSharp
{
#if !SILVERLIGHT
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
    [DebuggerDisplay("{FromUserScreenName}: {Text}")]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterSearchStatus : PropertyChangedBase,
                                       IComparable<TwitterSearchStatus>,
                                       IEquatable<TwitterSearchStatus>,
                                       ITwitterModel,
                                       ITweetable
    {
        private DateTime _createdDate;
        private int _fromUserId;
        private string _fromUserScreenName;
        private long _id;
        private string _isoLanguageCode;
        private string _profileImageUrl;
        private long _sinceId;
        private string _source;
        private string _text;
        private int? _toUserId;
        private string _toUserScreenName;
        private string _location;
        private TwitterGeoLocation _geoLocation;
        private TwitterEntities _entities;

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
                _entities = null;
                OnPropertyChanged("Text");
            }
        }

        private string _textAsHtml;
        public virtual string TextAsHtml
        {
            get
            {
                if (string.IsNullOrEmpty(Text))
                {
                    return Text;
                }
                return _textAsHtml ?? (_textAsHtml = Text.ParseTwitterageToHtml());
            }
            set
            {
                _textAsHtml = value;
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual ITweeter Author
        {
            get
            {
                return new TwitterUser
                           {
                               ProfileImageUrl = ProfileImageUrl,
                               ScreenName = FromUserScreenName
                           };
            }
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

#if !Smartphone && !NET20
        [DataMember]
#endif
        [Obsolete("This property is currently erroneous as it contains an internal ID")]
        public virtual int? ToUserId
        {
            get { return _toUserId; }
            set
            {
                if (_toUserId == value)
                {
                    return;
                }

                _toUserId = value;
                OnPropertyChanged("ToUserId");
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
        [Obsolete("This property is currently erroneous as it contains an internal ID")]
        public int? FromUserId
        {
            get { return _fromUserId; }
            set
            {
                if (_fromUserId == value)
                {
                    return;
                }

                if (value == null)
                {
                    return;
                }
                
                _fromUserId = (int) value;
                OnPropertyChanged("FromUserId");
            }
        }

        [JsonProperty("from_user")]
#if !Smartphone && !NET20
        [DataMember]
#endif
            public string FromUserScreenName
        {
            get { return _fromUserScreenName; }
            set
            {
                if (_fromUserScreenName == value)
                {
                    return;
                }

                _fromUserScreenName = value;
                OnPropertyChanged("FromUserScreenName");
            }
        }

        [JsonProperty("to_user")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public string ToUserScreenName
        {
            get { return _toUserScreenName; }
            set
            {
                if (_toUserScreenName == value)
                {
                    return;
                }

                _toUserScreenName = value;
                OnPropertyChanged("ToUserScreenName");
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
            public string IsoLanguageCode
        {
            get { return _isoLanguageCode; }
            set
            {
                if (_isoLanguageCode == value)
                {
                    return;
                }

                _isoLanguageCode = value;
                OnPropertyChanged("IsoLanguageCode");
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
            public string ProfileImageUrl
        {
            get { return _profileImageUrl; }
            set
            {
                if (_profileImageUrl == value)
                {
                    return;
                }

                _profileImageUrl = value;
                OnPropertyChanged("ProfileImageUrl");
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
            public long SinceId
        {
            get { return _sinceId; }
            set
            {
                if (_sinceId == value)
                {
                    return;
                }

                _sinceId = value;
                OnPropertyChanged("SinceId");
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
            public string Location
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

        [JsonProperty("geo")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public TwitterGeoLocation GeoLocation
        {
            get { return _geoLocation; }
            set
            {
                if (_geoLocation == value)
                {
                    return;
                }

                _geoLocation = value;
                OnPropertyChanged("TwitterGeoLocation");
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual TwitterEntities Entities
        {
            get { return _entities ?? (_entities = Text.ParseTwitterageToEntities()); }
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

        #region IComparable<TwitterSearchStatus> Members

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
        /// </returns>
        public int CompareTo(TwitterSearchStatus other)
        {
            return other.Id == Id ? 0 : other.Id > Id ? -1 : 1;
        }

        #endregion

        #region IEquatable<TwitterSearchStatus> Members

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="status"/> parameter; otherwise, false.
        /// </returns>
        public bool Equals(TwitterSearchStatus status)
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

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="status">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
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
            return status.GetType() == typeof (TwitterSearchStatus) && Equals((TwitterSearchStatus) status);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(TwitterSearchStatus left, TwitterSearchStatus right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(TwitterSearchStatus left, TwitterSearchStatus right)
        {
            return !Equals(left, right);
        }

        ///<summary>
        /// This implicit conversion supports treating a search status as if it were a 
        /// regular <see cref="TwitterStatus" />. This is useful if you need to combine search
        /// results and regular results in the same UI context.
        ///</summary>
        ///<param name="searchStatus"></param>
        ///<returns></returns>
        public static implicit operator TwitterStatus(TwitterSearchStatus searchStatus)
        {
            var user = new TwitterUser
                           {
                               ProfileImageUrl = searchStatus.ProfileImageUrl,
                               ScreenName = searchStatus.FromUserScreenName
                           };

            var status = new TwitterStatus
                             {
                                 CreatedDate = searchStatus.CreatedDate,
                                 Id = searchStatus.Id,
                                 Source = searchStatus.Source,
                                 RawSource = searchStatus.RawSource,
                                 Text = searchStatus.Text,
                                 User = user
                             };

            return status;
        }

#if !Smartphone && !NET20
        /// <summary>
        /// The source content used to deserialize the model entity instance.
        /// Can be XML or JSON, depending on the endpoint used.
        /// </summary>
        [DataMember]
#endif
        public virtual string RawSource { get; set; }
    }
}