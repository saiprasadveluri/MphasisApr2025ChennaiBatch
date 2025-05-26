
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FFoodDeliveryAggregateApp;
using FoodDeliveryAggregateApp;

namespace FoodDeliveryAggregateApp
{
    public class DataProvider
    {
        private const string USER_FILE_NAME = "UserInfo.txt";
        private const string RESTAURANT_FILE_NAME = "RestInfo.txt";
        private const string ORDER_FILE_NAME = "Order.txt";
        private const string LOCATION_FILE_NAME = "Location.txt";

        public List<Users> user;
        public List<Location> _locations;
        public List<Restaurant> _restaurants;
        public List<Order> _orders;
        public DataProvider()
        {
            user = new List<Users>();
            _locations = new List<Location>();
            _restaurants = new List<Restaurant>();
            _orders = new List<Order>();
        }
        private static DataProvider _instance;
        public static DataProvider instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataProvider();
                return _instance;
            }
        }


        //loading the data from the file.text
        public void LoadData()
        {
            LoadUserDetails(USER_FILE_NAME);
            LoadRestaurantDetails(RESTAURANT_FILE_NAME);
            //LoadOrderDetails(ORDER_FILE_NAME);
            LoadLocations(LOCATION_FILE_NAME);
        }
        private void LoadUserDetails(string filename)
        {
            if (!File.Exists(filename))
            {
                return;
            }
            StreamReader streamReader = new StreamReader(filename);
            string JSonString = streamReader.ReadToEnd();
            streamReader.Close();
            user = JsonSerializer.Deserialize<List<Users>>(JSonString);
        }
        private void LoadRestaurantDetails(string filename)
        {
            if (!File.Exists(filename))
            {
                return;
            }
            StreamReader streamReader = new StreamReader(filename);
            string JSonString = streamReader.ReadToEnd();
            streamReader.Close();
            _restaurants = JsonSerializer.Deserialize<List<Restaurant>>(JSonString);

        }
        //private void LoadOrderDetails(string filename)
        //{
        //    StreamReader streamReader = new StreamReader(filename);

        //    string JSonString = streamReader.ReadToEnd();
        //    streamReader.Close();
        //    _orders = JsonSerializer.Deserialize<List<Order>>(JSonString);
        //}
        public bool Verify(string email, string password)
        {
            Users temp = user.Find(ui => ui.Email == email && ui.Password == password);
            if (temp != null)
            {
                //if(_users.Role)
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoadLocations(string filename)
        {
            if (!File.Exists(filename))
            {
                return;
            }
            StreamReader streamReader = new StreamReader(filename);
            string JSonString = streamReader.ReadToEnd();
            streamReader.Close();
            _locations = JsonSerializer.Deserialize<List<Location>>(JSonString);
        }

        //saving details
        private void SaveLocationDetails(string filename)
        {
            string JSonString = JsonSerializer.Serialize<List<Location>>(_locations);
            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.Write(JSonString);
            streamWriter.Close();
        }
        private void SaveUserDetails(string filename)
        {
           string JSonString = JsonSerializer.Serialize<List<Users>>(user);
            StreamWriter streamWriter = new StreamWriter(filename);
          streamWriter.Write(JSonString);
            streamWriter.Close();
        }
        private void SaveRestaurantDetails(string filename)
        {
            string JSonString = JsonSerializer.Serialize<List<Restaurant>>(_restaurants);
            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.Write(JSonString);
            streamWriter.Close();
        }
        private void SaveOrderDetails(string filename)
        {
            string JSonString = JsonSerializer.Serialize<List<Order>>(_orders);
            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.Write(JSonString);
            streamWriter.Close();
        }

        //Load and Save()
        public void SaveToFile()
        {
            SaveUserDetails(USER_FILE_NAME);
            SaveRestaurantDetails(RESTAURANT_FILE_NAME);
            SaveOrderDetails(ORDER_FILE_NAME);
            SaveLocationDetails(LOCATION_FILE_NAME);
        }


        //crud operations

        public List<Location> GetAllLocations()
        {
            return _locations;
        }

        public bool AddLocation(Location location)
        {
            var Res = _locations.Find(loc => loc.LocationName == location.LocationName);
            if (Res == null)
            {
                _locations.Add(location);
                return true;
            }
            return false;
        }
        public List<Users> GetAllUsers()
        {
            return user;
        }

        //public List<Owner> GetAllOwners()
        //{
        //    return _userInfo.OfType<Owner>().ToList();
        //}

        public bool AddUser(Users userInfo)
        {
            Users temp = user.Find(ui => ui.Email == userInfo.Email);
            if (temp == null)
            {
                user.Add(userInfo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRestaurant(Restaurant restaurant)
        {
            var Res = _restaurants.Find(r => r.RestaurantName == restaurant.RestaurantName && r.RestLocation.LocationName == restaurant.RestLocation.LocationName);
            if (Res == null)
            {
                _restaurants.Add(restaurant);
                return true;
            }
            return false;
        }

        public List<Restaurant> GetRestaurants()
        {
            return _restaurants;
        }

        public List<Restaurant> GetRestaurantsByLocation(string LocName)
        {
            return _restaurants.Where(r => r.RestLocation.LocationName == LocName).ToList();
        }

        public List<Restaurant> GetRestaurantsByOwner(string Email)
        {
            return _restaurants.Where(r => r.RestOwner.Email == Email).ToList();
        }

        public bool PlaceOrder(Users custObj, List<OrderMenuEntry> orderdMenu, Restaurant restaurant)
        {
            Order order = new Order(restaurant, orderdMenu, custObj);
            _orders.Add(order);
            return true;
        }

        public List<Order> GetOrderList()
        {
            return _orders;
        }

        public List<Order> GetOrderByCustomer(String email)
        {
            return _orders.Where(o => o.OrderBy.Email == email).ToList();
        }

        public List<Order> GetOrderByRestaurant(Restaurant restaurant)
        {
            return _orders.Where(o => o.Restaurant == restaurant).ToList();
        }
    }
}
