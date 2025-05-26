using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAggregateApp
{
    public class Restaurant
    {

        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Location { get; set; }
        public decimal MinimumOrderValue {  get; set; }       
        public int OwnerId { get; set; }

    }
}
