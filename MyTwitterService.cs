using Microsoft.Extensions.Options;

namespace My_twitter_333
{
    public class MyTwitterService
    {
        private readonly TwitterApiSettings _twitterApiSettings;

        public MyTwitterService(IOptions<TwitterApiSettings> twitterApiSettings)
        {
            _twitterApiSettings = twitterApiSettings.Value;
        }

        public void DoSomethingWithTwitterApi()
        {
            var consumerKey = _twitterApiSettings.ConsumerKey;
            var consumerSecret = _twitterApiSettings.ConsumerSecret;
            var accessToken = _twitterApiSettings.AccessToken;
            var accessTokenSecret = _twitterApiSettings.AccessTokenSecret;
        }
    }
}
