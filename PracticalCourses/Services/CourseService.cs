using Microsoft.EntityFrameworkCore;
using PCDatabase;
using PCDatabase.DbModels;
using PracticalCourses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Services
{
    public class CourseService : ICourseService
    {
        private readonly PCContext _context;

        public CourseService(PCContext pCContext)
        {
            _context = pCContext;
        }

        public List<Course> GetThreeBestsellers()
        {
            return _context.Courses.Where(w => w.Bestseller && !w.Hidden).OrderBy(a => Guid.NewGuid()).Take(3).ToList();
        }

        public List<Course> GetThreeNews()
        {
            return _context.Courses.Where(w => !w.Hidden).OrderByDescending(o => o.DateAdded).Take(3).ToList();
        }

        public async Task<List<Course>> GetByCourseId(string nameCategory)
        {
            var categoryId = _context.Categories.Include("Courses").Where(w => w.NameCategory.ToUpper() == nameCategory.ToUpper()).First();
            var courses = categoryId.Courses.ToList();

            return courses;
        }
    }
}
