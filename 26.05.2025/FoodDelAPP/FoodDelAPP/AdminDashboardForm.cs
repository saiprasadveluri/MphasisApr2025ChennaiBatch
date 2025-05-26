using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDelAPP.Models;

namespace FoodDelAPP
{
    public partial class AdminDashboardForm : Form
    {

        private User _adminUser;

        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            _adminUser = user;
            LoadRestaurants();
        }
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadRestaurants()
        {
            lstRestaurants.Items.Clear();
            foreach (var rest in DataStore.Restaurants)
            {
                lstRestaurants.Items.Add($"{rest.Name} - {rest.Location} (Min: ₹{rest.MinimumOrderValue})");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string location = txtLocation.Text.Trim();
            string minOrderText = txtMinOrderValue.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(minOrderText))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!decimal.TryParse(minOrderText, out decimal minOrder))
            {
                MessageBox.Show("Minimum order value must be a number.");
                return;
            }

            var newRestaurant = new Restaurant
            {
                Id = DataStore.Restaurants.Count + 1,
                Name = name,
                Location = location,
                MinimumOrderValue = minOrder
            };

            DataStore.Restaurants.Add(newRestaurant);
            MessageBox.Show("Restaurant added successfully!");

            txtName.Clear();
            txtLocation.Clear();
            txtMinOrderValue.Clear();
            LoadRestaurants();
        }
    }
}
