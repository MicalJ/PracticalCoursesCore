using PCDatabase.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Models
{
    public class CategoryResponse
    {
        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public string DescriptionCategory { get; set; }
        public string NameFileIcon { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
