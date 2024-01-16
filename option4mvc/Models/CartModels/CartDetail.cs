using System.Net.Http.Headers;

namespace option4mvc.Models.CartModels
{
    public class CartDetail
    {
        public int CartDetailId { get; set; }
        public int CartId { get; set; }
        public Cart? Cart { get; set; }

        //TODO: Once a catalog is created we can finalize properties for the Cart, ideas below
        /*public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public Product Product { get; set; }
        public int Quantity { get; set; }*/
    }
}
