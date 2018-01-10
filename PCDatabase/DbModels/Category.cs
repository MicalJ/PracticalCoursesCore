using System.Collections.Generic;

namespace PCDatabase.DbModels
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public string DescriptionCategory { get; set; }
        public string NameFileIcon { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}