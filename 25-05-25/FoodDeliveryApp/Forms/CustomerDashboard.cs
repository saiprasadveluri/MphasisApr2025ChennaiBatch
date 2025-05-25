using System;
using System.Windows.Forms;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Forms
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void btnSearchRestaurants_Click(object sender, EventArgs e)
        {
            new RestaurantSearchForm().ShowDialog();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List of your orders would be displayed here", "Your Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}