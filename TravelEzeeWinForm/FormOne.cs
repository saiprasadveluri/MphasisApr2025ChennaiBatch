using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email=txtEmail.Text;
            string Password=txtPassword.Text;
            if (string.IsNullOrEmpty(email)|| string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter credentials.");
                return;
            }
            this.Visible = false;
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}