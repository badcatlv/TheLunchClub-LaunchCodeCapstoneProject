namespace option4mvc.Models.OrderModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        //TODO: Add UserId connection, order status connection, order detail connection

    }
}
