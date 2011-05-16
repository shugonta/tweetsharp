using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TweetSharp.Demo.WindowsPhone.ViewModels
{
    public class Tweet
    {
        private TwitterStatus _status;

        public Tweet(TwitterStatus status)
        {
            _status = status;
        }

        public string Text
        {
            get
            {
                return _status.Text;
            }
        }

        public string ScreenName
        {
            get
            {
                return _status.User.ScreenName;
            }
        }

        public string ProfileImageUrl
        {
            get
            {
                return _status.User.ProfileImageUrl;
            }
        }
    }
}
