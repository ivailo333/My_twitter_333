using System.ComponentModel.DataAnnotations;

namespace My_twitter_333.Models
{
    public class TwitterAccount
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30,MinimumLength = 8,ErrorMessage = "Length must be between 8 and 30 characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10,ErrorMessage = "Length must be between 10 and 20 characters.")]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(10,MinimumLength = 10, ErrorMessage = "The phone number must be exactly 10 characters long.")]
        public string Phone { get; set; }
    }
}
