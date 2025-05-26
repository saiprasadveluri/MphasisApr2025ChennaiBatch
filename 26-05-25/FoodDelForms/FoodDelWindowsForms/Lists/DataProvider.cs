using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

namespace FoodDelForms.Lists
{
    public class DataProvider
    {
        private const string USER_FILE_NAME = "UserInfo.txt";
        private const string RESTAURANT_FILE_NAME = "RestInfo.txt";
        private const string ORDER_FILE_NAME = "Order.txt";
        private const string LOCATION_FILE_NAME = "Location.txt";

        private DataProvider()
        {
            _locations = new List<Location>();
            _restlist = new List<Restaurant>();
            _menu = new List<Menu>();
            _orders = new List<Orders>();
            _users = new List<Users>();

        }
        private static DataProvider _instance;
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataProvider();
                return _instance;
            }
        }
        private List<Location> _locations;
        private List<Restaurant> _restlist;
        private List<Menu> _menu;
        private List<Orders> _orders;
        private List<Users> _users;
        //Properties.
        public List<Location> Locations { get { return _locations; } }
        public List<Restaurant> Resturants { get { return _restlist; } }
        public List<Orders> Orders { get { return _orders; } }
        public List<Menu> Menus { get { return _menu; } }
        public List<Users> Users
        {
            get { return _users; }
        }
        public void SaveToFile()
        {
            SaveUserDetails(USER_FILE_NAME);
            SaveRestaurantDetails(RESTAURANT_FILE_NAME);
            SaveOrderDetails(ORDER_FILE_NAME);
            SaveLocationDetails(LOCATION_FILE_NAME);
        }
        public void LoadData()
        {
            LoadUserDetails(USER_FILE_NAME);
            LoadRestaurantDetails(RESTAURANT_FILE_NAME);
            LoadOrderDetails(ORDER_FILE_NAME);
            LoadLocations(LOCATION_FILE_NAME);
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
            _restlist = JsonSerializer.Deserialize<List<Restaurant>>(JSonString);
        }
        public bool Verify(string email, string password)
        {
            Users temp = _users.Find(ui => ui.Email == email && ui.Password == password );
           
                if ((temp) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        private void LoadOrderDetails(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string JSonString = streamReader.ReadToEnd();
            streamReader.Close();
            _orders = JsonSerializer.Deserialize<List<Orders>>(JSonString);
        }

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
            string JSonString = JsonSerializer.Serialize<List<Restaurant>>(_restlist);
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
        public List<Location> GetAllLocations()
        {
            return Locations;
        }
        public void AddLocation(Location loc)
        {
            Locations.Add(loc);
        }
        public List<Restaurant> GetAllRestaurants()
        {
            return _instance.Resturants;
        }
        public void AddRestaurant(Restaurant rest)
        {
            _instance.Resturants.Add(rest);
        }
        public List<Users> GetAllUsers()
        {
            return _instance.Users;
        }
        public List<Owner> GetAllOwners()
        {
            return _users.OfType<Owner>().ToList();
        }

        public bool AddUser(Users user)
        {
            Users temp = _users.Find(ui => ui.Email == user.Email);
            if (temp == null)
            {
                _users.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}