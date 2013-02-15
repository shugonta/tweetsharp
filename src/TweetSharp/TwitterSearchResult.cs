using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TweetSharp
{
#if !SILVERLIGHT
    /// <summary>
    /// The results of a request to the Search API.
    /// </summary>
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
    [DebuggerDisplay("{ResultsPerPage} results on page {Page} from {Source}")]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterSearchResult : ITwitterModel
    {
        [JsonProperty("results")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual IEnumerable<TwitterSearchStatus> Statuses { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual long SinceId { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual long MaxId { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string RefreshUrl { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual int ResultsPerPage { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string NextPage { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string PreviousPage { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual double CompletedIn { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual int Page { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string Query { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string Warning { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string Source { get; set; }

#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual int Total { get; set; }

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