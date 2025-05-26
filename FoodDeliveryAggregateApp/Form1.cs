using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodDeliveryAggregateApp
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string email = Emailtxt.Text;
            string Password = Passwordtxt.Text;
            
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please give credentials");
                return;
            }

            //this.Visible = false;
            //AdminDashBoard adminDashboard = new AdminDashBoard();
            //adminDashboard.ShowDialog();
            //this.Visible = true;
            DataProviders dataProviders = DataProviders.Instance;
            User loggedInUser = dataProviders.User.FirstOrDefault(u => u.Email == email && u.Password == Password);

            string Roletxt = Rolecomb.SelectedItem?.ToString() ?? string.Empty;



            if (Roletxt=="Admin")
            {
                this.Visible = false;
                AdminDashBoard adminDashboard = new AdminDashBoard();
                adminDashboard.ShowDialog();
                this.Visible = true;

            }
         
            else if (Roletxt=="Customer")
            {
                this.Visible = false;
                CustomerDashboard customerDashboard = new CustomerDashboard(loggedInUser);
                customerDashboard.ShowDialog();
                this.Visible = true;
            }
            else if (Roletxt == "Owner")
            {
                this.Visible = false;
                OwnerDashboard ownerDashboard = new OwnerDashboard();
                
                this.Visible = true;
            }

        }

        private void Roletxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
