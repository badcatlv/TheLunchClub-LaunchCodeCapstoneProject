namespace option4mvc.Models.CartModels
{
    public class Cart
    {
        public int CartId { get; set; }
        public string? UserId { get; set; }
        public int CartDetailId { get; set; }
        public bool? IsDeleted { get; set; }


    }
}
