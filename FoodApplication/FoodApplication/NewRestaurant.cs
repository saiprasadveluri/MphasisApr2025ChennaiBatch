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
    public partial class NewRestaurant : Form
    {
        DataProvider dataProvider;
        public NewRestaurant(DataProvider _dataProvider)
        {
            InitializeComponent();
            dataProvider = _dataProvider;
        }

        private void NewRestaurant_Load(object sender, EventArgs e)
        {
            List<Locations> loc = dataProvider.GetAllLocations();
            RestLocationBox.DataSource = loc;
            RestLocationBox.DisplayMember = "LocationName";
        }

        private void SaveRestaurantButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textRestaurantName.Text)
                || string.IsNullOrEmpty(RestLocationBox.Text))
            {
                MessageBox.Show("enter Restaurant details");
            }
            else
            {
                Restaurant res = new Restaurant();
                res.RestaurantName = textRestaurantName.Text;
                dataProvider.AddRestaurant(res);
                MessageBox.Show("Restaurant added successfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
