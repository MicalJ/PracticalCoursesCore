using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Models
{
    public class OrderPositionResponse
    {
        public int OrderPositionId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public int OrderId { get; set; }
        public int CourseId { get; set; }
    }
}
