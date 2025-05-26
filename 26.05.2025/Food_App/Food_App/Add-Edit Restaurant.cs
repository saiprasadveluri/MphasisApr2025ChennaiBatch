using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_App.Entity;
using Food_App.Data;

namespace Food_App
{
    public partial class Add_Edit_Restaurant : Form
    {
        public Entity.Restaurant NewRestaurant { get; private set; }
        public Add_Edit_Restaurant()
        {
            InitializeComponent();
           // cmbOwners.DataSource = DataStorage.Users.Where(u => u.Role == "Owner").ToList();
            //cmbOwners.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
          string.IsNullOrWhiteSpace(txtLocation.Text) ||
          !decimal.TryParse(txtMinOrder.Text, out decimal minOrder))
            {
                MessageBox.Show("Please fill all fields correctly!");
                return;
            }

            NewRestaurant = new Restaurant
            {
                RId = DataStorage.Restaurants.Count + 1,
                Name = txtName.Text,
                Location = txtLocation.Text,
                MinOrderValue = minOrder,
                //Owner = (User)cmbOwners.SelectedItem
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

