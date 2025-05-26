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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SeedUsers();
        }

        private void SeedUsers()
        {
            if (DataStore.Users.Count == 0)
            {
                DataStore.Users.Add(new User { Id = 1, DisplayName = "Admin One", Email = "admin@test.com", Password = "admin123", Role = "Admin", Location = "Mumbai" });
                DataStore.Users.Add(new User { Id = 2, DisplayName = "Owner One", Email = "owner@test.com", Password = "owner123", Role = "Owner", Location = "Delhi" });
                DataStore.Users.Add(new User { Id = 3, DisplayName = "User One", Email = "user@test.com", Password = "user123", Role = "Customer", Location = "Bangalore" });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            var user = DataStore.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                MessageBox.Show($"Welcome {user.DisplayName} ({user.Role})");

                // Navigate to role-based form
                if (user.Role == "Admin") new AdminDashboardForm(user).Show();
                else if (user.Role == "Owner") new OwnerDashboardForm(user).Show();
                else new CustomerDashboardForm(user).Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
