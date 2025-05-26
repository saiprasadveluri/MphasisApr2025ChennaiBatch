
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
    public partial class NewLocation : Form
    {
        public DataProvider _dataProvider;
        public NewLocation(DataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textId.Text) || string.IsNullOrEmpty(textRestName.Text))
            {
                MessageBox.Show("enter location details");
            }
            else
            {
                Location loc = new Location();
                loc.LocationId = int.Parse(textId.Text);
                loc.LocationName = textRestName.Text;
                _dataProvider.AddLocation(loc);
                MessageBox.Show("location added successfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
