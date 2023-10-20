using System;
using System.ComponentModel.DataAnnotations;

namespace My_twitter_333.Models
{
    public class Tweet
    {
        public int TweetId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10,ErrorMessage = "Length must be between 10 and 20 characters.")]
        public string Author { get; set; }

        [Required]
        [StringLength(35,MinimumLength = 10, ErrorMessage = "Length must be between 10 and 35 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 20,ErrorMessage = "Length must be between 20 and 100 characters.")]
        public string Body { get; set; }

        [Required]
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
