using PracticalCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.ViewModel
{
    public class HomeIndexViewModel
    {
        public List<CategoryResponse> Categories { get; set; }
        public List<CourseResponse> News { get; set; }
        public List<CourseResponse> Bestsellers { get; set; }
    }
}
