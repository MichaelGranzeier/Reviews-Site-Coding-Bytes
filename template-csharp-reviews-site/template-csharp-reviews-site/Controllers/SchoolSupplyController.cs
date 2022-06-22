using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class SchoolSupplyController : Controller
    {
        public SupplyContext db { get; set; }

        public SchoolSupplyController(SupplyContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.SchoolSupplies.ToList());
        }
    }
}
