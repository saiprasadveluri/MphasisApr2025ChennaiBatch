using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryWindowForms
{
    public partial class Form1 : Form

    {
        DataProvider dataProvider;
        public Form1()
        {
            InitializeComponent();
            dataProvider = DataProvider.Instance;
            dataProvider.LoadData();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string pass1 = Password.Text;
            if (dataProvider.Verify(email, pass1))
            {
                this.Visible = false;
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.ShowDialog();
                this.Visible = true;
            }
            else
            {
                this.Visible = false;
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.ShowDialog();
                this.Visible = true;
            }
        }
    }
}


        

     
      
