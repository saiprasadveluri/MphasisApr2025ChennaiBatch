using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzeeTravelWinUI
{
    public partial class AddLocationDialog : Form
    {
        DataAccess dataAccess;
        public AddLocationDialog()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            // Get Available Max Id
            long NextLocationId = 1;
           var locationList = dataAccess.GetAllLocations();
            if (locationList.Count > 0)
            {
                long AvailableMaxId = locationList.Max(l => l.LocationId);
                NextLocationId = AvailableMaxId + 1;
            }
            string locName = txtLocationName.Text;
            string locDescr = txtDescription.Text;
            bool status = dataAccess.AddLocation(NextLocationId, locName, locDescr);
            if (status)
            {
                MessageBox.Show("Suceess in Adding new Location");
            }
            else

            {
                MessageBox.Show("Error in Adding New Location");
            }
        }
    }
}
