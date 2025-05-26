using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRestaurantApp.Core.Models;
using MyRestaurantApp.Core;

namespace Food_Del_Apps
{
    public partial class MainDashboardForm : Form
    {
        private MyRestaurantApp.Core.Models.User _currentUser;
        public MainDashboardForm()
        {
            InitializeComponent();
            _currentUser = user;
            lblWelcome.Text = $"Welcome, {_currentUser.DisplayName} ({_currentUser.Role})!";
            DisplayRoleSpecificPanels();
        }
        private void DisplayRoleSpecificPanels()
        {
            // Hide all panels initially
            pnlAdmin.Visible = false;
            pnlOwner.Visible = false;
            pnlAppUser.Visible = false;

            // Show panel based on user role
            switch (_currentUser.Role)
            {
                case UserRole.Admin:
                    pnlAdmin.Visible = true;
                    break;
                case UserRole.RestaurantOwner:
                    pnlOwner.Visible = true;
                    break;
                case UserRole.AppUser:
                    pnlAppUser.Visible = true;
                    break;
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAppSearchRestaurants_Click(object sender, EventArgs e)
        {
            RestaurantSearchForm searchForm = new RestaurantSearchForm(_currentUser);
            searchForm.ShowDialog();
        }

        private async void btnViewMyOrders_Click(object sender, EventArgs e)
        {
            try
            {
                var orders = await Program.OrderService.GetCustomerOrdersAsync(_currentUser.UId);
                if (orders.Count() > 0)
                {
                    MessageBox.Show($"You have {orders.Count()} orders. Check console for details (simulated).", "My Orders");
                    Console.WriteLine($"\n--- Orders for {_currentUser.DisplayName} ---");
                    foreach (var order in orders)
                    {
                        var restaurant = await Program.RestaurantService.GetRestaurantByIdAsync(order.RestaurantRId);
                        Console.WriteLine($"> Order ID: {order.OId} | Restaurant: {restaurant?.Name ?? "Unknown"} | Date: {order.OrderDate:g} | Status: {order.Status} | Total: {order.TotalPrice:C}");
                        Console.WriteLine("  Items:");
                        foreach (var li in order.OrderLineItems)
                        {
                            var menuItem = await Program.MenuService.GetMenuItemByIdAsync(li.MId);
                            Console.WriteLine($"    - {li.Quantity} x {menuItem?.DishName ?? "Unknown Item"} @ {li.UnitPriceAtOrder:C}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have no past orders.", "My Orders");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error viewing orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOwnerViewOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnOwnerViewRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantManagementForm ownerRestaurantForm = new RestaurantManagementForm(_currentUser);
            ownerRestaurantForm.ShowDialog();
        }

        private void btnAdminAddRestaurant_Click(object sender, EventArgs e)
        {
            AddRestaurantForm addRestaurantForm = new AddRestaurantForm();
            addRestaurantForm.ShowDialog();
        }
    }
}

