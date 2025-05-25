using System;
using System.Windows.Forms;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Forms
{
    public partial class RestaurantSearchForm : Form
    {
        public RestaurantSearchForm()
        {
            InitializeComponent();
            cmbDishTypeFilter.DataSource = Enum.GetValues(typeof(DishType));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            var sampleRestaurant = new Restaurant
            {
                Id = 1,
                Name = "Sample Restaurant",
                Location = txtLocation.Text,
                MinimumOrderValue = 100
            };

            MessageBox.Show($"Found restaurant: {sampleRestaurant.Name} in {sampleRestaurant.Location}", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            new RestaurantMenuForm().ShowDialog();
        }
    }
}