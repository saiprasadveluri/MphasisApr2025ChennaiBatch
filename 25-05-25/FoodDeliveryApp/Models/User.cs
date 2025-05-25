using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models
{
    public enum UserRole
    {
        Admin,
        Owner,
        Customer
    }

    public class User
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public UserRole Role { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}