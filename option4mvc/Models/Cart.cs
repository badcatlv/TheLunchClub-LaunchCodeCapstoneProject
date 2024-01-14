namespace option4mvc.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string? ItemName { get; set;}
        public string? ItemDescription { get; set;} = null;
        public decimal? ItemPrice { get; set; } = null;
    }
}
