using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryWindowForms
{
    public partial class AddLocations : Form
    {
        public DataProvider _dataProvider;
        public AddLocations(DataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LocationId.Text) || string.IsNullOrEmpty(LocationName.Text))
            {
                MessageBox.Show("enter location details");
            }
            else
            {
                Locations loc = new Locations();
                loc.LocationId = int.Parse(LocationId.Text);
                loc.LocationName =LocationName.Text;
                _dataProvider.AddLocation(loc);
                MessageBox.Show("location added successfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}



//        DataProvider _dataProvider;

//        public AddLocations(DataProvider dataProvider)
//        {
//            InitializeComponent();
//            _dataProvider = dataProvider;
//        }

//        private void btnAddLocations_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(LocId.Text) || string.IsNullOrEmpty
//                    (LocName.Text))
//            {
//                MessageBox.Show("Enter Details");

//            }
//            else
//            {
//                FoodDeliveryWindowForms.Locations loc = new FoodDeliveryWindowForms.Locations();
//                loc.LocationId = int.Parse(LocId.Text);
//                loc.LocationName = LocName.Text;

//                _dataProvider.NewLocations(loc);
//                _dataProvider.SaveData();
//                MessageBox.Show("Location Added Successfully");
//                DialogResult = DialogResult.OK;
//                this.Close();

//            }
//        }

//        private void LocId_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
