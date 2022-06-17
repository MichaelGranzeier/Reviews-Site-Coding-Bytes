using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class SchoolSuppliesController : Controller
    {
        private List<SchoolSupplies> SchoolSuppliesList = new List<SchoolSupplies>()
        { 
            new SchoolSupplies() { Id = 1, Name = "Writing"},
            new SchoolSupplies() { Id = 2, Name = "Books"},
            new SchoolSupplies() { Id = 3, Name = "Notebooks"},
            new SchoolSupplies() { Id = 4, Name = "Calculators"},
            new SchoolSupplies() { Id = 5, Name = "Backpacks"},
            new SchoolSupplies() { Id = 6, Name = "Binders"},
            new SchoolSupplies() { Id = 7, Name = "Paper"}
        };
        public IActionResult Index()
        {
            return View(SchoolSuppliesList);
        }
    }
}
