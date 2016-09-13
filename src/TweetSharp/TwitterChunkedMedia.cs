using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TweetSharp
{
	public class TwitterChunkedMedia
	{
		[JsonProperty("media_id")]
		public long MediaId { get; set; }
	}
}