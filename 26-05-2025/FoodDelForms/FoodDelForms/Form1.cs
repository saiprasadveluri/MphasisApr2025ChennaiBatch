using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDelForms.Lists;

namespace FoodDelForms
{
    public partial class Form1 : Form
    {
        DataProvider _dataProvider;
        public Form1()
        {
            InitializeComponent();
            _dataProvider = DataProvider.Instance;
            _dataProvider.LoadData();
        }
        

        private void Login_Click(object sender, EventArgs e)
        {
            string email = EmailId.Text;
            string password = Password.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter the credentials");
                return;
            }
            if(_dataProvider.Verify(email, password))
            {
                this.Visible = false;
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.ShowDialog();
                this.Visible = true;
            }
        }
       
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataProvider.Instance.SaveToFile();
        }

       
    }
}
