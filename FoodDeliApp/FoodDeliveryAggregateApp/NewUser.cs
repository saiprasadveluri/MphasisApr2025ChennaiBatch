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
    public partial class NewUser : Form
    {
        Dataprovider _dataprovider;
        public NewUser(Dataprovider dataprovider)
        {
            _dataprovider = dataprovider;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUserId.Text)
                || string.IsNullOrEmpty(textUserName.Text)
                || string.IsNullOrEmpty(textUserPassword.Text)
                || string.IsNullOrEmpty(textUserPassword.Text)
                || string.IsNullOrEmpty(RoleComboBox.Text))
            {
                MessageBox.Show("enter users details");
            }
            else
            {
                Users users = new Users();
                users.Id = int.Parse(textUserId.Text);
                users.Name = textUserName.Text;
                users.Email = textUserPassword.Text;
                users.Password = textUserPassword.Text;
                users.Role = RoleComboBox.Text;
                _dataprovider.AddUser(users);
                MessageBox.Show("users added successfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
    

