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
using System.Xml.Linq;

namespace FoodDeliveryAggregateApp
{
    public partial class AddRestaurant : Form
    {
        private Dataprovider dataprovider;
        public AddRestaurant(Dataprovider dataProvider)
        {
            dataprovider = dataProvider;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ResId.Text) || string.IsNullOrEmpty(ResName.Text)
                
                || string.IsNullOrEmpty(Loc.Text) || string.IsNullOrEmpty(Minorder.Text))
            {
                MessageBox.Show("Enter Details");
            }
            else
            {
                Restuarant res = new Restuarant();

                //res.Id = int.Parse(ResId.Text);
                res.RestaurantName = ResName.Text;
                //res.RestLocation = Loc.Text;
                //res.MinimumOrderValue = double.Parse(Minorder.Text);
                dataprovider.AddRestaurant(res);
               
                MessageBox.Show("res added succesfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
