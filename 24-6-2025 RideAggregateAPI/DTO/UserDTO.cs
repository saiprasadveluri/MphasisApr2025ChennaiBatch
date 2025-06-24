using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RideAggregateAPI.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}
