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
            Assert.AreEqual(false, account.ShowAllInlineMedia);
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
