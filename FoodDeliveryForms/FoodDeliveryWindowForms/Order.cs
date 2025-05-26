using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryWindowForms
{
    public class Order
    {
        public Restaurant Restaurant { get; set; }
        public List<OrderMenuEntry> OrderedMenuItem { get; set; }
        public Users OrderBy { get; set; }
        public Order(Restaurant restaurant, List<OrderMenuEntry> orderedMenuItem, Users orderBy)
        {
            Restaurant = restaurant;
            OrderedMenuItem = orderedMenuItem;
            OrderBy = orderBy;
        }
    }
}