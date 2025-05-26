using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryWindowForms
{
    public partial class AdminDashboard : Form
    {

        DataProvider dataProvider;
        public AdminDashboard()
        {
            dataProvider = DataProvider.Instance;
            InitializeComponent();
            dataProvider.LoadData();
        }
        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocations newLocation = new AddLocations(dataProvider);
            newLocation.ShowDialog();
            UpdateLocationGrid();

        }

        private void UpdateLocationGrid()
        {
            List<Locations> locationslist = dataProvider.GetAllLocations();
            LocationsGrid.DataSource = null;
            LocationsGrid.DataSource = locationslist;
            LocationsGrid.Refresh();
        }

        private void addUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser(dataProvider);
            newUser.ShowDialog();
            UpdateUsersGrid();

        }


        private void UpdateUsersGrid()
        {
            List<Users> userslist = dataProvider.GetAllUsers();
            UsersGrid.DataSource = null;
            UsersGrid.DataSource = userslist;
            UsersGrid.Refresh();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataProvider.SaveToFile();
        }

       
    }
}
//        private DataProvider _dataProvider;
//        public AdminDashboard()
//        {
//            _dataProvider = DataProvider.Instance;
//            InitializeComponent();
//        }



//        private void UpdateLocationgrid()
//        {
//            List<Locations> locationlist = _dataProvider.GetAllLocations();
//            gridLocation.DataSource = null;
//            gridLocation.DataSource = locationlist;
//            gridLocation.Refresh();
//        }

//        private void UpdateRestaurantgrid()
//        {
//            List<Restaurant> restaurantlists = _dataProvider.GetAllRestaurants();
//            gridRestaurant.DataSource = null;
//            gridRestaurant.DataSource = restaurantlists;
//            gridRestaurant.Refresh();
//        }




//        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            AddLocations addLocation = new AddLocations(_dataProvider);
//            addLocation.ShowDialog();
//            UpdateLocationgrid();
//        }

//        private void addRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            NewRestaurant addRestaurant = new NewRestaurant(_dataProvider);
//            addRestaurant.ShowDialog();
//            UpdateRestaurantgrid();

//        }

//        private void AdminDashboard_Load(object sender, EventArgs e)
//        {
//            DataProvider.Instance.LoadData();
//        }
//    }
//}
