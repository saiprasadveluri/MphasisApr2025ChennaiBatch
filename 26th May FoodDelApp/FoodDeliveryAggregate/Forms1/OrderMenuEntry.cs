using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAggregate.Lists
{
    public class OrderMenuEntry
    {
        public Menu Menu { get; set; }
        public int Qty { get; set; }
    }
}
