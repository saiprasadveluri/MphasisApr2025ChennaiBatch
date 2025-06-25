using System.ComponentModel.DataAnnotations;

namespace RideAggregatorAPI.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
         public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }

    }
}
