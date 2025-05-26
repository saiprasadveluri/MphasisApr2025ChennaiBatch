using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryAggregateApp
{
    public partial class AdminDashBoard : Form
    {
        private DataProviders dataProviders;
        public AdminDashBoard()
        {
            dataProviders = DataProviders.Instance;
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRestaurant addRestaurant = new AddRestaurant(dataProviders);
            addRestaurant.ShowDialog();
            UpdateRestaurantGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(dataProviders);
            addUser.ShowDialog();
        }

        private void addUserToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(dataProviders);
            addUser.ShowDialog();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation newLocation = new AddLocation(dataProviders);
            newLocation.ShowDialog();
            UpdateLocationGrid();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<Location> locationslist = dataProviders.GetAllLocations();
            //LocationsGrid.DataSource = null;
            //LocationsGrid.DataSource = locationslist;
            //LocationsGrid.Refresh();
        }

        private void UpdateLocationGrid()
        {
            List<Location> locationslist = dataProviders.GetAllLocations();
            LocationsGrid.DataSource = null;
            LocationsGrid.DataSource = locationslist;
            LocationsGrid.Refresh();
        }
        private void UpdateRestaurantGrid()
        {
            List<Restaurant> restaurantlist = dataProviders.GetAllRestaurants();
            RestaurantsGrid.DataSource = null;
            RestaurantsGrid.DataSource = restaurantlist;
            RestaurantsGrid.Refresh();
        }


    }
}
