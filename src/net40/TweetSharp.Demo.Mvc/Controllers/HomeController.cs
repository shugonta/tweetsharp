using System;
using System.Configuration;
using System.Web.Mvc;

namespace TweetSharp.Demo.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private string _consumerKey;
        private string _consumerSecret;

        public HomeController()
        {
            _consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
            _consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
        }

        public ActionResult Index()
        {
            ViewModel.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult Authorize()
        {
            TwitterService service = new TwitterService(_consumerKey, _consumerSecret);
            OAuthRequestToken requestToken = service.GetRequestToken();

            var uri = service.GetAuthorizationUri(requestToken);
            return new RedirectResult(uri.ToString(), false /*permanent*/);
        }

        public ActionResult AuthorizeCallback(string oauth_token, string oauth_verifier)
        {
            TwitterService service = new TwitterService(_consumerKey, _consumerSecret);
            var requestToken = new OAuthRequestToken {Token = oauth_token};

            OAuthAccessToken accessToken = service.GetAccessToken(requestToken, oauth_verifier);

            service.AuthenticateWith(accessToken.Token, accessToken.TokenSecret);
            TwitterUser user = service.VerifyCredentials();
            ViewModel.Message = string.Format("Your username is {0}", user.ScreenName);

            return View("Index");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
