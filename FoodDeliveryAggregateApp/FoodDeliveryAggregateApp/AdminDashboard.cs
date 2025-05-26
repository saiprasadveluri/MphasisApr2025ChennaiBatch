using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FoodDeliveryAggregateApp;

namespace FoodDeliveryAggregateApp
{
    public partial class AdminDashboard : Form
    {
        DataProvider dataProvider;

        public AdminDashboard()
        {
            dataProvider = DataProvider.instance;
            InitializeComponent();
            dataProvider.LoadData();
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
            gridLocation.DataSource = null;
            gridLocation.DataSource = locationslist;
            gridLocation.Refresh();
        }

        //private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    NewUser newUser = new NewUser(dataProvider);
        //    newUser.ShowDialog();
        //    UpdateUsersGrid();
        //}
        //private void UpdateUsersGrid()
        //{
        //    List<Users> userslist = dataProvider.GetAllUsers();
        //    UsersGrid.DataSource = null;
        //    UsersGrid.DataSource = userslist;
        //    UsersGrid.Refresh();
        //}

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataProvider.SaveToFile();
        }
    }
}