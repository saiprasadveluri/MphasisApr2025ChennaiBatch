using System;
using System.Windows.Forms;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click; 
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button click working!");

            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
            {
                MessageBox.Show("Login successful! Opening admin dashboard...");
                new AdminDashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "owner" && txtPassword.Text == "owner123")
            {
                
                MessageBox.Show("Login successful! Opening owner dashboard...");
                new OwnerDashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "customer" && txtPassword.Text == "customer123")
            {
                
                MessageBox.Show("Login successful! Opening customer dashboard...");
                new CustomerDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}