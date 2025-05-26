using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDelForms.Lists;

namespace FoodDelForms
{
    public partial class NewLocation : Form
    {
        DataProvider dataProvider;
        public NewLocation(DataProvider data)
        {
            InitializeComponent();
            dataProvider = data;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LocationName.Text) || string.IsNullOrEmpty(LocationId.Text))
            {
                MessageBox.Show("enter details");
            }
            else
            {
                Location loc = new Location();
                loc.LocationId = int.Parse(LocationId.Text);
                loc.LocationName = LocationName.Text;
                DataProvider.Instance.AddLocation(loc);
                DataProvider.Instance.SaveToFile();
                MessageBox.Show("Location Added");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
