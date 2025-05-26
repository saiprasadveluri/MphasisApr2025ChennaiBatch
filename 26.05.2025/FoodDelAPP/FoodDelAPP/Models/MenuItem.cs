using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelAPP.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DishType { get; set; } // Veg, Non-Veg, Jain
        public decimal Price { get; set; }
        public double ValueForUnit { get; set; }
        public string Units { get; set; } // Gms/Ml/Mtrs
        public int AvailableQuantity { get; set; } = 10;

    }
}
