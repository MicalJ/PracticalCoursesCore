namespace PCDatabase.DAL
{
    public class OrderPosition
    {
        public int OrderPositionId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public int OrderId { get; set; }
        public int CourseId { get; set; }
    }
}