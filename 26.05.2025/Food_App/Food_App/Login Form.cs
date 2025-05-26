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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = DataStorage.Users.FirstOrDefault(u =>
u.Email == txtEmail.Text && u.Password == txtPassword.Text);

            if (user != null)
            {
                this.Hide();
                switch (user.Role)
                {
                    case "Admin":
                        new AdminDashboard().Show();
                        break;
                    case "Owner":
                        new OwnerDashboard(user).Show();
                        break;
                    default:
                        new CustomerDashboard(user).Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }
    }
}
