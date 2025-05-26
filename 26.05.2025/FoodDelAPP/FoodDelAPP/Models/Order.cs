using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelAPP.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Restaurant Restaurant { get; set; }
        public User Customer { get; set; }
        public List<MenuItem> OrderedItems { get; set; } = new List<MenuItem>();
        public decimal TotalPrice { get; set; }
        public decimal DiscountApplied { get; set; } = 0;
        public string Status { get; set; } = "Pending"; // Delivered when complete
    }
}
