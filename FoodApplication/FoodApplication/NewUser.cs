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
    public partial class NewUser : Form
    {
        public DataProvider _dataProvider;
        public NewUser(DataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            InitializeComponent();
        }

        private void SaveUsersButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUserId.Text)
                || string.IsNullOrEmpty(textUserName.Text)
                || string.IsNullOrEmpty(textUserEmail.Text)
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
                users.Email = textUserEmail.Text;
                users.Password = textUserPassword.Text;
                users.Role = RoleComboBox.Text;
                _dataProvider.AddUser(users);
                MessageBox.Show("users added successfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
