using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Models
{
    public class MenuItem
    {
        public Guid MId { get; set; }
        public Guid RestaurantRId { get; set; } // Foreign key to Restaurant
        public string DishName { get; set; }
        public DishType DishType { get; set; }
        public decimal Price { get; set; }
        public decimal ValueForUnit { get; set; } // e.g., 100 for 100 gms
        public string Units { get; set; } // e.g., "gms", "ml", "each", "plate"
        public int AvailableQuantity { get; set; } // How many portions/units are available
        public DateTime DateCreated { get; set; }

        public MenuItem()
        {
            MId = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }
    }
}
