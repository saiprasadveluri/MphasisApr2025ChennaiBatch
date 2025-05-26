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
    public partial class AdminDashboard : Form
    {
        private Dataprovider dataprovider;

        public AdminDashboard()
        {
            dataprovider = Dataprovider.instance;
            InitializeComponent();
            dataprovider.LoadData();
        }
        private void UpdateLocationGrid()
        {
            List<Location> locationList = dataprovider.GetAllLocations();
            gridLocation.DataSource = null;
            gridLocation.DataSource = locationList;
            gridLocation.Refresh();
        }

        //private void updateRestaurantGrid()
        //{
        //    List<Restuarant> locationList = dataprovider.GetAllRestaurants();
        //    gridrestaurant.DataSource = null;
        //    gridrestaurant.DataSource = locationList;
        //    gridrestaurant.Refresh();
        //}

        private void updateUsersGrid()
        {
            List<Users> userlist = dataprovider.GetAllUsers();
            usersGrid.DataSource = null;
            usersGrid.DataSource = userlist;
            usersGrid.Refresh();
        }
        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation addLocation = new AddLocation(dataprovider);
            addLocation.ShowDialog();
            UpdateLocationGrid();

        }

        //private void addRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddRestaurant addrestaurant = new AddRestaurant(dataprovider);
        //    addrestaurant.ShowDialog();
        //    updateRestaurantGrid();
        //}

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Dataprovider.instance.LoadData();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser(dataprovider);
            newUser.ShowDialog();
            updateUsersGrid();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataprovider.SaveToFile();
        }
    }
}
