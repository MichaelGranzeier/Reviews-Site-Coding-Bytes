using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class SchoolSupplyController : Controller
    {
        private List<SchoolSupply> SchoolSupplyList = new List<SchoolSupply>()
        {
            new SchoolSupply() { Id = 1, Name = "Ticonderoga Pencil", Description="Triangular and fun!", AgeGroup= AgeGroup.ElemSchool, Price= 2.99, SupplyType= SupplyType.Writing},
            new SchoolSupply() { Id = 2, Name = "Bic Pen", Description="Filled with ink!", AgeGroup= AgeGroup.ElemSchool, Price= 1.99, SupplyType= SupplyType.Writing},
        };
        
        public IActionResult Index()
        {
            return View(SchoolSupplyList);
        }
    }
}
