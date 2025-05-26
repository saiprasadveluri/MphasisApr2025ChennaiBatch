using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Models
{
     public class Restaurant
    {
        public Guid RId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal MinOrderValue { get; set; }
        public Guid OwnerUId { get; set; } // Link to the User who owns this restaurant
        public DateTime DateCreated { get; set; }

        public Restaurant()
        {
            RId = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }
    }
}
