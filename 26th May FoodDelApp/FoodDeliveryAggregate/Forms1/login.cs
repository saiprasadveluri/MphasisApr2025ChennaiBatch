using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Users> users = new List<Users>();
            users.Add(new Users()
            {
                Id = 101,
                Username="Trinay",
                Email="tri@t.com",
                Password="3411024",
                Role="ADMIN"
            });
            users.Add(new Users()
            {
                Id = 102,
                Username = "hi",
                Email = "ily@ily.com",
                Password = "242424",
                Role = "OWNER"
            });
            users.Add(new Users()
            {
                Id = 103,
                Username = "Shakit",
                Email = "s@s.com",
                Password = "123456",
                Role = "USER"
            });
            users.Add(new Users()
            {
                Id = 104,
                Username = "S",
                Email = "sh@s.com",
                Password = "112233",
                Role = "USER"
            });
            users.Add(new Users()
            {
                Id = 105,
                Username = "p",
                Email = "p@p.com",
                Password = "pp112233",
                Role = "USER"
            });
            string useremail = Emailid.Text;
            string userpass=password.Text;
            string Role=Roles.SelectedItem.ToString();
            foreach (var u in users)
            {
                if (useremail.Contains(u.Email))
                {
                    if (u.Email == useremail && u.Password == userpass)
                    {
                        if (u.Role == Role && u.Role == "USER")
                        {
                            UserDashboard user = new UserDashboard();
                            DialogResult = user.ShowDialog();
                            break;

                        }
                        else if (u.Role == Role && u.Role == "ADMIN")
                        {
                            AdminDashboard admin = new AdminDashboard();
                            DialogResult = admin.ShowDialog();
                            break;
                        }
                        else if (u.Role == Role && u.Role == "OWNER")
                        {
                            OwnerDashboard owner = new OwnerDashboard();
                            DialogResult = owner.ShowDialog();
                            break;
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                        break;
                    }
                }
            }
        }        
    }
}
