using System.ComponentModel.DataAnnotations;

namespace RideAggregatorAPI.DTO
{
    public class AppUserDTO
    {
        public Guid UserId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int UserRole { get; set; } 
    }
}
