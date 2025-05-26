using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace FoodDeliveryAggregateApp
{
    public class Dataprovider
    {
        private const string USER_FILE_NAME = "UserInfo.txt";
        private const string RESTAURANT_FILE_NAME = "RestInfo.txt";
        private const string ORDER_FILE_NAME = "Order.txt";
        private const string LOCATION_FILE_NAME = "Location.txt";

        public List<Users> _users;
        public List<Location> _locations;
        public List<Restuarant> _restaurants;
        public List<Orders> _orders;
        public Dataprovider()
        {
            _users = new List<Users>();
            _locations = new List<Location>();
            _restaurants = new List<Restuarant>();
            _orders = new List<Orders>();
        }
        private static Dataprovider _instance;
        public static Dataprovider instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Dataprovider();
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
            _users = JsonSerializer.Deserialize<List<Users>>(JSonString);
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
            _restaurants = JsonSerializer.Deserialize<List<Restuarant>>(JSonString);

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
            Users temp = _users.Find(ui => ui.Email == email && ui.Password == password);
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
            string JSonString = JsonSerializer.Serialize<List<Users>>(_users);
            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.Write(JSonString);
            streamWriter.Close();
        }
        private void SaveRestaurantDetails(string filename)
        {
            string JSonString = JsonSerializer.Serialize<List<Restuarant>>(_restaurants);
            StreamWriter streamWriter = new StreamWriter(filename);
            streamWriter.Write(JSonString);
            streamWriter.Close();
        }
        private void SaveOrderDetails(string filename)
        {
            string JSonString = JsonSerializer.Serialize<List<Orders>>(_orders);
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
            return _users;
        }

        //public List<Owner> GetAllOwners()
        //{
        //    return _userInfo.OfType<Owner>().ToList();
        //}

        public bool AddUser(Users userInfo)
        {
            Users temp = _users.Find(ui => ui.Email == userInfo.Email);
            if (temp == null)
            {
                _users.Add(userInfo);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRestaurant(Restuarant restaurant)
        {
            var Res = _locations.Find(loc => loc.LocationName == loc.LocationName);
            if (Res == null)
            {
                _restaurants.Add(restaurant);
               return true;
           }
           return false;
        }

        public List<Restuarant> GetRestaurants()
        {
            return _restaurants;
        }

        public List<Restuarant> GetRestaurantsByLocation(string LocName)
        {
            return _restaurants.Where(r => r.RestLocation.LocationName == LocName).ToList();
        }

        public List<Restuarant> GetRestaurantsByOwner(string Email)
        {
            return _restaurants.Where(r => r.RestOwner.Email == Email).ToList();
        }

        //public bool PlaceOrder(Users custObj, List<OrderMenuEntry> orderdMenu, Restuarant restaurant)
        //{
        //    Orders order = new Orders(restaurant, orderdMenu, custObj);
        //    _orders.Add(order);
        //    return true;
        //}

        public List<Orders> GetOrderList()
        {
            return _orders;
        }

        public List<Orders> GetOrderByCustomer(String email)
        {
            return _orders.Where(o => o.OrderBy.Email == email).ToList();
        }

        public List<Orders> GetOrderByRestaurant(Restuarant restaurant)
        {
            return _orders.Where(o => o.Restaurant == restaurant).ToList();
        }
    }

}

