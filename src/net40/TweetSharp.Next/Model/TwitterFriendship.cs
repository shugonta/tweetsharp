using System;
using System.Runtime.Serialization;
using Hammock.Model;
using Newtonsoft.Json;

namespace TweetSharp
{
    /* {"relationship": {
            "source": {
                "id": 123,
                "screen_name": "bob",
                "following": true,
                "followed_by": false,
                "notifications_enabled": false
     *      }
     *      ,
            "target": {
                "id": 456,
                "screen_name": "jack",
                "following": false,
                "followed_by": true,
                "notifications_enabled": null
     *      }
     *   }
     * }
     */

#if !SILVERLIGHT
    [Serializable]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterFriendship : PropertyChangedBase, ITwitterModel
    {
        private TwitterRelationship _relationship;

#if !Smartphone && !NET20
        /// <summary>
        /// Gets or sets the relationship.
        /// </summary>
        /// <value>The relationship.</value>
        [DataMember]
#endif
        [JsonProperty("relationship")]
        public virtual TwitterRelationship Relationship
        {
            get { return _relationship; }
            set
            {
                if (_relationship == value)
                {
                    return;
                }

                _relationship = value;
                OnPropertyChanged("Relationship");
            }
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