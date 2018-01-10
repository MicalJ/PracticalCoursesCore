using PCDatabase.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Models
{
    public class CategoryRequest
    {
        [Required(ErrorMessage = "Wprowadź nazwę kategorii")]
        [StringLength(100)]
        public string NameCategory { get; set; }
        [Required(ErrorMessage = "Wprowadź opis kategorii")]
        public string DescriptionCategory { get; set; }
        public string NameFileIcon { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
