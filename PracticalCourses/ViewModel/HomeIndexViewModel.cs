using PCDatabase.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.ViewModel
{
    public class HomeIndexViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Course> News { get; set; }
        public List<Course> Bestsellers { get; set; }
    }
}
