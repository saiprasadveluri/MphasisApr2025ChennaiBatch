using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
