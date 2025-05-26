using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDelForms.Lists;

namespace FoodDelForms
{
    public partial class AdminDashboard : Form
    {
        DataProvider dataProvider;
        public AdminDashboard()
        {
            dataProvider=DataProvider.Instance;
            InitializeComponent();
            //DataProvider.Instance.LoadData();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocation newlocation = new NewLocation(dataProvider);
            newlocation.ShowDialog();
            UpdateLocationgrid();

        }
        private void UpdateLocationgrid()
        {
            List<Location> locations = dataProvider.GetAllLocations();
            GridLocation.DataSource = null;
            GridLocation.DataSource = locations;
            GridLocation.Refresh();
        }
        private void UpdateResturantgrid()
        {
            List<Restaurant> rests = dataProvider.GetAllRestaurants();
            GridRestaurant.DataSource = null;
            GridRestaurant.DataSource = rests;
            GridRestaurant.Refresh();
        }

        private void addRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRestaurant newrest = new NewRestaurant(dataProvider);
            newrest.ShowDialog();
            UpdateResturantgrid();
        }
        



        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            Owner uinfo = new Owner()
            {
                DisplayName = "charpitha",
                Email = "abc@a.com",
                Password = "123456"
            };
            DataProvider.Instance.AddUser(uinfo);

            Location location = new Location()
            {
                LocationName = "CHENNAI"
            };
            DataProvider.Instance.AddLocation(location);
            Restaurant restaurant = new Restaurant("A2B", uinfo, location);
            DataProvider.Instance.AddRestaurant(restaurant);
            dataProvider.LoadData();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataProvider.Instance.SaveToFile();
        }

        private void GridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void UpdateUsergrid()
        {
            List<Users> user = dataProvider.GetAllUsers();
            GridUser.DataSource = null;
            GridUser.DataSource = user;
            GridUser.Refresh();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser user = new NewUser(dataProvider);
            user.ShowDialog();
            UpdateUsergrid();
        }
    }
}
