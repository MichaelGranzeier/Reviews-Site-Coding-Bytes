using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult Details(int id)
        {
            return View(db.SchoolSupplies.Find(id));
        }

        public IActionResult Create() 
        {
            List<object> enums = new List<object>()
            {
                new {Id = AgeGroup.Pre_K, Name="Pre K"},
                new {Id = AgeGroup.ElemSchool, Name="Elem School"},
                new {Id = AgeGroup.MiddleSchool, Name="Middle School"},
                new {Id = AgeGroup.HighSchool, Name="High School"},
                new {Id = AgeGroup.College, Name="College"}
            };
            ViewBag.Ages = new SelectList(enums, "Id", "Name");

            List<object> enumsTwo = new List<object>()
            {
                new {Id = SupplyType.Writing, Name="Writing utensils"},
                new {Id = SupplyType.Binders, Name="Binders"},
                new {Id = SupplyType.Calculator, Name="Calculators"},
                new {Id = SupplyType.Backpacks, Name="Backpacks"}
            };
            ViewBag.Supplies = new SelectList(enumsTwo, "Id", "Name");
            return View();
        }
        [HttpPost]
  
        public IActionResult Create(SchoolSupply model)
        {
            db.SchoolSupplies.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            List<object> enums = new List<object>()
            {
                new {Id = AgeGroup.Pre_K, Name="Pre K"},
                new {Id = AgeGroup.ElemSchool, Name="Elem School"},
                new {Id = AgeGroup.MiddleSchool, Name="Middle School"},
                new {Id = AgeGroup.HighSchool, Name="High School"},
                new {Id = AgeGroup.College, Name="College"}
            };
            ViewBag.Ages = new SelectList(enums, "Id", "Name");

            List<object> enumsTwo = new List<object>()
            {
                new {Id = SupplyType.Writing, Name="Writing utensils"},
                new {Id = SupplyType.Binders, Name="Binders"},
                new {Id = SupplyType.Calculator, Name="Calculators"},
                new {Id = SupplyType.Backpacks, Name="Backpacks"}
            };
            ViewBag.Supplies = new SelectList(enumsTwo, "Id", "Name");
            SchoolSupply schoolSupply = db.SchoolSupplies.Find(id);
            return View(schoolSupply);
        }
        [HttpPost]
        public IActionResult Edit(SchoolSupply model)
        {
            db.SchoolSupplies.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            SchoolSupply Schoolsupply = db.SchoolSupplies.Find(id);
            return View(Schoolsupply);
        }
        [HttpPost]
        public IActionResult Delete(SchoolSupply model)
        {
            db.SchoolSupplies.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
        
    }
}
