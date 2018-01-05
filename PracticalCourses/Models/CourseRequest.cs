using PCDatabase.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Models
{
    public class CourseRequest
    {
        [Required(ErrorMessage ="Wprowadź nazwę kursu")]
        [StringLength(100)]
        public string TitleCourse { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę autora")]
        [StringLength(100)]
        public string AuthorCourse { get; set; }
        public DateTime DateAdded { get; set; }
        [StringLength(100)]
        public string NameFileImage { get; set; }
        public string DescriptionCourse { get; set; }
        public decimal PriceCourse { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        public int CategoryId { get; set; }
    }
}
