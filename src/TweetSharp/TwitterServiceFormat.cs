namespace TweetSharp
{
    public enum TwitterServiceFormat
    {
        Json,
#if !WINDOWS_PHONE
        Xml
#endif
    }
}