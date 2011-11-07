using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace TweetSharp.Tests.Service
{
    [TestFixture]
    public partial class TwitterServiceTests
    {

        [Test]
        public void Can_get_basic_place()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            // Presidio
            var place = service.GetPlace("df51dec6f4ee2b2c");
            Assert.IsNotNull(place);
            Assert.AreEqual("df51dec6f4ee2b2c", place.Id);
            Assert.AreEqual("Presidio", place.Name);
            Assert.AreEqual("United States", place.Country);
            Assert.AreEqual("US", place.CountryCode);
            Assert.AreEqual("Presidio, San Francisco", place.FullName);
        }

        [Test]
        public void Can_get_reverse_geocode()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            var places = service.ReverseGeocode(45.42153, -75.697193).ToList();
            Assert.IsNotEmpty(places);
            Assert.AreEqual(4, places.Count);

            places = places.OrderBy(p => p.Id).ToList();
            
            Assert.AreEqual("Ottawa, Ontario", places[0].FullName);
            Assert.AreEqual(TwitterPlaceType.City, places[0].PlaceType);
            Assert.AreEqual("06183ca2a30a18e8", places[0].Id);
            Assert.AreEqual(1, places[0].ContainedWithin.Count());
            Assert.AreEqual("89b2eb8b2b9847f7", places[0].ContainedWithin.ToList()[0].Id);
            
            Assert.AreEqual("Canada", places[1].FullName);
            Assert.AreEqual("3376992a082d67c7", places[1].Id);
            Assert.AreEqual(TwitterPlaceType.Country, places[1].PlaceType);

            Assert.AreEqual("Ontario, Canada", places[2].FullName);
            Assert.AreEqual(TwitterPlaceType.Admin, places[2].PlaceType);

            Assert.AreEqual("Québec, Canada", places[3].FullName);
            Assert.AreEqual(TwitterPlaceType.Admin, places[3].PlaceType);
        }

        [Test]
        public void Can_search_geo_by_lat_long()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            var places = service.GeoSearchByCoordinates(45.42153, -75.697193).ToList();
            Assert.IsNotEmpty(places);

            places = places.OrderBy(p => p.Id).ToList();
            Assert.AreEqual("06183ca2a30a18e8", places[0].Id);
        }

        [Test]
        public void Can_search_geo_by_ip()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            var places = service.GeoSearchByIp("24.246.1.165").ToList();
            Assert.IsNotEmpty(places);

            places = places.OrderBy(p => p.Id).ToList();
            Assert.AreEqual("06183ca2a30a18e8", places[0].Id);
        }

        [Test]
        [Ignore("This is a brittle test because it requires that you be me (and you are probably not me)")]
        public void Can_get_geo_coordinates_from_specific_tweet()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            /*
             "geo": {
                    "type": "Point",
                    "coordinates": [
                        46.01364037,
                        -81.40501187
                    ]
                }, 
             */

            var last = service.GetTweet(133314374797492224);
            Assert.IsNotNull(last.Place);
            Assert.IsNotNull(last.Location);
            Assert.AreEqual("Point", last.Location.Type);
            Assert.AreEqual(46.01364037, last.Location.Coordinates.Latitude);
            Assert.AreEqual(-81.40501187, last.Location.Coordinates.Longitude);
        }

        [Test]
        [Ignore("This is a brittle test because it requires that you be me (and you are probably not me)")]
        public void Can_get_parameterized_followers_of_lists()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            var result = service.ListUserProfilesFor(new [] { "danielcrenna"}, new[] {12345});
            Assert.AreEqual(2, result.Count());
        }

        [Test]
        [Ignore("This is a brittle test because it requires that you be me (and you are probably not me)")]
        public void Can_get_updated_user_properties()
        {
            //{"is_translator":false,
            //"geo_enabled":false,
            //"profile_background_color":"1A1B1F",
            //"protected":false,
            //"profile_background_tile":false,
            //"created_at":"Fri Dec 14 18:48:52 +0000 2007",
            //"name":"Daniel Crenna",
            //"profile_background_image_url_https":"https:\/\/si0.twimg.com\/images\/themes\/theme9\/bg.gif",
            //"profile_sidebar_fill_color":"252429",
            //"listed_count":102,
            //"notifications":false,
            //"utc_offset":-18000,
            //"friends_count":277,
            //"description":"Code soloist.",
            //"following":false,
            //"verified":false,
            //"profile_sidebar_border_color":"181A1E",
            //"followers_count":1193,
            //"profile_image_url":"http:\/\/a1.twimg.com\/profile_images\/700778992\/684676c4ec78fa88144b5256dd880986_normal.png",
            //"default_profile":false,
            //"contributors_enabled":false,
            //"profile_image_url_https":"https:\/\/si0.twimg.com\/profile_images\/700778992\/684676c4ec78fa88144b5256dd880986_normal.png",
            //"status":{"possibly_sensitive":false,"place":null,"retweet_count":0,"in_reply_to_screen_name":null,"created_at":"Sun Nov 06 14:23:43 +0000 2011","retweeted":false,"in_reply_to_status_id_str":null,"in_reply_to_user_id_str":null,"contributors":null,"id_str":"133187813599481856","in_reply_to_user_id":null,"in_reply_to_status_id":null,"source":"\u003Ca href=\"http:\/\/twitter.com\/tweetbutton\" rel=\"nofollow\"\u003ETweet Button\u003C\/a\u003E","geo":null,"favorited":false,"id":133187813599481856,"entities":{"urls":[{"display_url":"binpress.com\/blog\/2011\/08\/2\u2026","indices":[53,73],"url":"http:\/\/t.co\/KTGrKmeK","expanded_url":"http:\/\/www.binpress.com\/blog\/2011\/08\/25\/why-isnt-it-free-commercial-open-source\/"}],"user_mentions":[{"name":"Binpress","indices":[78,87],"screen_name":"Binpress","id_str":"204787796","id":204787796}],"hashtags":[]},"coordinates":null,"truncated":false,"text":"Why isn't it free - commercial open-source revisited http:\/\/t.co\/KTGrKmeK via @binpress"},"profile_use_background_image":true,"favourites_count":151,"location":"Ottawa, ON, Canada","id_str":"11173402","default_profile_image":false,"show_all_inline_media":true,"profile_text_color":"666666","screen_name":"danielcrenna","statuses_count":4669,"profile_background_image_url":"http:\/\/a1.twimg.com\/images\/themes\/theme9\/bg.gif","url":"http:\/\/danielcrenna.com","time_zone":"Eastern Time (US & Canada)","profile_link_color":"2FC2EF","id":11173402,
            //"follow_request_sent":false,
            //"lang":"en"}
            
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            var user = service.GetUserProfile();
            Assert.AreEqual(true, user.ShowAllInlineMedia);
            Assert.AreEqual(false, user.FollowRequestSent);
            Assert.AreEqual(false, user.IsTranslator);
            Assert.AreEqual(false, user.ContributorsEnabled);
            Assert.IsTrue(user.ProfileBackgroundImageUrlHttps.StartsWith("https://"));
            Assert.IsTrue(user.ProfileImageUrlHttps.StartsWith("https://"));
            Assert.AreEqual(false, user.IsDefaultProfile);
        }

        [Test]
        [Ignore("This is a brittle test because it requires that you be me (and you are probably not me)")]
        public void Can_return_results_from_account_settings_endpoint()
        {
            //{"protected":false,
            //"geo_enabled":false,
            //"trend_location":[{"countryCode":"CA","name":"Canada","country":"Canada","placeType":{"name":"Country","code":12},"woeid":23424775,"url":"http:\/\/where.yahooapis.com\/v1\/place\/23424775","parentid":1}],
            //"language":"en",
            //"sleep_time":{"start_time":0,"end_time":12,"enabled":true},
            //"always_use_https":false,
            //"screen_name":"danielcrenna",
            //"show_all_inline_media":false,
            //"time_zone":{"name":"Eastern Time (US & Canada)","utc_offset":-18000,"tzinfo_name":"America\/New_York"},
            //"discoverable_by_email":true}

            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            var account = service.GetAccountSettings();
            Console.WriteLine(account.RawSource);

            Assert.AreEqual(false, account.IsProtected);
            Assert.AreEqual(false, account.GeoEnabled);
            Assert.IsNotNull(account.TrendLocations);
            Assert.AreEqual(1, account.TrendLocations.Count());
            Assert.AreEqual("CA", account.TrendLocations.Single().CountryCode);
            Assert.AreEqual("Canada", account.TrendLocations.Single().Name);
            Assert.AreEqual("Canada", account.TrendLocations.Single().Country);
            Assert.AreEqual("en", account.Language);
            Assert.AreEqual("danielcrenna", account.ScreenName);
            Assert.AreEqual(true, account.ShowAllInlineMedia);
            Assert.IsNotNull(account.TimeZone);
            Assert.AreEqual("Eastern Time (US & Canada)", account.TimeZone.Name);
            Assert.AreEqual(-18000, account.TimeZone.UtcOffset);
            Assert.AreEqual("America/New_York", account.TimeZone.InfoName);
            Assert.IsNotNull(account.SleepTime);
            Assert.AreEqual(0, account.SleepTime.StartTime, "start_time");
            Assert.AreEqual(12, account.SleepTime.EndTime, "end_time");
            Assert.AreEqual(true, account.SleepTime.Enabled);
        }

        [Test]
        public void Can_update_account_settings()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken, _accessTokenSecret);

            var original = service.GetAccountSettings();
            var state = !original.SleepTime.Enabled.Value;

            Trace.WriteLine("Sleep state was " + original.SleepTime.Enabled);
            
            var updated = service.UpdateAccountSettings(state);
            Assert.AreEqual(state, updated.SleepTime.Enabled);

            Trace.WriteLine("Sleep state is now " + updated.SleepTime.Enabled);

            updated = service.UpdateAccountSettings(!state);
            Assert.AreEqual(!state, updated.SleepTime.Enabled);

            Trace.WriteLine("Sleep state is now " + updated.SleepTime.Enabled);
        }
    }
}
