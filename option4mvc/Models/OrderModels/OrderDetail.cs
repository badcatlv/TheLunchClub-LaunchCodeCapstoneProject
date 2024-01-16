using System.Net.Http.Headers;

namespace option4mvc.Models.OrderModels
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public List<OrderDetail>? OrderDetails { get; set;}
        public Order? Order { get; set; }

    }
}
