using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAggregateApp
{
    public class DataProviders
    {
        private DataProviders()
        {
            _users = new List<User>();
            _locations = new List<Location>();
            _restaurants = new List<Restaurant>();
            _orders=new List<Order>();
            _orderItem=new List<Orderitem>();
            _menuItems=new List<MenuItem>();

        }
        private static DataProviders _instance;
        public static DataProviders Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataProviders();
                return _instance;
            }
        }
        private List<Location> _locations;
        private List<User> _users;
        private List<Restaurant> _restaurants;
        private List<Order> _orders;
        private List<Orderitem> _orderItem;
        private List<MenuItem> _menuItems;
        private int orders;

        //properties
        public List<Location> Location { get { return _locations; } }
        public List<User> User { get { return _users; } }
        public List<Restaurant> Rest { get { return _restaurants; } }


        public void AddLocation(Location loc)
        {
            Location.Add(loc);
        }
        public List<Location> GetAllLocations()
        {
            return Location;
        }

        public void AddRestaurant(Restaurant res)
        {
            Rest.Add(res);
        }
        public void AddUser(User user)
        {
            User.Add(user);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return Rest;
        }
        private string RestaurantFile = "Restaurant.cs";
        private string LocationFile = "Location.cs";

        public void SaveData()
        {
            using (FileStream fs = new FileStream(RestaurantFile, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
            }
            using (FileStream fs = new FileStream(LocationFile, FileMode.Create))
            {
                BinaryFormatter formatter= new BinaryFormatter();
                formatter.Serialize(fs, _locations);

            }

        }
        public List<Order> GetOrdersByUser(User user)
        {
            return _orders.Where(o => o.Customer.Id == user.Id).ToList();
        }

        public void LoadData()
        {
            if (File.Exists(RestaurantFile))
            {
                using(FileStream fs = new FileStream(RestaurantFile,FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    _restaurants = (List<Restaurant>)formatter.Deserialize(fs);
                }
            }
            if (File.Exists(LocationFile))
            {
                using(FileStream fs = new FileStream(LocationFile,FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    _locations=(List<Location>)formatter.Deserialize(fs);
                }
            }

        }


    }

}
    


