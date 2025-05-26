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
    public partial class AddRestaurant : Form
    {
        private DataProviders _dataProviders;
        public AddRestaurant(DataProviders dataProviders)
        {
            InitializeComponent();
            _dataProviders = dataProviders;
        }

        private void RestId_Click(object sender, EventArgs e)
        {

        }

        private void RestIdtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RestSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RestIdtxt.Text) || string.IsNullOrEmpty(RestNmaetxt.Text) || string.IsNullOrEmpty(Restlocationtxt.Text))
            {
                MessageBox.Show("please enter details");
                return;
            }
            Restaurant newrestaurant = new Restaurant();

            newrestaurant.RestaurantId= int.Parse(RestIdtxt.Text);
            newrestaurant.RestaurantName= RestNmaetxt.Text;
            newrestaurant.Location= Restlocationtxt.Text;
            newrestaurant.MinimumOrderValue = int.Parse(RestMinimumValuetxt.Text);
            newrestaurant.OwnerId= int.Parse(RestOwnerIdtxt.Text);
            _dataProviders.AddRestaurant(newrestaurant);
            _dataProviders.SaveData();
            MessageBox.Show("Restaurant added successfully!");
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
