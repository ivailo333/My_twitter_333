using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using My_twitter_333.Models;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace My_twitter_333.Controllers
{
    public class TweetController : Controller
    {
        private readonly TwitterDbContext _context;
        public TweetController(TwitterDbContext context)
        {
            _context = context;
        }

        // GET: TweetController
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: TweetController/Details/5
        public ActionResult Details(int id)
        {
            return View("Details");
        }

        // GET: TweetController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: TweetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Create");
            }
        }

        // GET: TweetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Edit");
        }

        // POST: TweetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Edit");
            }
        }

        // GET: TweetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Delete");
        }

        // POST: TweetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Delete");
            }
        }

        // GET: TweetController/List
        public ActionResult List()
        {
            return View("List");
        }
    }
}
