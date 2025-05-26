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
    public partial class AddRestaurantForm : Form
    {
        public AddRestaurantForm()
        {
            InitializeComponent();
            this.Load += AddRestaurantForm_Load;
        }

        private async void AddRestaurantForm_Load(object sender, EventArgs e)
        {
            await PopulateOwnersComboBox();
            numMinOrderValue.Minimum = 0;
            numMinOrderValue.DecimalPlaces = 2;
        }
        private async Task PopulateOwnersComboBox()
        {
            try
            {
               
                var ownerUsers = (await Program.AuthService.LoginAsync("admin@example.com", "adminpass")).Role == UserRole.Admin ?
                                 (await Program.AuthService.LoginAsync("owner1@example.com", "owner1pass")).Role == UserRole.RestaurantOwner ?
                                 
                                   null 
                                 : null : null;
                var seededOwners = DataAccess.InMemoryDatabase.Users
                                            .Where(u => u.Role == UserRole.RestaurantOwner)
                                            .ToList();

                if (seededOwners.Any())
                {
                    cmbOwner.DataSource = seededOwners;
                    cmbOwner.DisplayMember = "DisplayName";
                    cmbOwner.ValueMember = "UId";          
                }
                else
                {
                    MessageBox.Show("No restaurant owner users found. Please register an owner first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAddRestaurant.Enabled = false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading owners: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddRestaurant.Enabled = false;
            }
        }

        private async void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            string name = txtRName.Text.Trim();
            string location = txtRLocation.Text.Trim();
            decimal minOrderValue = numMinOrderValue.Value;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(location))
            {
                lblMessage.Text = "Restaurant name and location are required.";
                return;
            }

            if (cmbOwner.SelectedItem == null)
            {
                lblMessage.Text = "Please select an owner for the restaurant.";
                return;
            }

            Guid ownerUId = (Guid)cmbOwner.SelectedValue;

            try
            {
                await Program.RestaurantService.AddRestaurantAsync(name, location, minOrderValue, ownerUId);
                lblMessage.Text = $"Restaurant '{name}' added successfully!";
                // Clear fields for new entry
                txtRName.Clear();
                txtRLocation.Clear();
                numMinOrderValue.Value = numMinOrderValue.Minimum;
                cmbOwner.SelectedIndex = 0; // Reset
            }
            catch (ArgumentException ex)
            {
                lblMessage.Text = $"Input Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"An unexpected error occurred: {ex.Message}";
            }
        }
    }
}
