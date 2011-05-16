using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using NUnit.Framework;

namespace TweetSharp.Tests.Service
{
    [TestFixture]
    public partial class TwitterServiceTests
    {
        private readonly string _hero;
        private readonly string _consumerKey;
        private readonly string _consumerSecret;
        private readonly string _accessToken;
        private readonly string _accessTokenSecret;

        public TwitterServiceTests()
        {
            _hero = ConfigurationManager.AppSettings["Hero"];
            _consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
            _consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
            _accessToken = ConfigurationManager.AppSettings["AccessToken"];
            _accessTokenSecret = ConfigurationManager.AppSettings["AccessTokenSecret"];
        }

        [Test]
        public void Can_parse_ids_greater_than_53_bits()
        {
            const string json = "{ \"id\": 90071992547409921}";
            var status = new TwitterService().Deserialize<TwitterStatus>(json);
            Assert.IsNotNull(status);
            Assert.AreEqual(90071992547409921, status.Id);
        }

        [Test]
        public void Can_get_public_timeline()
        {
            var service = new TwitterService();
            var tweets = service.ListTweetsOnPublicTimeline();

            Assert.IsNotNull(tweets);
            Assert.AreEqual(20, tweets.Count());

            Assert.IsNotNull(service.Response);
            Assert.AreEqual(HttpStatusCode.OK, service.Response.StatusCode);
            
            var unfavorited = 20;
            foreach (var tweet in tweets)
            {
                Assert.IsNotNullOrEmpty(tweet.RawSource);
                Assert.AreNotEqual(default(DateTime), tweet.CreatedDate);

                Console.WriteLine("{0} said '{1}'", tweet.User.ScreenName, tweet.Text);
                if(tweet.IsFavorited)
                {
                    unfavorited--;
                }
            }

            Assert.IsTrue(unfavorited > 0);
            AssertRateLimitStatus(service);
        }

        [Test]
        public void Can_get_direct_messages()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);
            var dms = service.ListDirectMessagesReceived();

            Assert.IsNotNull(dms);
            Assert.IsTrue(dms.Count() <= 20);

            Assert.IsNotNull(service.Response);
            AssertResultWas(service, HttpStatusCode.OK);

            foreach (var tweet in dms)
            {
                Assert.IsNotNull(tweet.RawSource);
                Assert.AreNotEqual(default(DateTime), tweet.CreatedDate);

                Console.WriteLine("{0} said '{1}'", tweet.SenderScreenName, tweet.Text);
            }

