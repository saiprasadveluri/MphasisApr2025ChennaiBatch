using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryWindowForms
{
    public partial class NewRestaurant : Form
    {
        private DataProvider _dataProvider;
        public NewRestaurant(DataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            InitializeComponent();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(RestId.Text) || string.IsNullOrEmpty
                    (RestName.Text))
            {
                MessageBox.Show("Enter Details");

            }
            else
            {
                FoodDeliveryWindowForms.Restaurant res = new FoodDeliveryWindowForms.Restaurant();
               
                res.RestaurantName = RestName.Text;
               
               

                _dataProvider.AddRestaurant(res);
               
                MessageBox.Show("Location Added Successfully");
                DialogResult = DialogResult.OK;
                this.Close();

            }
        }


    }
}

