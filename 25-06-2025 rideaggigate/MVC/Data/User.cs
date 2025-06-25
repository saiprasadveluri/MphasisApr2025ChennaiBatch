using System.ComponentModel.DataAnnotations;

namespace RideAggrigationAPI.Data
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string UserRole { get; set; }


    }
}
