using System.Net.Http.Headers;

namespace option4mvc.Models.OrderModels
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public Order? Order { get; set; }

        //TODO: Add status, and product properties.

    }
}
