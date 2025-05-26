using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAggregateApp
{
    public class Orders
    {
        public Restuarant Restaurant { get; set; }
       // public List<OrderMenuEntry> OrderedMenuItem { get; set; }
        public Users OrderBy { get; set; }
        //public Orders(Restuarant restaurant, List<OrderMenuEntry> orderedMenuItem, Users orderBy)
        //{
        //    Restaurant = restaurant;
        //  //  OrderedMenuItem = orderedMenuItem;
        //    OrderBy = orderBy;


        //}
    }
}
