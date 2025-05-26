using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FoodDeliveryAggregateApp
{
    public partial class AddUser : Form
    {
        private DataProviders _dataProviders;
        public AddUser(DataProviders dataProviders)
        {
            InitializeComponent();
            _dataProviders = dataProviders;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDtxt.Text) || string.IsNullOrEmpty(Nametxt.Text) || string.IsNullOrEmpty(Emailtxt.Text) || string.IsNullOrEmpty(Passwordtxt.Text))
            {
                MessageBox.Show("please enter details");
                return;
            }

            User newuser = new User();
            newuser.Id=int.Parse(IDtxt.Text);
            newuser.Name=Nametxt.Text;
            newuser.Email=Emailtxt.Text;
            newuser.Password=Passwordtxt.Text;
            _dataProviders.AddUser(newuser);
            MessageBox.Show("User added successfully!");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
