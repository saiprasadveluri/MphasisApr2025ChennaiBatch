using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDA
{
    public partial class NewUser : Form
    {
        public DataProvider _dataProvider;
        public NewUser(DataProvider dataProvider)
        {
            _dataProvider  = dataProvider;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserId.Text)||
                string.IsNullOrEmpty(txtUserName.Text)
                || string.IsNullOrEmpty(txtUserEmail.Text)
                || string.IsNullOrEmpty(txtUserPassword.Text)
                || string.IsNullOrEmpty(comboBoxRole.Text))
            {
                MessageBox.Show("enter users details");
            }
            else
            {
                Users users = new Users();
                users.UsersId = int.Parse(txtUserId.Text);
                users.UserName = txtUserName.Text;
                users.UserEmail = txtUserEmail.Text;
                users.UserPassword = txtUserPassword.Text;
                users.Role = comboBoxRole.Text;
                _dataProvider.AddUser(users);
                MessageBox.Show("users added successfully");
                DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
