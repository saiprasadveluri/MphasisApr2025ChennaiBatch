
namespace RideAppAggMVC.Models
{

    public class GetAllUser()
    {
        public List<UserDTO> data { get; set; } // List of UserDTO objects representing all users
    }
    public class UserDTO
    {
        public int uId { get; set; } // Unique identifier for the user
        public string email { get; set; } // User's email address
        public string password { get; set; } // User's password
        public string? role { get; set; } // User's role (e.g., Customer, Driver, Admin) 
    }
}
