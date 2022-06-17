using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class SchoolSuppliesController : Controller
    {
        private List<SchoolSupplies> SchoolSuppliesList = new List<SchoolSupplies>() { new SchoolSupplies() { Id = 1,Name = "Pens"},new SchoolSupplies() { Id = 2, Name = "Pencils" } };
        public IActionResult Index()
        {
            return View();
        }
    }
}
