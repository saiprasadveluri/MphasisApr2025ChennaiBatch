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
    public partial class NewUser : Form
    {
        DataProvider dataProvider;
        public NewUser(DataProvider data)
        {
            dataProvider = data;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DisplayName.Text) ||
                string.IsNullOrEmpty(Email.Text)||
                string.IsNullOrEmpty(Password.Text)||
                string.IsNullOrEmpty(Role.Text))
            {
                MessageBox.Show("enter details");
            }
            else
            {
                Users us = new Users();
                us.DisplayName = DisplayName.Text;
                us.Email = Email.Text;
                us.Password = Password.Text;
                us.Role = Role.Text;
                DataProvider.Instance.AddUser(us);
                DataProvider.Instance.SaveToFile();
                MessageBox.Show("User Added");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
