namespace option4mvc.Models.OrderModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? UserId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public OrderStatus? Status { get; set; }

    }
}
