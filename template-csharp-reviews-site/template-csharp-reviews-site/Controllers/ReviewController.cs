using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class ReviewController : Controller
    {
        public SupplyContext db { get; set; }
        public ReviewController(SupplyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Reviews.ToList());
        }

        public IActionResult Details(int id)
        {
            return View(db.Reviews.Find(id));
        }

        public IActionResult Create()
        {
            ViewBag.SchoolSupplies = new SelectList(db.SchoolSupplies.ToList(), "Id", "Name");
            return View(new Review());
        }

        [HttpPost]
        public IActionResult Create(Review model)
        {
            db.Reviews.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.SchoolSupplies = new SelectList(db.SchoolSupplies.ToList(), "Id", "Name");
            return View(db.Reviews.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Review model)
        {
            db.Reviews.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Review review = db.Reviews.Find(id);
            return View(review);
        }
        [HttpPost]
        public IActionResult Delete(Review model)
        {
            db.Reviews.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
