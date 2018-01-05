using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Models
{
    public class OrderPositionRequest
    {
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public int OrderId { get; set; }
        public int CourseId { get; set; }
    }
}
