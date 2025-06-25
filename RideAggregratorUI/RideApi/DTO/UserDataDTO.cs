using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideApi.DTO
{
    public class UserDataDTO
    {
      
        public Guid UserId { get; set; }
       
        public string Email { get; set; }
       
        public string Password { get; set; }
        
        public string UserRole { get; set; }
    }
}
