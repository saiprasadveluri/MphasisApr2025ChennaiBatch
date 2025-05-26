
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FoodDeliveryAggregateApp
{
    public partial class LoginForm : Form
    {
        DataProvider _dataProvider;
        public LoginForm()
        {
            InitializeComponent();
            _dataProvider = DataProvider.instance;
            _dataProvider.LoadData();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string pass1 = textPassword.Text;
            if (_dataProvider.Verify(email, pass1))
            {
                this.Visible = false;
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
