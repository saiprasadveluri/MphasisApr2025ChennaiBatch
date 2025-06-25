using System.ComponentModel.DataAnnotations;

namespace RideAggregatorApp.Model
{
    public class Account
    {
        [Key]
        public Guid Id{ get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string Role { get; set; }
    }
}
