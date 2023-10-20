using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_twitter_333.Models;

namespace My_twitter_333.Controllers
{
    public class TwitterAccountController : Controller
    {
        private readonly TwitterDbContext _context;
        public TwitterAccountController(TwitterDbContext context)
        {
            _context = context;
        }

        // GET: TwitterAccountController
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: TwitterAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View("Details");
        }

        // GET: TwitterAccountController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: TwitterAccountController/Create
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

        // GET: TwitterAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Edit");
        }

        // POST: TwitterAccountController/Edit/5
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

        // GET: TwitterAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Delete");
        }

        // POST: TwitterAccountController/Delete/5
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

        //GET TwitterAccountController/List
        public ActionResult List()
        {
            return View("List");
        }
    }
}
