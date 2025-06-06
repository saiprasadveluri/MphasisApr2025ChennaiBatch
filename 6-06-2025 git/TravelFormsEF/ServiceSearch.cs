using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelFormsEF
{
    public partial class ServiceSearch : Form
    {
        public ServiceSearch()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();

            Location[] locs = new Location[locations.Count];
            locations.ToArray().CopyTo(locs, 0);

            cmbSrcS.DataSource = locations;
            cmbSrcS.DisplayMember = "LocationName";

            List<Location> locations1 = locs.ToList();
            cmbDesS.DataSource = locations1;
            cmbDesS.DisplayMember = "LocationName";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Location srcLoc = cmbSrcS.SelectedItem as Location;
            Location destLoc = cmbDesS.SelectedItem as Location;
            if(srcLoc != null && destLoc != null)
            {
                string SrcId = srcLoc.LocationName;
                string DestId = destLoc.LocationName;
                if (SrcId != DestId)
                {
                    DataAccess dataAccess = new DataAccess();
                    List<Service> ser = dataAccess.GetServicesBasedOnLocation(srcLoc, destLoc);
                    GridSearch.DataSource = ser;
                }
               
            }
            else
            {
                MessageBox.Show("No Services");
            }
           
        }
    }
}
