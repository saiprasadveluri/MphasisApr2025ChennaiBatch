using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelAPP.Models
{
    public class User
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Role { get; set; } // Admin, Owner, Customer
        public string Location { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Restaurant> OwnedRestaurants { get; set; } = new List<Restaurant>();

    }
}
