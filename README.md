
**_This is a fork of TweetSharp, the fine work of Daniel Crenna. v2.3.1 was the final release of TweetSharp, this builds on that._**

This repository includes the latest code from the TweetSharp repository (which is newer than the published TweetSharp nuget package) and includes support for long twitter id's. Addtionally there are WinRT compatible libraries with basic async/await support.

[![Build status](https://ci.appveyor.com/api/projects/status/209drvklf46hp069?svg=true)](https://ci.appveyor.com/project/Yortw/tweetmoasharp)

[![NuGet Badge](https://buildstats.info/nuget/TweetMoaSharp)](https://www.nuget.org/packages/TweetMoaSharp/)

#### Async Auth Examples

A number of people struggle with using TweetMoaSharp on platforms such as Windows Phone, WinRT and UWP because these platforms do NOT suppport "synchronous calls". Any call that involves I/O much be made "asynchronously" so it doesn't block the UI thread. Since most TweetMoaSharp methods access the network, you must use the async versions of those methods on these platforms. 

The original TweetSharp samples are all synchronous method based (although me async patterns were supported). People tend to try these samples on the platforms where synchronous methods aren't supported. Below are two async samples to help get you started on these platforms.

###### Task Based Async
This is recommended on platforms that support it (WinRT/UWP/.Net 4.5+). 

```csharp

using TweetSharp;
using System.Threading.Tasks;

// Note: This method containing this code must be marked 'async'

// Pass your credentials to the service
TwitterService service = new TwitterService("consumerKey", "consumerSecret");

// Step 1 - Retrieve an OAuth Request Token
OAuthRequestToken requestToken = await service.GetRequestTokenAsyc();

// Step 2 - Redirect to the OAuth Authorization URL
Uri uri = service.GetAuthorizationUri(requestToken);
Process.Start(uri.ToString());

// Step 3 - Exchange the Request Token for an Access Token
string verifier = "123456"; // <-- This is input into your application by your user
OAuthAccessToken access = await service.GetAccessTokenAsync(requestToken, verifier);

// Step 4 - User authenticates using the Access Token
service.AuthenticateWith(access.Token, access.TokenSecret);
var result = await service.ListTweetsMentioningMeAsync();
IEnumerable<TwitterStatus> mentions = result.Value;
```

###### Callback Based Async
This is available on older platforms, like Windows Phone (pre WinRT).

```csharp

using TweetSharp;

TweetSharp.TwitterService ts = new TweetSharp.TwitterService("MyConsumerKey", "MyConsumerSecret");
//Step 1, get a request token
ts.GetRequestToken((token, response) =>
{
	//If we got an ok response
	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		//Step 2 - Convert to an auth uri
		var authUri = ts.GetAuthorizationUri(token);

		//Display the page at the auth uri location to the user
		//Probably use the web application broken, or your own web view

		// Step 3 - Exchange the Request Token for an Access Token
		string verifier = "123456"; // <-- This is input into your application by your user
		ts.GetAccessToken(token, verifier, (accessToken, atResponse) =>
		{
			// Step 4 - Provide the auth token to the TwitterService and then make an
			// authed call.
			ts.AuthenticateWith(accessToken.Token, accessToken.TokenSecret);
			ts.ListTweetsMentioningMe(new TweetSharp.ListTweetsMentioningMeOptions(), (statuses, sResponse) =>
			{
				// The variables "statues" contains the returned list of tweets.
			});
		});
	}
});

```

**_The following is from the (latest version of the) original TweetSharp readme_**

#### Addressing issues with deserialization 
In some cases, and mostly reported when trying to access the timeline of a protected user, the deserializer can get into an
infinite recursion state that causes a StackOverflowException. The ability to reproduce this comes and goes, as it's mainly 
due to some brittleness in the serializer caused by trying to anticipate too many possible branches of code. Currently this
use case seems to work. Twitter's JSON structures are not typical class-with-properties mappings meaning they need custom 
conversion. After several years, this code looks long in the tooth and probably will run into similar issues now or in the 
future. You can override the serializer by either setting the TwitterService.Deserialize property instantiation or using the
constructor overload, if you have the appetite to replace it with something better. - Daniel

#### Introduction
TweetSharp is a Twitter API library that greatly simplifies the task of adding Twitter to your desktop, web, and mobile applications. You can build simple widgets, or complex application suites using TweetSharp. The second version, a rewrite,  was designed to be lighter, faster, and more intuitive than the original. You write fewer lines of code, make fewer decisions, and get better results. Visual Studio T4 templates are employed to automatically generate new API methods from a simple text-based DSL.

#### Open source support
This project is open source software. I am happy to accept any reasonable pull requests, and the code is written with Visual Studio 
T4 templates, making it ridiculously easy to extend for any API methods that Twitter introduces in the future. Historically, almost
no pull requests are received, so please plan accordingly, engage commercial support, or help out!

#### Commercial support
I no longer offer commercial support services for TweetSharp. It is now in its final state. 
TweetSharp V2 in general wouldn't have been possible without the sponsorship of SmartParents.

[![SmartParents](https://raw.github.com/danielcrenna/tweetsharp/master/sponsors/SmartParents_RGB_logo_250px.png)](http://smartparents.com)

#### Learn the Twitter API
Make sure you visit (http://dev.twitter.com) to get acquainted with the Twitter API. Most of the time, confusion
around the methods in this library are a result of not understanding Twitter's requirements, or the OAuth authentication
workflow.

#### Hello, Twitter
```csharp
using TweetSharp;

// In v1.1, all API calls require authentication
var service = new TwitterService(_consumerKey, _consumerSecret);
service.AuthenticateWith(_accessToken, _accessTokenSecret);

var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
foreach (var tweet in tweets)
{
    Console.WriteLine("{0} says '{1}'", tweet.User.ScreenName, tweet.Text);
}
```

### OAuth Authentication

The first step to accessing the Twitter API is to create an application at (http://dev.twitter.com). 
When that process is complete, your application is issued a `Consumer Key` and `Consumer Secret`. 
These tokens are responsible for identifying your application when it is in use by your customers. 
Once you have these values, you can create a new service and pass them in.

#### Authenticating a client application (i.e. desktop)

```csharp
using TweetSharp;

// Pass your credentials to the service
TwitterService service = new TwitterService("consumerKey", "consumerSecret");

// Step 1 - Retrieve an OAuth Request Token
OAuthRequestToken requestToken = service.GetRequestToken();

// Step 2 - Redirect to the OAuth Authorization URL
Uri uri = service.GetAuthorizationUri(requestToken);
Process.Start(uri.ToString());

// Step 3 - Exchange the Request Token for an Access Token
string verifier = "123456"; // <-- This is input into your application by your user
OAuthAccessToken access = service.GetAccessToken(requestToken, verifier);

// Step 4 - User authenticates using the Access Token
service.AuthenticateWith(access.Token, access.TokenSecret);
IEnumerable<TwitterStatus> mentions = service.ListTweetsMentioningMe();
```

#### Authenticating a browser application

```csharp
using TweetSharp;

public ActionResult Authorize()
{
    // Step 1 - Retrieve an OAuth Request Token
    TwitterService service = new TwitterService("consumerKey", "consumerSecret");
    
    // This is the registered callback URL
    OAuthRequestToken requestToken = service.GetRequestToken("http://localhost:9090/AuthorizeCallback"); 
    
    // Step 2 - Redirect to the OAuth Authorization URL
    Uri uri = service.GetAuthorizationUri(requestToken);
    return new RedirectResult(uri.ToString(), false /*permanent*/);
}

// This URL is registered as the application's callback at http://dev.twitter.com
public ActionResult AuthorizeCallback(string oauth_token, string oauth_verifier)
{
    var requestToken = new OAuthRequestToken {Token = oauth_token};
    
    // Step 3 - Exchange the Request Token for an Access Token
    TwitterService service = new TwitterService(_consumerKey, _consumerSecret);
    OAuthAccessToken accessToken = service.GetAccessToken(requestToken, oauth_verifier);

    // Step 4 - User authenticates using the Access Token
    service.AuthenticateWith(accessToken.Token, accessToken.TokenSecret);
    TwitterUser user = service.VerifyCredentials();
    ViewModel.Message = string.Format("Your username is {0}", user.ScreenName);
    return View();
}
```

#### xAuth Authentication
If you are building a mobile application and want to benefit from a seamless authentication 
experience with no additional steps for the user, you need to enroll your application in 
Twitter's xAuth support. You must complete this step in order for xAuth to function correctly.

```csharp
using TweetSharp;

// OAuth Access Token Exchange
TwitterService service = new TwitterService("consumerKey", "consumerSecret");
OAuthAccessToken access = service.GetAccessTokenWithXAuth("username", "password");
```

#### OAuth Delegation with Echo
Twitter provides OAuth Echo support, which allows you to use other services like TwitPic by 
delegating the user's existing credentials. TweetSharp uses [Hammock](http://github.com/danielcrenna/hammock) 
both internally and as a tool for you to make delegated requests. This example shows how you would use 
TweetSharp and Hammock together to post an image on TwitPic using OAuth. You could use any HTTP client
as long as you add the same request meta-data.

```csharp
using TweetSharp;
using Hammock;

TwitterService service = new TwitterService(consumerKey, consumerSecret);
service.AuthenticateWith("accessToken", "accessTokenSecret");

// Prepare an OAuth Echo request to TwitPic
RestRequest request = service.PrepareEchoRequest(); 
request.Path = "uploadAndPost.xml";
request.AddFile("media", "failwhale", "failwhale.jpg", "image/jpeg");
request.AddField("key", "apiKey"); // <-- Sign up with TwitPic to get an API key
request.AddField("message", "Failwhale!");

// Post photo to TwitPic with Hammock
RestClient client = new RestClient { Authority = "http://api.twitpic.com/", VersionPath = "2"};
RestResponse response = client.Request(request);
```

### Discovering API Methods

TweetSharp uses a consistent method naming convention to help you locate the method you're looking for.
In general, methods that return multiple results begin with `List`, while methods that return a single result
begin with `Get`. Most methods, like the Twitter API, have additional parameters for obtaining pages of results 
rather than the default count. Keep in mind that paging methods have limits that you can confirm at 
(http://dev.twitter.com). Here's a sample of some of the most common Twitter API methods:

```csharp
using TweetSharp;

TwitterStatus GetTweet(new GetTweetOptions { Id = 12345 });
TwitterStatus SendTweet(new SendTweetOptions { Status = "Hello, world!" });

IEnumerable<TwitterStatus> ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions { SinceId = 12345 ));
IEnumerable<TwitterStatus> ListTweetsMentioningMe(new ListTweetsMentioningMe { SinceId = 12345 ));
```

### Dealing with Twitter API Rate Limiting

Twitter limits the frequency of all API calls in a variety of ways, to help ensure the service is not abused.
This means that your applications will have to account for possible rate limit shortages at the user and API
endpoint level. Client applications that are meant for public consumption usually use the rate limit profile 
of users that are logging in to their application.  You can find out more about rate limiting at 
(https://dev.twitter.com/docs/rate-limiting/1.1). 

TweetSharp provides two ways to access rate limiting data. You can either make an explicit API call to 
retrieve it, or inspect the `TwitterResponse`'s `RateLimitStatus` property, if it's available. 
The latter option conserves HTTP traffic, as the information is embedded in the HTTP response itself.

```csharp
using TweetSharp;

TwitterService service = new TwitterService("consumerKey", "consumerSecret");
service.AuthenticateWith("accessToken", "accessTokenSecret");

// Option 1 - Retrieve from the API (a list of all endpoints and rates)
TwitterRateLimitStatusSummary rate = service.GetRateLimitStatus();

// Option 2 - Retrieve from the response (scoped to the last request)
IEnumerable<TwitterStatus> mentions = service.ListTweetssMentioningMe(new ListTweetsMentioningMeOptions());
TwitterRateLimitStatus rate = service.Response.RateLimitStatus;
Console.WriteLine("You have used " + rate.RemainingHits + " out of your " + rate.HourlyLimit);
```

### Asynchronous Methods

TweetSharp supports executing methods asynchronously, and provides two styles of operation. 
The first is a delegate style, where you pass an `Action` into the named method after any optional parameters. 
This `Action` provides you with both the expected response that you would get if you called the method sequentially, 
as well as the response info you would have accessed on `TwitterService`'s `Response` property.

#### Asynchronous operation (delegate style)
```csharp
using TweetSharp;

TwitterService service = GetAuthenticatedService();
IAsyncResult result = service.ListTweetsOnHomeTimeline(
    (tweets, response) =>
        {
            if(response.StatusCode == HttpStatusCode.OK)
            {
                foreach (var tweet in tweets)
                {
                    Console.WriteLine("{0} said '{1}'", tweet.User.ScreenName, tweet.Text);
                }
            }
        });
```
In addition to delegate-based asynchronous methods, TweetSharp lets you simplify asynchronous operations 
with the familiar .NET `Begin`/`End` pattern. This style of operation involves calling the same methods 
as the synchronous style, but prefixing the method with `Begin`. Similarly, to retrieve the results you 
were looking for, you call the appropriate method beginning with `End`, with the option to provide a 
timeout value.

#### Asynchronous operation (begin/end style)
```csharp
using TweetSharp;

var service = GetAuthenticatedService();
IAsyncResult result = service.BeginListTweetsOnHomeTimeline(new BeginListTweetsOnHomeTimelineOptions());
IEnumerable<TwitterStatus> tweets = service.EndListTweetsOnHomeTimeline(result);

foreach (var tweet in tweets)
{
    Console.WriteLine("{0} said '{1}'", tweet.User.ScreenName, tweet.Text);
}
```

#### Using Windows Phone
TweetSharp is designed with Windows Phone 7 in mind. 
Each sequential method on `TwitterService` also has an asynchronous equivalent for Windows Phone. 
Rather than expect a response, each method asks for a delegation `Action` to perform, which provides 
the expected result, as well as a wrapper class to help you handle unexpected results in your application.

```csharp
using TweetSharp;

Dispatcher dispatcher = Deployment.Current.Dispatcher;
TwitterService service = new TwitterService("consumerKey", "consumerSecret");
service.AuthenticateWith("accessToken", "accessTokenSecret");

// Example: Getting Mentions
service.ListTweetsMentioningMe(new ListTweetsMentioningMeOptions(), (statuses, response) =>
{
    if(response.StatusCode == HttpStatusCode.OK)
    {
        foreach (var status in statuses)
        {
            TwitterStatus tweet = status;
            dispatcher.BeginInvoke(() => tweets.Items.Add(tweet));
        }
    }
    else
    {
        throw new Exception(response.StatusCode.ToString());
    }
});

// Example: Posting a Tweet
service.SendTweet(new SendTweetOptions { Status = "Tweeting with #tweetsharp for #wp7"}, (tweet, response) =>
{
    if (response.StatusCode == HttpStatusCode.OK)
    {
        dispatcher.BeginInvoke(() => tweets.Items.Add(tweet));
    }
    else
    {
        throw new Exception(response.StatusCode.ToString());
    }
});
```

#### Data Format Handling

By default, TweetSharp handles serialization and deserialization details for you. 
Twitter v1.1 only supports JSON serialization. the `RawSource` property on each model 
contains the JSON retrieved from Twitter for each object.

If you go one step further and decide you don't trust our serializer, you can change `TwitterService`'s
`Serializer` and `Deserializer` properties, setting them to Hammock-compatible interfaces, 
and `TwitterService` will then defer to your custom serializer in all requests.

```csharp
using TweetSharp;
using Hammock.Serialization;

MyAwesomeSerializer serializer = new MyAwesomeSerializer();
TwitterService service = new TwitterService("consumerKey", "consumerSecret");
service.Serializer = serializer;
service.Deserializer = serializer;
```

### Handling Errors

There are three ways of handling errors at the Twitter API level. 

* You can use the `TwitterResponse` object to inspect details about the request and act accordingly. This object is available sequentially using `TwitterService`'s `Response` property, which means the `Response` property will update after each API call is complete. If you're using Windows Phone 7, you get the `TwitterResponse` object passed into each `Action` delegate, so you know the response you're accessing belongs to the request that's returning through the callback. 

* TweetSharp uses a relaxed JSON parsing strategy to mitigate exceptions when API objects change. TweetSharp will return a null value if something went wrong, and the `Response` object's `TwitterError` property will be populated with more details.

* If you're not confident with the deserialization of your object, you can use the `RawSource` property that exists on all Twitter model objects to inspect the actual JSON response that was returned by Twitter, specific to that object. This means if you returned a collection of tweets, each tweet's `RawSource` will contain the JSON for that specific tweet. This is helpful if you want to perform custom parsing or tracing of the raw data.

#### Error Handling Examples (sequential service calls)

```csharp
using TweetSharp;

TwitterService service = new TwitterService(_consumerKey, _consumerSecret)();

// Missing authentication; this call will fail
IEnumerable<TwitterStatus> mentions = service.ListTweetsMentioningMe(new ListTweetsMentioningMeOptinos()); 

// Look for bad requests by inspecting the response for important info
if(service.Response.StatusCode == HttpStatusCode.OK) // <-- Should be 401 - Unauthorized
{ 
    // Look for a null object if a real error, or serialization problem, occurred
    if(mentions == null)
    {
        // If a real error occurred, you can get it here        
        TwitterError error = service.Response.TwitterError;
        if(error != null)
        {
            // You now know you have a real error from Twitter, and can handle it
        }
        else
        {
            // It could be an issue with serialization, you can check the content
            var content = service.Response.Response;
            
            Console.WriteLine(content);
            
            // And try to deserialize it into something else
            var myError = service.Deserialize<MyTwitterError>(content);
        }
    }
}
else
{
    // Likely this is an error; we don't have to go fishing for it
    TwitterError error = service.Response.TwitterError;
    if(error != null)
    {
        // You now know you have a real error from Twitter, and can handle it
    }
}
```

### Using Twitter Entities
TweetSharp supports Twitter's entities feature. This feature provides additional metadata for locating mentions, links, and hashtags embedded in tweet text. TweetSharp goes a step further, emulating the entities support for classes that Twitter currently doesn't support, that implement `ITweetable`; namely `TwitterStatus`, `TwitterDirectMessage` and `TwitterSearchStatus`. All three of these classes contain an `Entities` property. This allows you to find these elements in UI columns that contain multiple tweet types, via the `ITweetable` interface. To retrieve all of the entities in an `ITweetable` ordered by where they appear in the text itself, you can call the `Coalesce` method on the relevant `TwitterEntities` instance.

### Client Development Features
TweetSharp is a bit more than an API wrapper, it also provides support for client application development beyond the data. In this section, TweetSharp's features specific to developing client applications on the .NET Framework are highlighted.

* All model objects are `[Serializable]`, implement `IPropertyNotifyChanged`, use virtual signatures, and implement `DataContract` / `DataMember` where supported. This means all of our model objects are persistable in frameworks like NHibernate, observable in WPF, and serializable for over-the-wire communication in WCF.

* `ITweetable` and `ITweeter`: `TwitterStatus`, `TwitterDirectMessage`, and `TwitterSearchStatus` all implement `ITweetable`, which is an interface to make it easier to blend tweets from different sources into the same UI display. `ITweeter` helps encapsulate common user display properties, and TweetSharp even provides emulation of the entity metadata for non-timeline `ITweetable`s; this means that you can access mentions, hashtags, and links embedded in the text of any `ITweetable`, in the order they appear. 

These are the UI interfaces:

```csharp
public interface ITweetable
{
    long Id { get; }
    string Text { get; }
    ITweeter Author { get; }
    DateTime CreatedDate { get; }
    TwitterEntities Entities { get; }
}

public interface ITweeter
{
    string ScreenName { get; }
    string ProfileImageUrl { get; }
}
```





