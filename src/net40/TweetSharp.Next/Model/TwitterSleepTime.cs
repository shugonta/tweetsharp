using System;
using System.Runtime.Serialization;
using Hammock.Model;
using Newtonsoft.Json;

namespace TweetSharp
{
    // "sleep_time":{"start_time":0,"end_time":12,"enabled":true}
    // (apparently I sleep from midnight to noon)

    #if !SILVERLIGHT
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterSleepTime : PropertyChangedBase,
                                    IComparable<TwitterSleepTime>,
                                    IEquatable<TwitterSleepTime>,
                                    ITwitterModel
    {
        private int _startTime;
        private int _endTime;
        private bool? _enabled;

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual int StartTime
        {
            get { return _startTime; }
            set
            {
                if (_startTime == value)
                {
                    return;
                }

                _startTime = value;
                OnPropertyChanged("StartTime");
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual int EndTime
        {
            get { return _endTime; }
            set
            {
                if (_endTime == value)
                {
                    return;
                }

                _endTime = value;
                OnPropertyChanged("EndTime");
            }
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
        // This property is currently undocumented; it is a string to avoid breaking serialization
        public virtual bool? Enabled
        {
            get { return _enabled; }
            set
            {
                if (_enabled == value)
                {
                    return;
                }

                _enabled = value;
                OnPropertyChanged("StartTime");
            }
        }

        public int CompareTo(TwitterSleepTime other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(TwitterSleepTime other)
        {
            throw new NotImplementedException();
        }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string RawSource { get; set; }
    }
}
