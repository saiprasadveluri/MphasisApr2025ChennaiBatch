using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Del_Apps
{
    public partial class MenuManagementForm : Form
    {
        private Guid _restaurantId;
        private string _restaurantName;

        public MenuManagementForm(Guid restaurantId, string restaurantName)
        {
            InitializeComponent();
            _restaurantId = restaurantId;
            _restaurantName = restaurantName;
            lblRestaurantName.Text = $"Managing Menu for: {_restaurantName}";

            InitializeDataGridView();
            this.Load += MenuManagementForm_Load;
        }

        private void InitializeDataGridView()
        {
            dgvMenuItems.AutoGenerateColumns = false;
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colMId", HeaderText = "ID", DataPropertyName = "MId", Visible = false });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colDishName", HeaderText = "Dish", DataPropertyName = "DishName", Width = 200 });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colDishType", HeaderText = "Type", DataPropertyName = "DishType", Width = 80 });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colPrice", HeaderText = "Price", DataPropertyName = "Price", DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }, Width = 90 });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colUnits", HeaderText = "Units", DataPropertyName = "Units", Width = 80 });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn() { Name = "colAvailableQuantity", HeaderText = "Available", DataPropertyName = "AvailableQuantity", Width = 80 });
        }

        private async void MenuManagementForm_Load(object sender, EventArgs e)
        {
            await LoadMenuItemsAsync();
        }

        private async Task LoadMenuItemsAsync()
        {
            lblMessage.Text = "";
            try
            {
                var menuItems = await Program.MenuService.GetMenuItemsByRestaurantAsync(_restaurantId);
                dgvMenuItems.DataSource = menuItems.ToList();
                if (!menuItems.Any())
                {
                    lblMessage.Text = "No menu items found for this restaurant.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error loading menu items: {ex.Message}";
            }
        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            AddMenuItemForm addMenuItemForm = new AddMenuItemForm();
            addMenuItemForm.FormClosed += async (s, args) => await LoadMenuItemsAsync(); 
            addMenuItemForm.ShowDialog();
        }

        private async void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a menu item to update its quantity.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvMenuItems.SelectedRows[0];
            Guid menuItemId = (Guid)selectedRow.Cells["colMId"].Value;
            string dishName = selectedRow.Cells["colDishName"].Value.ToString();
            int currentQuantity = (int)selectedRow.Cells["colAvailableQuantity"].Value;

            string input = Microsoft.VisualBasic.Interaction.InputBox($"Enter new quantity for '{dishName}':", "Update Quantity", currentQuantity.ToString());

            if (int.TryParse(input, out int newQuantity))
            {
                try
                {
                    var menuItemToUpdate = await Program.MenuService.GetMenuItemByIdAsync(selectedMenuItemId);
                    if (menuItemToUpdate != null)
                    {
                        menuItemToUpdate.AvailableQuantity = newQuantity;
                        await Program.MenuService.UpdateMenuItemAsync(menuItemToUpdate);
                        MessageBox.Show("MENU ITEM QUANTITY UPDATED SUCCESSFULLY!");
                        await LoadMenuItemsAsync();
                    }
                    //await Program.MenuService.UpdateMenuItemQuantityAsync(menuItemId, newQuantity);
                    //MessageBox.Show($"Quantity for '{dishName}' updated to {newQuantity}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //await LoadMenuItemsAsync(); 
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Validation Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (KeyNotFoundException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(input)) 
            {
                MessageBox.Show("Invalid quantity entered. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

    }
}
