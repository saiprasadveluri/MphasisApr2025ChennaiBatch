using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurantApp.Core.Models
{
    public class OrderLineItem
    {
        public Guid OLIId { get; set; }
        public Guid OId { get; set; } // Foreign key to Order
        public Guid MId { get; set; } // Foreign key to MenuItem
        public int Quantity { get; set; }
        public decimal UnitPriceAtOrder { get; set; } // Price at the time of order
        public decimal ValueForUnitAtOrder { get; set; } // Value for unit at the time of order
        public string UnitsAtOrder { get; set; } // Units at the time of order

        public OrderLineItem()
        {
            OLIId = Guid.NewGuid();
        }
    }
}
