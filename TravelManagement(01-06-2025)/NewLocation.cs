using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelManagement.Classes;

namespace TravelManagement
{
    public partial class NewLocation : Form
    {
        public DataAccess dataAccess;
        public NewLocation()
        {
            dataAccess = DataAccess.DataAccessInstance;
            InitializeComponent();
        }

        private void SaveLocationButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textLocationName.Text))
            {
                string locname = textLocationName.Text;
                dataAccess.AddLocation(locname);

                var LocLists = dataAccess.GetAllLocations();
                gridLocation.DataSource = LocLists;
            }
        }

        private void NewLocation_Load(object sender, EventArgs e)
        {
            var LocList = dataAccess.GetAllLocations();
            gridLocation.DataSource = LocList;
            gridLocation.Refresh();
        }
    }
}
