using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEzeeDataAccessLayer.Migrations;

namespace TravelEzzCoreConsole2
{
    public partial class AddLocation : Form
    {
        DataAccess datAccess ;
        public AddLocation()
        {
            datAccess = new DataAccess();
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            //Get Available Max Id and Add Location to DB
            long NextLocationId = 1;
            var locationList = datAccess.GetAllLocations();
            if(locationList.Count > 0)
            {
                long AvailableMaxId = locationList.Max(l => l.LocationId);
                NextLocationId = AvailableMaxId + 1;
            }
            string locName = txtLocationName.Text;
                string locDescr = txtDescription.Text;
            bool Status = datAccess.AddLocation(NextLocationId, locName, locDescr);
            if(Status)
            {
                MessageBox.Show("Success in Adding new Location");
            }
            else
            {
                MessageBox.Show("Error in Adding new Location");

            }

        }
    }
}
