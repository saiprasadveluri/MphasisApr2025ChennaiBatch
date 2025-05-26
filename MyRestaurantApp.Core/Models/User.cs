using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Models
{
    public class User
    {
        public Guid UId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } // Hashed password
        public UserRole Role { get; set; }
        public string Location { get; set; } // User's delivery address
        public DateTime DateCreated { get; set; }

        public User()
        {
            UId = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }
    }
}
