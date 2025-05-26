using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApplication
{
   
        public class Order
        {
            public Restaurant Restaurant { get; set; }
            public List<OrderMenu> OrderedMenuItem { get; set; }
            public Users OrderBy { get; set; }
            public Order(Restaurant restaurant, List<OrderMenu> orderedMenuItem, Users orderBy)
            {
                Restaurant = restaurant;
                OrderedMenuItem = orderedMenuItem;
                OrderBy = orderBy;
            }
        }
    }
