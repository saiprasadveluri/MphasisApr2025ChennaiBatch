using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDelAPP.Models;

namespace FoodDelAPP
{
    public static class DataStore
    {
        public static List<User> Users = new List<User>();
        public static List<Restaurant> Restaurants = new List<Restaurant>();
        public static List<Order> Orders = new List<Order>();
    }
}
