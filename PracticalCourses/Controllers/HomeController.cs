using Microsoft.AspNetCore.Mvc;
using PracticalCourses.Interfaces;
using PracticalCourses.ViewModel;

namespace PracticalCourses.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICourseService _courseService;

        public HomeController(ICategoryService categoryService, ICourseService courseService)
        {
            _categoryService = categoryService;
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategory();
            var newsCourses = _courseService.GetThreeNews();
            var bestesellersCourses = _courseService.GetThreeBestsellers();

            var vm = new HomeIndexViewModel
            {
                Categories = categories,
                News = newsCourses,
                Bestsellers = bestesellersCourses
            };

            return View(vm);
        }

        public IActionResult SitesStatic(string name)
        {
            return View(name);
        }
    }
}