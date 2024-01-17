namespace option4mvc.Models.CartModels
{
    public class Cart
    {
        public int CartId { get; set; }
        public bool? IsDeleted { get; set; } = false;
        //TODO: Add user properties and connection, add cart detail connection.
    }
}
