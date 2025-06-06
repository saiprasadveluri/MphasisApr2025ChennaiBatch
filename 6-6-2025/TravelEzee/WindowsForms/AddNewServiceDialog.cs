using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeWinFormUI
{
    public partial class AddNewServiceDialog : Form
    {
        public AddNewServiceDialog()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddNewServiceDialog_Load(object sender, EventArgs e)
        {

            DataAccess dataAccess = new DataAccess();
            List<Location> SrcLocation = dataAccess.GetAllLocations();
            List<Location> destLocation = dataAccess.GetAllLocations();
            cmbSourceLocation.DataSource = SrcLocation;
            cmbSourceLocation.DisplayMember = "LocationName";

            List<ServiceType> SrvTypes = dataAccess.GetAllServiceType();
            cmbServicetype.DataSource = SrvTypes;
            cmbServicetype.DisplayMember = "ServiceTypeName";

            cmbDestinationLocations.DataSource = destLocation;
            cmbDestinationLocations.DisplayMember = "LocationName";



        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            Location srLoc = cmbSourceLocation.SelectedItem as Location;
            Location DestLoc = cmbDestinationLocations.SelectedItem as Location;
            ServiceType srvType = cmbServicetype.SelectedItem as ServiceType;
            if (srLoc != null && DestLoc != null && srvType != null)
            {

            }
        }
    }
}
