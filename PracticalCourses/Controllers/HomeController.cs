using Microsoft.AspNetCore.Mvc;
using PracticalCourses.Interfaces;

namespace PracticalCourses.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategory();


            
            return View();
        }

        public IActionResult SitesStatic(string name)
        {
            return View(name);
        }
    }
}