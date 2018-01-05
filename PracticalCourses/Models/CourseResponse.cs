using PCDatabase.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Models
{
    public class CourseResponse
    {
        public int CourseId { get; set; }
        public string TitleCourse { get; set; }
        public string AuthorCourse { get; set; }
        public DateTime DateAdded { get; set; }
        public string NameFileImage { get; set; }
        public string DescriptionCourse { get; set; }
        public decimal PriceCourse { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        public int CategoryId { get; set; }
    }
}
