using System;
using System.Collections.Generic;
using System.Text;

namespace PCDatabase.DbModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal ValueOrder { get; set; }

        public List<OrderPosition> OrderPosition { get; set; }
    }

    public enum OrderStatus
    {
        New,
        Completed
    }
}
