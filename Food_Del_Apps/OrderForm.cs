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
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Food_Del_Apps
{
    public partial class OrderForm : Form
    {
        private User _currentUser;
        private Guid _restaurantId;
        private string _restaurantName;
        private decimal _minOrderValue;


        private Dictionary<Guid, int> _cartItems = new Dictionary<Guid, int>(); // MenuItemId -> Quantity
        private List<CartLineItemDisplay> _cartDisplayList = new List<CartLineItemDisplay>(); // For DataGridView binding

        // Nested class to help with DataGridView binding for cart
        private class CartLineItemDisplay
        {
            public Guid MId { get; set; }
            public string DishName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal LineTotal => Quantity * UnitPrice;
        }
        public OrderForm(User currentUser, Guid restaurantId, string restaurantName, decimal minOrderValue,IOrderService orderService,IMenuService menuService)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _restaurantId = restaurantId;
            _restaurantName = restaurantName;
            _minOrderValue = minOrderValue;
            _orderService=orderService;
            _menuService=menuService;
            _cartItems= new Dictionary<Guid, int>();

            lblRestaurantName.Text = $"Restaurant Name: {_restaurantName}";
            lblMinOrderValue.Text = $"Min Order: {_minOrderValue:C}";

            InitializeMenuDataGridView();
            InitializeCartDataGridView();
            PopulateDishTypeFilter();

            // Set initial numeric up-down values
            numQuantity.Minimum = 1;
            numQuantity.Maximum = 99; // Arbitrary max, will be limited by actual available quantity
            numQuantity.Value = 1;

            // Load menu items on form load
            this.Load += OrderForm_Load;
        }
        private readonly IMenuService _menuService;
        private async void OrderForm_Load(object sender, EventArgs e)
        {
            await LoadMenuItemsAsync(null, null); // Load all menu items initially
            UpdateOrderSummary();

        }
        private void InitializeMenuDataGridView()
        {
            dgvMenuItems.AutoGenerateColumns = false;
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colMId", HeaderText = "ID", DataPropertyName = "MId", Visible = false });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colDishName", HeaderText = "Dish", DataPropertyName = "DishName", Width = 200 });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colDishType", HeaderText = "Type", DataPropertyName = "DishType", Width = 80 });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colPrice", HeaderText = "Price", DataPropertyName = "Price", DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }, Width = 90 });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colUnits", HeaderText = "Units", DataPropertyName = "Units", Width = 80 });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colAvailableQuantity", HeaderText = "Available", DataPropertyName = "AvailableQuantity", Width = 80 });
        }

        private void InitializeCartDataGridView()
        {
            dgvCartItems.AutoGenerateColumns = false;
            dgvCartItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colCartMId", HeaderText = "ID", DataPropertyName = "MId", Visible = false });
            dgvCartItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colCartDishName", HeaderText = "Item", DataPropertyName = "DishName", Width = 150 });
            dgvCartItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colCartQuantity", HeaderText = "Qty", DataPropertyName = "Quantity", Width = 50 });
            dgvCartItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colCartUnitPrice", HeaderText = "Unit Price", DataPropertyName = "UnitPrice", DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }, Width = 90 });
            dgvCartItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colCartLineTotal", HeaderText = "Total", DataPropertyName = "LineTotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }, Width = 90 });
        }

        private void PopulateDishTypeFilter()
        {
            // Add "All" option first
            cmbDishType.Items.Add("All");
            foreach (var dt in Enum.GetValues(typeof(DishType)))
            {
                cmbDishType.Items.Add(dt.ToString());
            }
            cmbDishType.SelectedIndex = 0; // Select "All" by default
        }
        private async Task LoadMenuItemsAsync(DishType? dishType, string searchTerm)
        {
            try
            {
                //var restaurantId= _restaurantId; 
                //string searchTerm=txtMenuItemSearch.Text;
                var menuItems = await Program.MenuService.SearchMenuItemsAsync(_restaurantId, searchTerm);
                dgvMenuItems.DataSource = menuItems.ToList();
                if (!menuItems.Any())
                {
                    MessageBox.Show("No menu items found for this restaurant or matching your filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnFilterMenu_Click(object sender, EventArgs e)
        {
            DishType? filterDishType = null;
            if (cmbDishType.SelectedItem != null && cmbDishType.SelectedItem.ToString() != "All")
            {
                filterDishType = (DishType)Enum.Parse(typeof(DishType), cmbDishType.SelectedItem.ToString());
            }

            string searchTerm = txtMenuItemSearch.Text;

            await LoadMenuItemsAsync(filterDishType, searchTerm);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a menu item to add to cart.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvMenuItems.SelectedRows[0];
            Guid menuItemId = (Guid)selectedRow.Cells["colMId"].Value;
            string dishName = selectedRow.Cells["colDishName"].Value.ToString();
            decimal price = (decimal)selectedRow.Cells["colPrice"].Value;
            int availableQuantity = (int)selectedRow.Cells["colAvailableQuantity"].Value;
            int quantityToAdd = (int)numQuantity.Value;

            if (quantityToAdd <= 0)
            {
                MessageBox.Show("Quantity must be positive.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantityToAdd > availableQuantity)
            {
                MessageBox.Show($"Requested quantity ({quantityToAdd}) exceeds available quantity ({availableQuantity}) for '{dishName}'.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update cart logic
            if (_cartItems.ContainsKey(menuItemId))
            {
                _cartItems[menuItemId] += quantityToAdd;
            }
            else
            {
                _cartItems.Add(menuItemId, quantityToAdd);
            }

            // Update display list for DataGridView
            var existingCartItem = _cartDisplayList.FirstOrDefault(item => item.MId == menuItemId);
            if (existingCartItem != null)
            {
                existingCartItem.Quantity = _cartItems[menuItemId];
            }
            else
            {
                _cartDisplayList.Add(new CartLineItemDisplay { MId = menuItemId, DishName = dishName, Quantity = quantityToAdd, UnitPrice = price });
            }

            RefreshCartDisplay();
            UpdateOrderSummary();
            MessageBox.Show($"{quantityToAdd} x '{dishName}' added to cart.", "Cart Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCartItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item in your cart to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvCartItems.SelectedRows[0];
            Guid menuItemId = (Guid)selectedRow.Cells["colCartMId"].Value;
            string dishName = selectedRow.Cells["colCartDishName"].Value.ToString();

            if (_cartItems.ContainsKey(menuItemId))
            {
                _cartItems.Remove(menuItemId);
                _cartDisplayList.RemoveAll(item => item.MId == menuItemId);
                RefreshCartDisplay();
                UpdateOrderSummary();
                MessageBox.Show($"'{dishName}' removed from cart.", "Cart Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshCartDisplay()
        {
            dgvCartItems.DataSource = null; // Clear previous binding
            dgvCartItems.DataSource = _cartDisplayList; // Rebind to reflect changes
        }

        private void UpdateOrderSummary()
        {
            decimal subtotal = _cartDisplayList.Sum(item => item.LineTotal);
            lblSubtotal.Text = $"Subtotal: {subtotal:C}";
            lblDiscount.Text = "Discount: 0.00 C"; // Reset discount for recalculation
            lblTotalPrice.Text = $"Total Price: {subtotal:C}"; // Initial total is subtotal
        }

        private async void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            lblOrderMessage.Text = "";
            if (!_cartItems.Any())
            {
                lblOrderMessage.Text = "Your cart is empty. Please add items before placing an order.";
                return;
            }

            string couponCode = txtCouponCode.Text.Trim();

            try
            {
                var order = await Program.OrderService.PlaceOrderAsync(_currentUser.UId, _restaurantId, _cartItems, couponCode);
                lblOrderMessage.Text = $"Order placed successfully! Order ID: {order.OId}. Total: {order.TotalPrice:C}";

                // Clear cart after successful order
                _cartItems.Clear();
                _cartDisplayList.Clear();
                RefreshCartDisplay();
                UpdateOrderSummary();

                // Optionally, refresh menu items to reflect reduced quantities
                await LoadMenuItemsAsync(null, null);

                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close order form
            }
            catch (InvalidOperationException ex)
            {
                lblOrderMessage.Text = $"Order Error: {ex.Message}";
            }

        }
    }
}
          



