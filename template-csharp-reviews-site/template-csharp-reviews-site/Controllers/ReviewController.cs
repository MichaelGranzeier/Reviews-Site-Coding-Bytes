using Microsoft.AspNetCore.Mvc;

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
    }
}
