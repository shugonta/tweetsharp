using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TweetSharp
{
	public class UploadMediaResult
	{
		[JsonProperty("media_id")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public long Id { get; set; }

		[JsonProperty("media_id_string")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public long IdStr { get; set; }

		[JsonProperty("size")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public long Size { get; set; }

		[JsonProperty("expires_after_secs")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public long ExpiresAfterSeconds { get; set; }

		[JsonProperty("video")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public TwitterVideoInfo Video { get; set; }

		[JsonProperty("processing_info")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public MediaProcessingInfo ProcessingInfo { get; set; }

	}
 
	public class MediaProcessingInfo
	{
		[JsonProperty("state")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public TwitterMediaProcessingState State { get; set; }

		[JsonProperty("check_after_secs")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public long CheckAfterSeconds { get; set; }

		[JsonProperty("progress_percent")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public int ProgressPercent { get; set; }

		[JsonProperty("error")]
#if !Smartphone && !NET20
		[DataMember]
#endif
		public TwitterError Error { get; set; }
	}

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
	[JsonConverter(typeof(TwitterMediaProcessingStateJsonConverter))]
	public enum TwitterMediaProcessingState
	{
		Pending,
		InProgress,
		Failed,
		Succeeded
	}
}