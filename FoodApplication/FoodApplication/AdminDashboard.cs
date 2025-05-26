using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApplication
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
             public partial class AdminDashboard : Form
        {
            DataProvider dataProvider;
            public AdminDashboard()
            {
                dataProvider = DataProvider.instance;
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
                List<Locations> locationslist = dataProvider.GetAllLocations();
                LocationsGrid.DataSource = null;
                LocationsGrid.DataSource = locationslist;
                LocationsGrid.Refresh();
            }

            private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
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
            private void addRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
            {
                NewRestaurant newRest = new NewRestaurant(dataProvider);
                newRest.ShowDialog();
                UpdateRestGrid();
            }
            private void UpdateRestGrid()
            {
                List<Restaurant> restlist = dataProvider.GetRestaurants();
                RestaurantGrid.DataSource = null;
                RestaurantGrid.DataSource = restlist;
                RestaurantGrid.Refresh();
            }

            private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
            {
                dataProvider.SaveToFile();
            }
        }
        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}
