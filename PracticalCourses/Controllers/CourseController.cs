using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticalCourses.Interfaces;
using PracticalCourses.Models;

namespace PracticalCourses.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICourseService _courseService;

        public CourseController(ICategoryService categoryService, ICourseService courseService)
        {
            _categoryService = categoryService;
            _courseService = courseService;
        }
        
        [HttpGet]
        [Route("Kategoria/{nameCategory}")]
        public IActionResult List(string nameCategory)
        {
            ViewBag.NameCategory = nameCategory;

            return View();
        }
        
        [HttpGet]
        [Route("kurs-{courseId}.html")]
        public IActionResult Details(int courseId)
        {
            return View(AutoMapper.Mapper.Map<CourseResponse>(_courseService.GetById(courseId)));
        }
    }
}