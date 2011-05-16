using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Threading;
using Microsoft.Phone.Controls;
using Microsoft.Practices.Mobile.Configuration;
using TweetSharp.Demo.WindowsPhone.Configuration;
using TweetSharp.Demo.WindowsPhone.ViewModels;

namespace TweetSharp.Demo.WindowsPhone
{
    public partial class MainPage
    {
        private readonly string _consumerKey;
        private readonly string _consumerSecret;
        
        private TwitterService _service;
        private OAuthRequestToken _requestToken;
        private OAuthAccessToken _accessToken;
        
        private bool _browserLoaded;

        public MainPage()
        {
            InitializeComponent();

            // Uses Alex Yakhnin's configuration implementation:
            // http://blogs.msdn.com/b/priozersk/archive/2010/07/06/app-config-for-wp7-applications.aspx

            var section = (ApplicationSettingsSection)ConfigurationManager.GetSection("ApplicationSettings");
            _consumerKey = section.AppSettings["ConsumerKey"].Value;
            _consumerSecret = section.AppSettings["ConsumerSecret"].Value;

            _browser.Navigated += BrowserNavigated;
            _browser.ScriptNotify += BrowserScriptNotify;
            _browser.Loaded += BrowserLoaded;

            Loaded += MainPageLoaded;
        }

        private void BrowserNavigated(object sender, NavigationEventArgs e)
        {
            _browser.Visibility = Visibility.Visible;
            _tweets.Visibility = Visibility.Collapsed;
            _browser.Navigated -= BrowserNavigated;
        }

        private void BrowserScriptNotify(object sender, NotifyEventArgs e)
        {
            var values = ParseQueryString(e.Value);
            if(values.ContainsKey("oauth_verifier"))
            {
                var verifier = values["oauth_verifier"];
                _service.GetAccessToken(_requestToken, verifier, HandleAuthenticationAccessToken);
            }
            else
            {
                Dispatcher.BeginInvoke(
                    () => MessageBox.Show("Did not authenticate correctly")
                    );
            }
        }

        private void BrowserLoaded(object sender, RoutedEventArgs e)
        {
            _browserLoaded = true;
        }

        private void MainPageLoaded(object sender, RoutedEventArgs e)
        {
            _service = new TwitterService(_consumerKey, _consumerSecret);
            _service.GetRequestToken(HandleAuthenticationRequestToken);
        }
        
        protected virtual void HandleAuthenticationRequestToken(OAuthRequestToken token, TwitterResponse response)
        {
            _requestToken = token; // Save the token
            
            while(!_browserLoaded)
            {
                Thread.Sleep(200);
            }

            Dispatcher.BeginInvoke(
                () => _browser.Navigate(_service.GetAuthorizationUri(_requestToken))
                );
        }

        private void HandleAuthenticationAccessToken(OAuthAccessToken token, TwitterResponse response)
        {
            _accessToken = token;

            Dispatcher.BeginInvoke(
                ()=>
                    {
                        _browser.Visibility = Visibility.Visible;
                        _tweets.Visibility = Visibility.Collapsed;            
                    }
            );

            ServiceExample();
        }

        private void FluentExample(Dispatcher dispatcher)
        {
            FluentTwitter.CreateRequest()
                .Statuses().OnPublicTimeline().AsJson()
                .BeginRequest((statuses, response) =>
                                  {
                                      if (response.StatusCode == HttpStatusCode.OK)
                                      {
                                          ProcessIncomingTweets(response, statuses, dispatcher);
                                      }
                                  });

            FluentTwitter.CreateRequest()
                .Statuses().Update(DateTime.Now.Ticks.ToString())
                .BeginRequest((status, response) =>
                                  {
                                      if (response.StatusCode != HttpStatusCode.OK)
                                      {
                                          return;
                                      }
                                      var tweet = new Tweet(status);
                                      dispatcher.BeginInvoke(() => _tweets.Items.Add(tweet));
                                  });
        }

        private void ServiceExample()
        {
            var service = new TwitterService(_consumerKey, _consumerSecret);
            service.AuthenticateWith(_accessToken.Token, _accessToken.TokenSecret);
            
            //service.ListTweetsOnPublicTimeline(
            //    (statuses, response) => ProcessIncomingTweets(response, statuses, Dispatcher)
            //    );

            service.ListFollowers(-1,
                (list, response) =>
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            foreach(var follower in list)
                            {
                                Console.WriteLine(follower.ScreenName);
                            }
                        }
                    }
                );

            //service.SendTweet(DateTime.Now.Ticks.ToString(),
            //                  (status, response) =>
            //                      {
            //                          if (response.StatusCode == HttpStatusCode.OK)
            //                          {
            //                              var tweet = new Tweet(status);
            //                              dispatcher.BeginInvoke(() => tweets.Items.Add(tweet));
            //                          }
            //                      });
        }

        private void ProcessIncomingTweets(TwitterResponse response, IEnumerable<TwitterStatus> statuses, Dispatcher dispatcher)
        {
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(response.StatusCode.ToString());
            }

            foreach (var status in statuses)
            {
                var inline = status;
                var tweet = new Tweet(inline);

                dispatcher.BeginInvoke(() => _tweets.Items.Add(tweet));
            }
        }

        // From Hammock.Extensions.StringExtensions.cs
        public static IDictionary<string, string> ParseQueryString(string query)
        {
            // [DC]: This method does not URL decode, and cannot handle decoded input
            if (query.StartsWith("?")) query = query.Substring(1);

            if (query.Equals(string.Empty))
            {
                return new Dictionary<string, string>();
            }

            var parts = query.Split(new[] { '&' });

            return parts.Select(
                part => part.Split(new[] { '=' })).ToDictionary(
                    pair => pair[0], pair => pair[1]
                );
        }
    }
}