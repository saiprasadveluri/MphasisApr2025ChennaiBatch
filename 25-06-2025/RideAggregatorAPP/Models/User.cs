namespace RideAggregatorAPP.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // You should hash this in production
        public string Role { get; set; } // e.g., "Admin", "Customer"
    }
}
