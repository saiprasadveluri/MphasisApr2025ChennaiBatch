using System;
using System.Windows.Forms;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            cmbRole.DataSource = Enum.GetValues(typeof(UserRole));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Registration successful! Please login with your credentials.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}