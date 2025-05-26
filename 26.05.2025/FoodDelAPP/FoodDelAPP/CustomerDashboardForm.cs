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
using MenuItem = FoodDelAPP.Models.MenuItem;

namespace FoodDelAPP
{
    public partial class CustomerDashboardForm : Form
    {
        private User _customer;

        public CustomerDashboardForm(User customer)
        {
            InitializeComponent();
            _customer = customer;
            cmbDishType.Items.AddRange(new[] { "All", "Veg", "Non-Veg", "Jain" });
            cmbDishType.SelectedIndex = 0;
        }
        public CustomerDashboardForm()
        {
            InitializeComponent();
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Click += btnSearch_Click;
            string location = txtLocation.Text.Trim().ToLower();
            var filtered = DataStore.Restaurants
                .Where(r => r.Location.ToLower().Contains(location))
                .ToList();

            lstRestaurants.Items.Clear();
            foreach (var r in filtered)
                lstRestaurants.Items.Add(r);

            lstRestaurants.DisplayMember = "Name";
        }

        private void lstRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenuItems();
            lstRestaurants.SelectedIndexChanged += lstRestaurants_SelectedIndexChanged;
        }

        private void cmbDishType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenuItems();
            cmbDishType.SelectedIndexChanged += cmbDishType_SelectedIndexChanged;
        }

        private void LoadMenuItems()
        {
            lstMenuItems.Items.Clear();

            if (!(lstRestaurants.SelectedItem is Restaurant selectedRestaurant))
                return;

            var dishFilter = cmbDishType.SelectedItem.ToString();

            IEnumerable<MenuItem> menuItems = selectedRestaurant.MenuItems;

            if (dishFilter != "All")
            {
                menuItems = menuItems.Where(mi => mi.DishType.Equals(dishFilter, StringComparison.OrdinalIgnoreCase));
            }

            foreach (var item in menuItems)
            {
                lstMenuItems.Items.Add($"{item.Name} - ₹{item.Price} ({item.DishType})");
            }
        }


    }
}
