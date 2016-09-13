using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace TweetSharp
{
#if !SILVERLIGHT && !WINRT
    [Serializable]
#endif
    public enum TwitterSearchResultType
    {
        Mixed,
        Recent,
        Popular
    }

#if !SILVERLIGHT && !WINRT
    [Serializable]
#endif
    public enum TwitterProfileImageSize
    {
        Bigger,
        Normal,
        Mini
    }

#if !SILVERLIGHT && !WINRT
    [Serializable]
#endif
    public enum TwitterEntityType
    {
        HashTag,
        Mention,
        Url,
        Media
    }

#if !SILVERLIGHT && !WINRT
    [Serializable]
#endif
    public enum TwitterPlaceType
    {
        City,
        Neighborhood,
        Country,
        Admin,
        POI
    }

#if !SILVERLIGHT && !WINRT
    [Serializable]
#endif
    public enum TwitterMediaType
    {
        Photo,
				Video,
				AnimatedGif
    }

#if !SILVERLIGHT && !WINRT
	[Serializable]
#endif
    public enum TwitterListMode
    {
        Public,
        Private
    }

	public class TwitterMediaCategory
	{
		public const string Image = "tweet_image";
		public const string AnimatedGif = "tweet_gif";
		public const string Video = "tweet_video";
	}
}