using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using.System.Forms;


namespace Food_Del_Apps
{
    public partial class LoginForms : Form
    {
        public LoginForms()
        {
            InitializeComponent();
            txtEmail.Text = "user1@email.com";
            txtPassword.Text = "user1Pass";
        }


        private void LoginForms_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            string email=txtEmail.Text;
            string password=txtPassword.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Please Enter both email and password...";
                return;
            }
            try
            {
                User loggedInUser = await Program.AuthService.LoginAsync(email, password);
                if (loggedInUser != null)
                {
                    lblMessage.Text = "lOGIN SUCCESSFULL!";
                    this.Hide();

                    MainDashboardForm dashboard = new MainDashboardForm(loggedInUser);
                    dashboard.FormClosed += (s, args) => this.Close();
                    dashboard.Show();
                }
                else
                {
                    lblMessage.Text = "Login Failed. Invalid email or password....";
                }
            }
            catch (UnauthorizedAccessException ex) 
            {
                lblMessage.Text = $"Login Error:{ex.Message}";

            }
            catch(Exception ex) 
            {
                lblMessage.Text = $"An unexpected error occured: {ex.Message}";

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterFormcs registerForms = new RegisterFormcs();
            registerForms.ShowDialog();
        }
    }
}
