using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TweetSharp
{
#if !SILVERLIGHT
    /// <summary>
    /// Represents an error received from the Twitter API.
    /// </summary>
    [Serializable]
#endif
#if !Smartphone && !NET20
    [DataContract]
    [DebuggerDisplay("{ErrorMessage} ({Request})")]
#endif
    [JsonObject(MemberSerialization.OptIn)]
    public class TwitterError : ITwitterModel
    {
        /// <summary>
        /// Gets or sets the request hash.
        /// This is typically the URL slug for the API method
        /// that issued the error.
        /// </summary>
        /// <value>The request.</value>
        [JsonProperty("request")]
#if !Smartphone && !NET20
        [DataMember]
#endif
        public virtual string Request { get; set; }

        /// <summary>
        /// Gets or sets the error code. 
        /// This appears when errors appear as a collection.
        /// It is part of the 'new' errors schema.
        /// </summary>
        public virtual int Code { get; set; }

        /// <summary>
        /// Gets or sets the error message. 
        /// This appears when errors appear as a collection.
        /// It is part of the 'new' errors schema.
        /// It is functionally the same as the previous "error" element.
        /// </summary>
        internal virtual string Message { get; set; }

        /// <summary>
        /// Gets or sets the error message returned from Twitter.
        /// It is part of the 'old' errors schema.
        /// </summary>
        /// <value>The error message.</value>
#if !Smartphone && !NET20
        [DataMember]
#endif
        internal virtual string Error { get; set; }

        /// <summary>
        /// Gets the value of either the Error element or the
        /// Message element, depending on the schema of the original 
        /// error that was received by Twitter.
        /// </summary>
        public virtual string ErrorMessage
        {
            get
            {
                return string.IsNullOrEmpty(Error) ? Message : Error;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return ErrorMessage;
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