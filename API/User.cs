using System.ComponentModel.DataAnnotations;

namespace RideAppApi
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        //public Customer? Customer { get; set; }
        //public Driver? Driver { get; set; }
    }
}
