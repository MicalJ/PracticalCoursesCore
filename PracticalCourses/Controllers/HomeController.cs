using Microsoft.AspNetCore.Mvc;

namespace PracticalCourses.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SitesStatic(string name)
        {
            return View(name);
        }
    }
}