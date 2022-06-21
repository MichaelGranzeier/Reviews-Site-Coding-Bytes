using Microsoft.AspNetCore.Mvc;

namespace template_csharp_reviews_site.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
