using Microsoft.EntityFrameworkCore;
using My_twitter_333.Models;

namespace My_twitter_333
{
    public class TwitterDbContext : DbContext
    {
        public TwitterDbContext(DbContextOptions<TwitterDbContext> options) : base(options)
        {

        }
        public DbSet<Tweet> Tweets { get; set; } = null!;
        public DbSet<TwitterAccount> TwitterAccounts { get; set; } = null!;
        public DbSet<TwitterConfiguration> TwitterConfigurations { get; set; } = null!;

    }
}
