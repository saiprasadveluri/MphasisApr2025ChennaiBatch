using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacyAppAPI.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; } = false;
    }
}
