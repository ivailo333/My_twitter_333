using System.ComponentModel.DataAnnotations;

namespace My_twitter_333.Models
{
    public class TwitterConfiguration
    {
        public int Id { get; set; }

        [Required]
        public string ApiKey { get; set; }

        [Required]
        public string ApiSecretKey { get; set; }

        [Required]
        public string AccessToken { get; set; }

        [Required]
        public string AccessTokenSecret { get; set; }

    }
}
