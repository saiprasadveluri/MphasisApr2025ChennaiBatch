using System;
using System.Windows.Forms;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Forms
{
    public partial class RestaurantMenuForm : Form
    {
        public RestaurantMenuForm()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            new PlaceOrderForm().ShowDialog();
        }
    }
}