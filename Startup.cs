using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tweetinvi;
using Tweetinvi.Models;

namespace My_twitter_333
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            var twitterApiSettings=Configuration.GetSection("TwitterApiSettings").Get<TwitterApiSettings>();
            var credentials = new TwitterCredentials
            {
                ConsumerKey = twitterApiSettings.ConsumerKey,
                ConsumerSecret = twitterApiSettings.ConsumerSecret,
                AccessToken = twitterApiSettings.AccessToken,
                AccessTokenSecret = twitterApiSettings.AccessTokenSecret
            };

            services.AddControllersWithViews();
            services.Configure<TwitterApiSettings>(Configuration.GetSection("TwitterApiSettings"));
            services.AddHttpClient();
            services.AddDbContext<TwitterDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "TwitterAccount",
                    pattern: "TwitterAccount/{action=Index}/{id?}",
                    defaults: new { controller = "TwitterAccount", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "TwitterAccount",
                    pattern: "TwitterAccount/{action=Details}/{id?}",
                    defaults: new { controller = "TwitterAccount", action = "Details" });

                endpoints.MapControllerRoute(
                    name: "TwitterAccount",
                    pattern: "TwitterAccount/{action=Create}/{id?}",
                    defaults: new { controller = "TwitterAccount", action = "Create" });

                endpoints.MapControllerRoute(
                    name: "TwitterAccount",
                    pattern: "TwitterAccount/{action=Edit}/{id?}",
                    defaults: new { controller = "TwitterAccount", action = "Edit" });

                endpoints.MapControllerRoute(
                    name: "TwitterAccount",
                    pattern: "TwitterAccount/{action=Delete}/{id?}",
                    defaults: new { controller = "TwitterAccount", action = "Delete" });

                endpoints.MapControllerRoute(
                    name: "TwitterAccount",
                    pattern: "TwitterAccount/{action=List}/{id?}",
                    defaults: new { controller = "TwitterAccount", action = "List" });


                endpoints.MapControllerRoute(
                    name: "TwitterConfiguration",
                    pattern: "TwitterConfiguration/{action=Index}/{id?}",
                    defaults: new { controller = "TwitterConfiguration", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "TwitterConfiguration",
                    pattern: "TwitterConfiguration/{action=Details}/{id?}",
                    defaults: new { controller = "TwitterConfiguration", action = "Details" });

                endpoints.MapControllerRoute(
                    name: "TwitterConfiguration",
                    pattern: "TwitterConfiguration/{action=Create}/{id?}",
                    defaults: new { controller = "TwitterConfiguration", action = "Create" });

                endpoints.MapControllerRoute(
                    name: "TwitterConfiguration",
                    pattern: "TwitterConfiguration/{action=Edit}/{id?}",
                    defaults: new { controller = "TwitterConfiguration", action = "Edit" });

                endpoints.MapControllerRoute(
                    name: "TwitterConfiguration",
                    pattern: "TwitterConfiguration/{action=Delete}/{id?}",
                    defaults: new { controller = "TwitterConfiguration", action = "Delete" });

                endpoints.MapControllerRoute(
                   name: "TwitterConfiguration",
                   pattern: "TwitterConfiguration/{action=List}/{id?}",
                   defaults: new { controller = "TwitterConfiguration", action = "List" });


                endpoints.MapControllerRoute(
                    name: "Tweet",
                    pattern: "Tweet/{action=Index}/{id?}",
                    defaults: new { controller = "Tweet", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Tweet",
                    pattern: "Tweet/{action=Details}/{id?}",
                    defaults: new { controller = "Tweet", action = "Details" });

                endpoints.MapControllerRoute(
                    name: "Tweet",
                    pattern: "Tweet/{action=Create}/{id?}",
                    defaults: new { controller = "Tweet", action = "Create" });

                endpoints.MapControllerRoute(
                    name: "Tweet",
                    pattern: "Tweet/{action=Edit}/{id?}",
                    defaults: new { controller = "Tweet", action = "Edit" });

                endpoints.MapControllerRoute(
                    name: "Tweet",
                    pattern: "Tweet/{action=Delete}/{id?}",
                    defaults: new { controller = "Tweet", action = "Delete" });

                endpoints.MapControllerRoute(
                    name: "Tweet",
                    pattern: "Tweet/{action=List}/{id?}",
                    defaults: new { controller = "Tweet", action = "List" });
            });

            var consumerKey = Configuration["TwitterApiSettings:ConsumerKey"];
            var consumerSecret = Configuration["TwitterApiSettings:ConsumerSecret"];
            var accessToken = Configuration["TwitterApiSettings:AccessToken"];
            var accessTokenSecret = Configuration["TwitterApiSettings:AccessTokenSecret"];

            var userCredentials = new TwitterCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
            
            var client=new TwitterClient(userCredentials);
        }

    }
}
