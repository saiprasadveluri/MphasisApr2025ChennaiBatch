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
    public partial class OwnerDashboardForm : Form
    {

        private User _owner;

        public OwnerDashboardForm(User owner)
        {
            InitializeComponent();
            _owner = owner;
            LoadOwnedRestaurants();
            cmbDishType.Items.AddRange(new[] { "Veg", "Non-Veg", "Jain" });
        }
        public OwnerDashboardForm()
        {
            InitializeComponent();
        }

        private void LoadOwnedRestaurants()
        {
            cmbRestaurants.Items.Clear();
            foreach (var r in _owner.OwnedRestaurants)
            {
                cmbRestaurants.Items.Add(r);
            }

            cmbRestaurants.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbRestaurants.SelectedItem == null)
            {
                MessageBox.Show("Please select a restaurant.");
                return;
            }

            string name = txtItemName.Text.Trim();
            string dishType = cmbDishType.Text;
            string priceText = txtPrice.Text.Trim();
            string valueText = txtValueForUnit.Text.Trim();
            string units = txtUnits.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dishType) || string.IsNullOrEmpty(priceText) ||
                string.IsNullOrEmpty(valueText) || string.IsNullOrEmpty(units))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price) || !decimal.TryParse(valueText, out decimal unitValue))
            {
                MessageBox.Show("Price and Value for Unit must be numeric.");
                return;
            }

            var selectedRestaurant = (Restaurant)cmbRestaurants.SelectedItem;

            var newItem = new MenuItem
            {
                Id = selectedRestaurant.MenuItems.Count + 1,
                Name = name,
                DishType = dishType,
                Price = price,
                ValueForUnit = (double)unitValue,
                Units = units,
                AvailableQuantity = 10 // initial quantity
            };

            selectedRestaurant.MenuItems.Add(newItem);
            MessageBox.Show("Menu item added.");
            ClearFields();
            LoadMenuItems();
        }

        private void ClearFields()
        {
            txtItemName.Clear();
            txtPrice.Clear();
            txtValueForUnit.Clear();
            txtUnits.Clear();
            cmbDishType.SelectedIndex = -1;
        }

        

        private void cmbRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            lstMenuItems.Items.Clear();
            if (cmbRestaurants.SelectedItem is Restaurant selectedRest)
            {
                foreach (var item in selectedRest.MenuItems)
                {
                    lstMenuItems.Items.Add($"{item.Name} - ₹{item.Price} ({item.DishType})");
                }
            }
        }
    }
}
