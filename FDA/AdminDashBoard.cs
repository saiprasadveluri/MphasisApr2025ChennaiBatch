using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDA
{
    public partial class AdminDashBoard : Form
    {
        DataProvider dataProvider;
        public AdminDashBoard()
        {
            dataProvider = DataProvider.Instance;
            InitializeComponent();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocation newLocation = new NewLocation(dataProvider);
            newLocation.ShowDialog();
            UpdateLocationGrid();
        }
        private void UpdateLocationGrid()
        {
            List<Location> locationslist = dataProvider.GetAllLocations();
            GridLocations.DataSource = null;
            GridLocations.DataSource = locationslist;
            GridLocations.Refresh();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser(dataProvider);
            newUser.ShowDialog();
            UpdateUserGrid();
        }
        private void UpdateUserGrid()
        {
            List<Users> userslist = dataProvider.GetAllUsers();
            GridUsers.DataSource = null;
            GridUsers.DataSource = userslist;
            GridUsers.Refresh();
        }

        private void addRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRestaurant newRestaurant = new NewRestaurant(dataProvider);
            newRestaurant.ShowDialog();
            UpdateRestaurantGrid();
        }
        private void UpdateRestaurantGrid()
        {
            List<Restaurant> restaurantlist = dataProvider.GetAllRestaurants();
            GridRestaurant.DataSource = null;
            GridRestaurant.DataSource = restaurantlist;
            GridRestaurant.Refresh();
        }

        private void AdminDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataProvider.SaveToFile();
        }
    }
    
}
