using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEzeeDataAccessLayer;

namespace TravelEzeeWinUI
{
    public partial class AddLocationDialog : Form
    {
        private DataAccess dataAccess;
        public AddLocationDialog()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }


        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            //Get Available Max Id.
            long NextLocationId = 1;
            var locationList = dataAccess.GetAllLocations();
            if (locationList.Count > 0)
            {
                long AvailableMaxId = locationList.Max(loc => loc.LocationId);
                NextLocationId = AvailableMaxId + 1;
            }
            string locName = txtlocationName.Text.Trim();
            string locDescr = txtdescription.Text.Trim();

            //bool Status = dataAccess.AddLocation(NextLocationId, locName, locDescr);
            bool Status = dataAccess.AddLocation((int)NextLocationId, locName, locDescr);

            if (Status)
            {
                MessageBox.Show("success in Adding new Location");
            }
            else
            {
                MessageBox.Show("Error in Adding new Location");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
