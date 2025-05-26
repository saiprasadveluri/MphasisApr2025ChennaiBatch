using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_App.Entity;
using Food_App.Data;

namespace Food_App
{
    public partial class CustomerDashboard : Form
    {
        private readonly User _customer;
        private readonly List<OrderLineItem> _cart = new List<OrderLineItem>();
        public CustomerDashboard(User customer)
        {
            InitializeComponent();
            _customer = customer;
            lblWelcome.Text = $"Welcome, {customer.Name}";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var location = txtLocation.Text.ToLower();
            dgvRestaurants.DataSource = DataStorage.Restaurants
                .Where(r => r.Location.Contains(txtLocation.Text))
                .ToList();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                var menuItem = (Entity.MenuItem)dgvMenu.SelectedRows[0].DataBoundItem;
                _cart.Add(new OrderLineItem { Item = menuItem, Quantity = 1 });
                UpdateCartDisplay();
            }
        }
        private void UpdateCartDisplay()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart;
            lblTotal.Text = $"Total: {_cart.Sum(i => i.Item.UnitPrice * i.Quantity):C}";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!_cart.Any())
            {
                MessageBox.Show("Your cart is empty!");
                return;
            }

            var restaurant = _cart.First().Item.Restaurant;
            var total = _cart.Sum(i => i.Item.UnitPrice * i.Quantity);

            if (total < restaurant.MinOrderValue)
            {
                MessageBox.Show($"Minimum order value not met ({restaurant.MinOrderValue:C})");
                return;
            }

            var order = new Order
            {
                OId = DataStorage.Orders.Count + 1,
                Customer = _customer,
                Restaurant = restaurant,
                Items = new List<OrderLineItem>(_cart),
                Total = total,
                Status = "Pending"
            };

            DataStorage.Orders.Add(order);
            _cart.Clear();
            UpdateCartDisplay();
            MessageBox.Show("Order placed successfully!");
        }
    }

}
    
