using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodApp2.Classes;

namespace FoodApp2
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
            if (string.IsNullOrEmpty(textLocationId.Text) || string.IsNullOrEmpty(textLocationName.Text))
            {
                MessageBox.Show("enter location details");
            }
            else
            {
                Locations loc = new Locations();
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