            AssertRateLimitStatus(service);
        }

        [Test]
        public void Can_get_public_timeline_async_callback_style()
        {
            var service = new TwitterService();
            var result = service.ListTweetsOnPublicTimeline(
                (tweets, response) =>
                    {
                        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
                        Assert.IsNotNull(tweets);
                        Assert.AreEqual(20, tweets.Count());

                        foreach (var tweet in tweets)
                        {
                            Console.WriteLine("{0} said '{1}'", tweet.User.ScreenName, tweet.Text);
                        }
                    });

            result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5));
        }

        [Test]
        public void Can_get_public_timeline_begin_end_style()
        {
            var service = new TwitterService();
            var result = service.BeginListTweetsOnPublicTimeline();
            var tweets = service.EndListTweetsOnPublicTimeline(result, TimeSpan.FromSeconds(5));
            
            Assert.IsNotNull(tweets);
            Assert.AreEqual(20, tweets.Count());

            foreach (var tweet in tweets)
            {
                Console.WriteLine("{0} said '{1}'", tweet.User.ScreenName, tweet.Text);
            }
        }
        
        [Test]
        public void Can_deserialize_dates()
        {
            var service = new TwitterService();
            var tweets = service.ListTweetsOnPublicTimeline();

            Assert.IsNotNull(tweets);
            Assert.AreEqual(20, tweets.Count());

            foreach (var tweet in tweets)
            {
                Console.WriteLine("{0} said '{1}'", tweet.User.ScreenName, tweet.Id);
                Assert.AreNotEqual(default(DateTime), tweet.CreatedDate);
            }                       
        }

        [Test]
        public void Can_get_mentions_and_fail()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            var mentions = service.ListTweetsMentioningMe();

            Assert.AreEqual(HttpStatusCode.Unauthorized, service.Response.StatusCode);
            Assert.IsTrue(mentions.Count() == 1);

            var error = service.Deserialize<TwitterError>(mentions.First());
            Assert.IsNotNull(error);
            Assert.IsNotNullOrEmpty(error.Request);
            Assert.IsNotNullOrEmpty(error.ErrorMessage);
        }

        [Test]
        public void Can_get_mentions_and_fail_in_xml()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret) { Format = TwitterServiceFormat.Xml };
            var mentions = service.ListTweetsMentioningMe();

            Assert.AreEqual(HttpStatusCode.Unauthorized, service.Response.StatusCode);
            Assert.IsTrue(mentions.Count() == 1);

            var error = service.Deserialize<TwitterError>(mentions.First());
            Assert.IsNotNull(error);
            Assert.IsNotNullOrEmpty(error.Request);
            Assert.IsNotNullOrEmpty(error.ErrorMessage);
        }

        [Test]
        public void Can_get_mentions()
        {
            var service = GetAuthenticatedService();
            var mentions = service.ListTweetsMentioningMe();

            AssertResultWas(service, HttpStatusCode.OK);
            Assert.IsNotNull(mentions);
            Assert.IsTrue(mentions.Count() <= 20);
        }

        [Test]
        public void Can_get_user_profile()
        {
            var service = GetAuthenticatedService();
            var profile = service.GetUserProfile();

            Trace.WriteLine(service.Response.Response);

            AssertResultWas(service, HttpStatusCode.OK);
            Assert.IsNotNull(profile);
            Assert.IsNotNullOrEmpty(profile.ScreenName);
        }

        [Test]
        public void Can_get_user_profile_for()
        {
            var service = GetAuthenticatedService();
            var profile = service.GetUserProfileFor("tweetsharp");

            Trace.WriteLine(service.Response.Response);

            AssertResultWas(service, HttpStatusCode.OK);
            Assert.IsNotNull(profile);
            Assert.IsNotNullOrEmpty(profile.ScreenName);
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_tweet()
        {
            var service = GetAuthenticatedService();
            var tweet = service.SendTweet("@danielcrenna " + DateTime.UtcNow.Ticks + " @danielcrenna");

            AssertResultWas(service, HttpStatusCode.OK);
            Assert.IsNotNull(tweet);
            Assert.AreNotEqual(0, tweet.Id);
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_tweet_with_geo()
        {
            // status=123&lat=56.95&%40long=24.1&include_entities=1
            var service = GetAuthenticatedService();
            var tweet = service.SendTweet(DateTime.UtcNow.Ticks.ToString(), 56.95, 24.1);

            AssertResultWas(service, HttpStatusCode.OK);
            Assert.IsNotNull(tweet);
            Assert.AreNotEqual(0, tweet.Id);
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_direct_message()
        {
            var service = GetAuthenticatedService();

            var recipient = service.GetUserProfileFor("danielcrenna");
            var tweet = service.SendDirectMessage(recipient.Id, DateTime.UtcNow.Ticks.ToString());
            
            Assert.IsNotNull(tweet);
            Assert.AreNotEqual(0, tweet.Id);
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_direct_message_with_url_without_double_entities()
        {
            var service = GetAuthenticatedService();

            var recipient = service.GetUserProfileFor("danielcrenna");
            var tweet = service.SendDirectMessage(recipient.Id, string.Format("http://tweetsharp.com {0}", DateTime.UtcNow.Ticks));
            var urls = tweet.Entities.OfType<TwitterUrl>();

            Assert.IsNotNull(tweet);
            Assert.AreNotEqual(0, tweet.Id);
            
            foreach(var url in urls)
            {
                Console.WriteLine(url.Value);
            }
            
            Assert.AreEqual(1, urls.Count());
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_direct_message_with_screen_name()
        {
            var service = GetAuthenticatedService();

            var recipient = service.GetUserProfileFor("danielcrenna");
            var tweet = service.SendDirectMessage(recipient.ScreenName, DateTime.UtcNow.Ticks.ToString());

            Assert.IsNotNull(tweet);
            Assert.AreNotEqual(0, tweet.Id);
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_direct_message_with_a_url()
        {
            var service = GetAuthenticatedService();

            var recipient = service.GetUserProfileFor("danielcrenna");
            var tweet = service.SendDirectMessage(recipient.Id, "http://tweetsharp.com");

            Assert.IsNotNull(tweet);
            Assert.AreNotEqual(0, tweet.Id);
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_tweet_with_special_characters()
        {
            var service = GetAuthenticatedService();

            var message = "!@#$%^&*();:-" + DateTime.UtcNow.Ticks;
            var tweet = service.SendTweet(message);
            Assert.IsNotNull(tweet);
            Assert.AreNotEqual(0, tweet.Id);
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_tweet_with_location_custom_type()
        {
            var service = GetAuthenticatedService();

            var tweet = service.SendTweet(DateTime.UtcNow.Ticks.ToString(), 45.43989910068863, -75.69168090820312);

            var uri = service.Response.RequestUri;
            var queryString = System.Compat.Web.HttpUtility.ParseQueryString(uri.Query);
            var location = queryString["location"];
            Assert.AreNotEqual("TweetSharp.TwitterGeoLocation", location);

            Assert.IsNotNull(tweet);
            Assert.AreNotEqual(0, tweet.Id);
        }

        [Test]
        [Ignore("Makes a live status update")]
        public void Can_tweet_and_handle_dupes()
        {
            var service = GetAuthenticatedService();

            service.SendTweet("Can_tweet_and_handle_dupes:Tweet");
            var response = service.SendTweet("Can_tweet_and_handle_dupes:Tweet");
            
            if(service.Response != null && service.Response.StatusCode != HttpStatusCode.OK)
            {
                var error = service.Deserialize<TwitterError>(response); // <-- RawSource should have been assigned here
                Assert.IsNotNull(error);
                Assert.IsNotNullOrEmpty(error.ErrorMessage);
            }

            Assert.IsNotNull(response);
        }

        [Test]
        public void Can_use_xml_internally()
        {
            var service = new TwitterService { Format = TwitterServiceFormat.Xml };
            var tweets = service.ListTweetsOnPublicTimeline();

            Assert.IsNotNull(tweets);
            Assert.AreEqual(20, tweets.Count());

            foreach (var tweet in tweets)
            {
                Assert.IsNotNull(tweet.RawSource);
                Console.WriteLine("{0}[{1} says '{2}", tweet.User.ScreenName, tweet.Id, tweet.Text);
            }
        }

        [Test]
        public void Can_get_followers()
        {
            var service = GetAuthenticatedService();
            var followers = service.ListFollowersOf(_hero);
            Assert.IsNotNull(followers);
        }

        [Test]
        public void Can_get_friends()
        {
            var service = GetAuthenticatedService();
            TwitterCursorList<TwitterUser> followers = service.ListFriends(-1);
            Assert.IsNotNull(followers);
        }

        [Test]
        public void Can_get_followers_from_authenticated_user()
        {
            var service = GetAuthenticatedService();
            var followers = service.ListFollowers();
            Assert.IsNotNull(followers);
            Assert.IsTrue(followers.Count > 0);
        }
        
        [Test]
        public void Can_get_favorites_for()
        {
            var service = GetAuthenticatedService();
            var tweets = service.ListFavoriteTweetsFor("danielcrenna");

            Console.WriteLine(service.Response.Response);

            foreach (var tweet in tweets)
            {
                Console.WriteLine("{0} says '{1}", tweet.User.ScreenName, tweet.Text);
            }
        }

        [Test]
        public void Can_create_and_destroy_favorite()
        {
            // http://twitter.com/#!/kellabyte/status/16578173168779264
            var service = GetAuthenticatedService();
            var fave = service.FavoriteTweet(16578173168779264);
            if(service.Response != null && (int)service.Response.StatusCode == 403)
            {
                Trace.WriteLine("This tweet is already a favorite.");
            }
            else
            {
                AssertResultWas(service, HttpStatusCode.OK);
                Assert.IsNotNull(fave);
            }

            var unfave = service.UnfavoriteTweet(16578173168779264);
            AssertResultWas(service, HttpStatusCode.OK);
            Assert.IsNotNull(unfave);
        }

        [Test]
        public void Can_get_favorites()
        {
            var service = GetAuthenticatedService();
            var tweets = service.ListFavoriteTweets();

            Console.WriteLine(service.Response.Response);

            foreach (var tweet in tweets)
            {
                Console.WriteLine("{0} says '{1}", tweet.User.ScreenName, tweet.Text);
            }
        }

        [Test]
        public void Can_get_favorites_async()
        {
            var service = GetAuthenticatedService();
            var result = service.BeginListFavoriteTweetsFor("danielcrenna");
            var tweets = service.EndListFavoriteTweetsFor(result);

            Console.WriteLine(service.Response.Response);

            foreach (var tweet in tweets)
            {
                Console.WriteLine("{0} says '{1}", tweet.User.ScreenName, tweet.Text);
            }
        }
        
        [Test]
        public void Can_get_friends_or_followers_with_next_cursor()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            var followers = service.ListFollowersOf(_hero, -1);
            Assert.IsNotNull(followers);
            Assert.IsNotNull(followers.NextCursor);
            Assert.IsNotNull(followers.PreviousCursor);
        }

        [Test]
        public void Can_create_and_destroy_saved_search()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            // Twitter 403's on duplicate saved search requests, so delete if found
            var searches = service.ListSavedSearches();
            Assert.IsNotNull(searches);

            var existing = searches.Where(s => s.Query.Equals("tweetsharp")).SingleOrDefault();
            if(existing != null)
            {
                var deleted = service.DeleteSavedSearch(existing.Id);
                Assert.IsNotNull(deleted);
                Assert.IsNotNullOrEmpty(deleted.Query);
                Assert.AreEqual(deleted.Query, existing.Query);
            }
            
            var search = service.CreateSavedSearch("tweetsharp");
            Assert.IsNotNull(search);
            Assert.AreEqual("tweetsharp", search.Query);
        }

        [Test]
        public void Can_search()
        {
            var service = new TwitterService();
            var results = service.Search("#tweetsharp", 10 /* rpp */);
            
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Statuses.Count() <= 10);

            foreach(var tweet in results.Statuses)
            {
                Console.WriteLine("{0} says '{1}", tweet.FromUserScreenName, tweet.Text);   
            }
        }

        [Test]
        public void Can_get_raw_source_from_search()
        {
            var service = new TwitterService();
            var results = service.Search("tweetsharp", 10 /* rpp */);

            Assert.IsNotNull(results);
            Assert.IsTrue(results.Statuses.Count() <= 10);

            if(results.Statuses.Count() == 0)
            {
                Assert.Ignore("No search results provided for this test");
            }

            foreach (var tweet in results.Statuses)
            {
                Assert.IsNotNullOrEmpty(tweet.RawSource);
                Console.WriteLine("{0} says '{1}", tweet.FromUserScreenName, tweet.Text);
            }
        }

        [Test]
        public void Can_get_friendship_info()
        {
            var service = new TwitterService();
            var friendship =  service.GetFriendshipInfo("tweetsharp", "danielcrenna");

            Assert.IsNotNull(friendship);
            Assert.IsNotNull(friendship.Relationship);
        }

        [Test]
        public void Can_get_user_suggestion_categories_and_users()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            var service = new TwitterService();
            var categories = service.ListSuggestedUserCategories();
            Assert.IsNotNull(categories);
            Assert.IsTrue(categories.Count() > 0);

            foreach(var category in categories)
            {
                Trace.WriteLine(category.RawSource);
                Trace.WriteLine(string.Format("{0}({1})", category.Name, category.Slug));
            }
            
            var suggestions = service.ListSuggestedUsers(categories.First().Slug);
            Assert.IsNotNull(suggestions);
            Assert.IsNotNull(suggestions.Users);
            Assert.IsTrue(suggestions.Users.Count() > 0);

            foreach(var user in suggestions.Users)
            {
                Trace.WriteLine(user.ScreenName);
            }
        }

        [Test]
        public void Can_get_tweet()
        {
            var service = new TwitterService();
            var tweet = service.GetTweet(10080880705929216);

            Assert.IsNotNull(tweet);
            Assert.IsNotNull(service.Response);
            Assert.AreEqual(HttpStatusCode.OK, service.Response.StatusCode);
        }

        [Test]
        public void Can_get_tweet_async()
        {
            var service = new TwitterService();
            var result = service.BeginGetTweet(10080880705929216);
            var tweet = service.EndGetTweet(result);

            Assert.IsNotNull(tweet);
            Assert.IsNotNull(service.Response);
            Assert.AreEqual(HttpStatusCode.OK, service.Response.StatusCode);
        }

        [Test]
        public void Can_get_profile_image()
        {
            var service = new TwitterService();
            var image = service.GetProfileImageFor(_hero);

            Assert.IsNotNull(image);
        }

        [Test]
        [Ignore("This test is only relevant until Twitter decides to turn on entities by default")]
        public void Can_avoid_entities_on_timeline()
        {
            var service = new TwitterService { IncludeEntities = false };
            var tweets = service.ListTweetsOnPublicTimeline();
            foreach(var tweet in tweets)
            {
                Assert.IsNull(tweet.Entities);
            }
        }

        [Test]
        [Ignore("Makes a live direct message")]
        public void Can_send_direct_message()
        {
            var service = new TwitterService { IncludeEntities = true };
            service.AuthenticateWith(_consumerKey, _consumerSecret, _accessToken, _accessTokenSecret);
            var response = service.SendDirectMessage(_hero, "http://tweetsharp.com @dimebrain #thisisatest " + DateTime.Now.Ticks);
            
            AssertResultWas(service, HttpStatusCode.OK);
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Id == 0);
        }

        [Test]
        public void Can_delete_direct_message()
        {
            var service = new TwitterService { IncludeEntities = true };
            service.AuthenticateWith(_consumerKey, _consumerSecret, _accessToken, _accessTokenSecret);
            var created = service.SendDirectMessage(_hero, "http://tweetsharp.com @dimebrain #thisisatest " + DateTime.Now.Ticks);
            AssertResultWas(service, HttpStatusCode.OK);
            Assert.IsNotNull(created);
            Assert.IsFalse(created.Id == 0);

            var deleted = service.DeleteDirectMessage(created.Id);
            Assert.IsNotNull(deleted);
            Assert.AreEqual(deleted.Id, created.Id);
        }

        [Test]
        public void Can_get_entities_on_direct_messages()
        {
            var service = new TwitterService { IncludeEntities = true };            
            service.AuthenticateWith(_consumerKey, _consumerSecret, _accessToken, _accessTokenSecret);
            
            var tweets = service.ListDirectMessagesSent();
            if(tweets.Count() < 1)
            {
                Assert.Ignore("No direct messages available to verify entities");
            }

            Console.WriteLine(service.Response.Response);

            foreach (var tweet in tweets)
            {
                Assert.IsNotNull(tweet.Entities);
                var coalesced = tweet.Entities.Coalesce();
                var text = tweet.Text;

                Assert.IsNotNull(tweet.TextAsHtml);
                Console.WriteLine("Tweet: " + text);
                Console.WriteLine("HTML: " + tweet.TextAsHtml);
                foreach(var entity in coalesced)
                {
                    switch(entity.Type)
                    {
                        case TwitterEntityType.HashTag:
                            var hashtag = ((TwitterHashTag) entity).Text;
                            Console.WriteLine(hashtag);
                            var hashtagText = text.Substring(entity.StartIndex, entity.EndIndex - entity.StartIndex);
                            Assert.AreEqual("#" + hashtag, hashtagText);
                            break;
                        case TwitterEntityType.Mention:
                            var mention = ((TwitterMention) entity).ScreenName;
                            Console.WriteLine(mention);
                            var mentionText = text.Substring(entity.StartIndex, entity.EndIndex - entity.StartIndex);
                            Assert.AreEqual("@" + mention, mentionText);
                            break;
                        case TwitterEntityType.Url:
                            var url = ((TwitterUrl) entity).Value;
                            Console.WriteLine(url);
                            var urlText = text.Substring(entity.StartIndex, entity.EndIndex - entity.StartIndex);
                            Assert.AreEqual(url, urlText);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                Console.WriteLine();
            }
        }
        
        [Test]
        public void Can_get_entities_on_timeline()
        {
            var service = new TwitterService();
            var tweets = service.ListTweetsOnPublicTimeline();
            
            foreach (var tweet in tweets)
            {
                Assert.IsNotNull(tweet.Entities);
                if (tweet.Entities.HashTags.Count() > 0)
                {
                    foreach (var hashtag in tweet.Entities.HashTags)
                    {
                        Assert.IsNotNullOrEmpty(hashtag.Text);
                    }
                }
                if (tweet.Entities.Urls.Count() > 0)
                {
                    foreach (var url in tweet.Entities.Urls)
                    {
                        Assert.IsNotNullOrEmpty(url.Value);
                    }
                }
                if (tweet.Entities.Mentions.Count() > 0)
                {
                    foreach (var mention in tweet.Entities.Mentions)
                    {
                        Assert.IsNotNullOrEmpty(mention.ScreenName);
                    }
                }
            }
        }

        [Test]
        public void Can_coalesce_entities_on_timeline()
        {
            var service = new TwitterService();
            var tweets = service.ListTweetsOnPublicTimeline();

            var passed = false;
            
            foreach(var tweet in tweets)
            {
                if(tweet.Entities == null)
                {
                    continue;
                }

                var entities = tweet.Entities.Coalesce();
                if(entities.Count() < 2)
                {
                    continue;
                }

                var previous = -1;
                foreach(var entity in entities)
                {
                    Assert.IsTrue(previous < entity.StartIndex);
                    previous = entity.StartIndex;
                }

                passed = true;
            }

            if(!passed)
            {
                Assert.Ignore("This test pass yielded no entities with both a hashtag and a URL.");
            }
        }

        [Test]
        public void Can_get_tweets_on_user_timeline_with_paging()
        {
            var service = GetAuthenticatedService();
            
            for(var i = 0; i < 10; i++)
            {
                var tweets = service.ListTweetsOnUserTimeline(i, 200);
                foreach (var tweet in tweets)
                {
                    Assert.IsNotNull(tweet.RawSource);
                    Assert.IsNotNull(tweet.Entities);

                    Console.WriteLine("{0} said '{1}'", tweet.User.ScreenName, tweet.Text);
                }
            }
        }

        [Test]
        public void Can_get_tweets_on_specified_user_timeline()
        {
            var service = GetAuthenticatedService();

            var tweets = service.ListTweetsOnSpecifiedUserTimeline("mabster");
            foreach(var tweet in tweets)
            {
                Assert.IsNotNull(tweet.RawSource);
                Assert.IsNotNull(tweet.Entities);

                Console.WriteLine("{0} said '{1}'", tweet.User.ScreenName, tweet.Text);
            }
        }

        [Test]
        public void Can_get_user_lists()
        {
            var service = GetAuthenticatedService();
            var lists = service.ListListsFor("danielcrenna");

            Assert.IsNotNull(lists);
            if(lists.Count == 0)
            {
                Assert.Ignore("This test account has no lists");
            }

            foreach(var list in lists)
            {
                Assert.IsNotNullOrEmpty(list.Name);
                Trace.WriteLine(list.Name);
            }
        }

        [Test]
        public void Can_create_and_delete_list()
        {
            var service = GetAuthenticatedService();
            var list = service.CreateList("danielcrenna", "test-list", "private");

            Assert.IsNotNull(list);
            Assert.IsNotNullOrEmpty(list.Name);
            Assert.AreEqual(list.Name, "test-list");

            list = service.DeleteList("danielcrenna", list.Slug);
            Assert.IsNotNull(list);
            Assert.IsNotNullOrEmpty(list.Name);
            Assert.AreEqual(list.Name, "test-list");
        }

        [Test]
        public void Can_get_followers_ids()
        {
            var service = GetAuthenticatedService();
            var followers = service.ListFollowerIdsOf("tweetsharp", -1);
            Assert.IsNotNull(followers);
            Assert.IsTrue(followers.Count > 0);
        }

        [Test]
        public void Can_get_friend_ids()
        {
            var service = GetAuthenticatedService();
            var friends = service.ListFriendIdsOf("tweetsharp", -1);
            Assert.IsNotNull(friends);
            Assert.IsTrue(friends.Count > 0);
        }

        [Test]
        public void Can_get_current_trends()
        {
            var service = GetAuthenticatedService();
            var trends = service.ListCurrentTrends();
            Assert.IsNotNull(trends);
            Assert.IsTrue(trends.Count() ==10);
        }

        [Test]
        public void Can_get_daily_trends()
        {
            var service = GetAuthenticatedService();
            var trends = service.ListDailyTrends();
            Assert.IsNotNull(trends);
            Assert.IsTrue(trends.Count() == 20 * 24);
        }

        [Test]
        public void Can_get_weekly_trends_with_date()
        {
            var yesterday = DateTime.UtcNow.Subtract(TimeSpan.FromDays(1));

            var service = GetAuthenticatedService();
            var trends = service.ListWeeklyTrends(yesterday);
            Assert.IsNotNull(trends);
            Assert.IsTrue(trends.Count() == 30 * 7);
        }

        [Test]
        public void Can_get_available_local_trend_locations()
        {
            var service = GetAuthenticatedService();
            var locations = service.ListAvailableTrendsLocations();
            Assert.IsNotNull(locations);

            foreach(var location in locations)
            {
                Trace.WriteLine(string.Format("{0}:{1}, {2}[{3}]", location.WoeId, location.Name, location.Country, location.PlaceType.Name));
            }
        }

        [Test]
        public void Can_get_local_trends()
        {
            var service = GetAuthenticatedService();
            var trends = service.ListLocalTrendsFor(4118);
            Assert.IsNotNull(trends);

            foreach (var trend in trends)
            {
                Trace.WriteLine(trend.Query);
            }
        }

        [Test]
        public void Can_get_multiple_user_profiles()
        {
            var service = GetAuthenticatedService();
            var users = service.ListUserProfilesFor(new[] {"danielcrenna", "jdiller"});

            Assert.IsNotNull(users);
            Assert.AreEqual(2, users.Count());
        }

        private static void AssertResultWas(TwitterService service, HttpStatusCode statusCode)
        {
            Assert.IsNotNull(service.Response);
            Assert.AreEqual(statusCode, service.Response.StatusCode);
        }

        private static void AssertRateLimitStatus(TwitterService service)
        {
            var rate = service.Response.RateLimitStatus;
            Assert.IsNotNull(rate);
            Assert.AreNotEqual(0, rate.HourlyLimit);
            Console.WriteLine();
            Console.WriteLine("{0} / {1} API calls remaining", rate.RemainingHits, rate.HourlyLimit);
        }

        private TwitterService GetAuthenticatedService()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);
            return service;
        }

        [Test]
        public void Can_stream_from_user_stream()
        {
            var block = new AutoResetEvent(false);

            var service = GetAuthenticatedService();

            service.StreamUser((streamEvent, response) =>
                                   {
                                       if (streamEvent is TwitterUserStreamEnd)
                                       {
                                           block.Set();
                                       }

                                       if (response.StatusCode == 0)
                                       {
                                           if(streamEvent is TwitterUserStreamFriends)
                                           {
                                               var friends = (TwitterUserStreamFriends) streamEvent;
                                               Assert.IsNotNull(friends);
                                               Assert.IsNotNull(friends.RawSource);
                                               Assert.IsTrue(friends.Ids.Count() > 0);
                                           }

                                           if(streamEvent is TwitterUserStreamEvent)
                                           {
                                               var @event = (TwitterUserStreamEvent) streamEvent;
                                               Assert.IsNotNull(@event);
                                               Assert.IsNotNull(@event.TargetObject);
                                               Assert.IsNotNull(@event.RawSource);
                                           }

                                           if (streamEvent is TwitterUserStreamStatus)
                                           {
                                               var tweet = ((TwitterUserStreamStatus)streamEvent).Status;
                                               Assert.IsNotNull(tweet);
                                               Assert.IsNotNull(tweet.Id);
                                               Assert.IsNotNull(tweet.User);
                                               Assert.IsNotNull(tweet.RawSource);
                                               Assert.IsNotNull(tweet.User.ScreenName);
                                           }

                                           if (streamEvent is TwitterUserStreamDirectMessage)
                                           {
                                               var dm = ((TwitterUserStreamDirectMessage) streamEvent).DirectMessage;
                                               Assert.IsNotNull(dm);
                                               Assert.IsNotNull(dm.Id);
                                               Assert.IsNotNull(dm.Sender);
                                               Assert.IsNotNull(dm.Recipient);
                                               Assert.IsNotNull(dm.RawSource);
                                           }

                                           if(streamEvent is TwitterUserStreamDeleteStatus)
                                           {
                                               var deleted = (TwitterUserStreamDeleteStatus) streamEvent;
                                               Assert.IsNotNull(deleted);
                                               Assert.IsTrue(deleted.StatusId > 0);
                                               Assert.IsTrue(deleted.UserId > 0);
                                           }

                                           if(streamEvent is TwitterUserStreamDeleteDirectMessage)
                                           {
                                               var deleted = (TwitterUserStreamDeleteDirectMessage)streamEvent;
                                               Assert.IsNotNull(deleted);
                                               Assert.IsTrue(deleted.DirectMessageId > 0);
                                               Assert.IsTrue(deleted.UserId > 0);
                                           }
                                       }
                                       else
                                       {
                                           Assert.Ignore(string.Format("Stream responsed with status code: {0}", response.StatusCode));
                                       }
                                   }
                );

            block.WaitOne();
            service.CancelStreaming();
        }
    }
}
