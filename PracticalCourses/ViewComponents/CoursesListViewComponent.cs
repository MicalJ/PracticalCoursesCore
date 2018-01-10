using Microsoft.AspNetCore.Mvc;
using PracticalCourses.Interfaces;
using PracticalCourses.Models;
using PracticalCourses.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.ViewComponents
{
    public class CoursesListViewComponent : ViewComponent
    {
        private readonly ICourseService _courseService;

        public CoursesListViewComponent(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string nameCategory)
        {
            var courses = AutoMapper.Mapper.Map<List<CourseResponse>>(await _courseService.GetByCourseId(nameCategory));

            return View("_CoursesList", courses);
        }
    }
}
