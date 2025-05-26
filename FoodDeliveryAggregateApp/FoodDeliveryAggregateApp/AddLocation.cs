
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDeliveryAggregateApp;

namespace FoodDeliveryAggregateApp
{
    public partial class AddLocation : Form
    {
    
        public DataProvider _dataProvider;
        public AddLocation(DataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textLocationId.Text) || string.IsNullOrEmpty(textLocationName.Text))
            {
                MessageBox.Show("enter location details");
            }
            else
            {
                Location loc = new Location();
                loc.LocationId = int.Parse(textLocationId.Text);
                loc.LocationName = textLocationName.Text;
                _dataProvider.AddLocation(loc);
                MessageBox.Show("location added successfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
