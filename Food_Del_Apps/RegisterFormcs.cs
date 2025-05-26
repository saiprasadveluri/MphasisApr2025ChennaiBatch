using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyRestaurantApp.Core;
using MyRestaurantApp.Core.Models;
using MyRestaurantApp.DataAccess;

namespace Food_Del_Apps
{
    public partial class RegisterFormcs : Form
    {
        public RegisterFormcs()
        {
            InitializeComponent();
            PopulateRolesComboBox();
        }
        private void PopulateRolesComboBox()
        {
            cmbRole.DataSource = Enum.GetValues(typeof(UserRole));
            cmbRole.SelectedIndex = 0; // Default to AppUser
        }
        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            string displayName = txtDisplayName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string location = txtLocation.Text;
            UserRole selectedRole = (UserRole)cmbRole.SelectedItem;

            if (string.IsNullOrWhiteSpace(displayName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(location))
            {
                lblMessage.Text = "All fields are required.";
                return;
            }

            try
            {
                User newUser = await Program.AuthService.RegisterUserAsync(displayName, email, password, selectedRole, location);
                lblMessage.Text = $"Registration successful for {newUser.DisplayName}!";
                this.Close(); // Close the registration form
            }
            catch (InvalidOperationException ex)
            {
                lblMessage.Text = $"Registration Error: {ex.Message}";
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

        private void RegisterFormcs_Load(object sender, EventArgs e)
        {

        }
    }
}
        