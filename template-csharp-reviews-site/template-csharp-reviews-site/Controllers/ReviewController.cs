using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Create()
        {
            return View(new Review());
        }
        [HttpPost]

        public IActionResult Create(Review model)
        {
            List<Review> reviews = db.Reviews.ToList();
            db.Reviews.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
