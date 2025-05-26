using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDA
{
    public partial class NewRestaurant : Form
    {
        public DataProvider _dataProvider;
        public NewRestaurant(DataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRestId.Text)
                || string.IsNullOrEmpty(txtRestName.Text)
                || string.IsNullOrEmpty(txtLocation.Text)
                || string.IsNullOrEmpty(txtMinOrderVal.Text)
                )
            {
                MessageBox.Show("enter restaurant details");
            }
            else
            {
                Restaurant rest = new Restaurant();
                rest.RestId = int.Parse(txtRestId.Text);
                rest.RestName = txtRestName.Text;
                rest.Location = int.Parse(txtLocation.Text);
                rest.MinOrderVal = int.Parse(txtMinOrderVal.Text);
                _dataProvider.AddRestaurant(rest);
                MessageBox.Show("Restaurant added successfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
