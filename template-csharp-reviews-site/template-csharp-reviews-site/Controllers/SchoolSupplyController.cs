using Microsoft.AspNetCore.Mvc;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site.Controllers
{
    public class SchoolSupplyController : Controller
    {
        private List<SchoolSupply> SchoolSupplyList = new List<SchoolSupply>()
        
        {
            new SchoolSupply() { Id = 1, Name = "Ticonderoga Pencil", Description="Triangular and fun!", AgeGroup= AgeGroup.Pre_K, Price= 2.99, SupplyType= SupplyType.Writing},
            new SchoolSupply() { Id = 2, Name = "Bic Pen", Description="Filled with ink!", AgeGroup= AgeGroup.ElemSchool, Price= 1.99, SupplyType= SupplyType.Writing},
            new SchoolSupply() { Id = 3, Name = "5 star", Description="durable and indestructible", AgeGroup= AgeGroup.MiddleSchool, Price=10.00, SupplyType = SupplyType.Binders },
            new SchoolSupply() { Id = 4, Name = "Texas Insturment", Description="Calculator", AgeGroup= AgeGroup.HighSchool, Price=200.00, SupplyType = SupplyType.Calculator},
            new SchoolSupply() { Id = 5, Name = "LL Bean", Description="Durable and strong", AgeGroup= AgeGroup.College, Price=50, SupplyType = SupplyType.Backpacks}
        };
        
        public IActionResult Index()
        {
            return View(SchoolSupplyList);
        }
    }
}
