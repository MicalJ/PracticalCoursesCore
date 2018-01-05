using System;
using System.Collections.Generic;
using System.Text;

namespace PCDatabase.DAL
{
    public class Course
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
        public virtual Category Category { get; set; }
    }
}
