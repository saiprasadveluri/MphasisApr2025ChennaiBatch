using System;
using System.Windows.Forms;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
            new AddRestaurantForm().Show();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List of all users would be displayed here", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}