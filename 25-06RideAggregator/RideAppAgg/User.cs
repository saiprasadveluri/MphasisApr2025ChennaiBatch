using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace RideAppAgg
{
    public class User
    {

        [Key]
        public int UId { get; set; } // Unique identifier for the user
        public string? Email { get; set; } // User's email address
        public string? Password { get; set; } // User's password
        public string? Role { get; set; } // User's role (e.g., Customer, Driver, Admin) 
    }
}
