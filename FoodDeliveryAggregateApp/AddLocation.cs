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
    public partial class AddLocation : Form
    {
        public DataProviders _dataProvider;

        public AddLocation(DataProviders dataProvider)
        {
            _dataProvider = dataProvider;
            InitializeComponent();
        }

        private void AddLocation_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Locationidtxt.Text) || string.IsNullOrEmpty(LocationNmaetxt.Text))
            {
                MessageBox.Show("enter location details");
            }
            else
            {
                Location loc = new Location();
                loc.LocationId = int.Parse(Locationidtxt.Text);
                loc.Name = LocationNmaetxt.Text;
                _dataProvider.AddLocation(loc);
                MessageBox.Show("location added successfully");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
