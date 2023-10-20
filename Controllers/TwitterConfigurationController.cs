using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_twitter_333.Models;

namespace My_twitter_333.Controllers
{
    public class TwitterConfigurationController : Controller
    {
        private readonly TwitterDbContext _context;
        public TwitterConfigurationController(TwitterDbContext context)
        {
            _context = context;
        }

        // GET: TwitterConfigurationController
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: TwitterConfigurationController/Details/5
        public ActionResult Details(int id)
        {
            return View("Details");
        }

        // GET: TwitterConfigurationController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: TwitterConfigurationController/Create
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

        // GET: TwitterConfigurationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Edit");
        }

        // POST: TwitterConfigurationController/Edit/5
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

        // GET: TwitterConfigurationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Delete");
        }

        // POST: TwitterConfigurationController/Delete/5
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

        // GET: TwitterConfigurationController/List
        public ActionResult List()
        {
            return View("List");
        }
    }
}
