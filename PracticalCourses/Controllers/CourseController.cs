using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticalCourses.Interfaces;
using PracticalCourses.Models;

namespace PracticalCourses.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CourseController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        
        public IActionResult List(string nameCategory)
        {
            return View();
        }

        
        public IActionResult Details(string courseId)
        {
            return View();
        }

        
 
    }
}