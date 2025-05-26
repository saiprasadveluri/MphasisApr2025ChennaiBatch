using Food_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food_App.Entity;
using Food_App.Data;

namespace Food_App.Data
{
   
  
        public static class DataStorage
        {
            public static List<Entity.User> Users = new List<Entity.User>();
            public static List<Entity.Restaurant> Restaurants = new List<Entity.Restaurant>();
            public static List<Entity.MenuItem> MenuItems = new List<Entity.MenuItem>();
            public static List<Entity.Order> Orders = new List<Entity.Order>();

            static DataStorage()
            {
           
                var admin = new User
                {
                    UId = 1,
                    Name = "Admin",
                    Role = "Admin",
                    Email = "admin@foodapp.com",
                    Password = "admin123"
                };
                Users.Add(admin);

                var owner = new User
                {
                    UId = 2,
                    Name = "Owner",
                    Role = "Owner",
                    Email = "owner@foodapp.com",
                    Password = "owner123"
                };
                Users.Add(owner);
            }
        }
    }

