using Microsoft.AspNetCore.Mvc;
using PracticalCourses.Interfaces;
using PracticalCourses.Models;
using PracticalCourses.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index()
        {
            var categories = AutoMapper.Mapper.Map<List<CategoryResponse>>(await _categoryService.GetAllCategory());
            var newsCourses = AutoMapper.Mapper.Map<List<CourseResponse>>(_courseService.GetThreeNews());
            var bestesellersCourses = AutoMapper.Mapper.Map<List<CourseResponse>>(_courseService.GetThreeBestsellers());

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