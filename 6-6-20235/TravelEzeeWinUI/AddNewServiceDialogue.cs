using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEzeeDataAccessLayer.Data;

namespace TravelEzeeWinUI
{
    public partial class AddNewServiceDialogue : Form
    {
        public AddNewServiceDialogue()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void AddNewServiceDialogue_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> srcloc = dataAccess.GetAllLocations();

            Location[] locArray = new Location[srcloc.Count];
            srcloc.ToArray().CopyTo(locArray, 0);
            
            destcombo.DataSource = srcloc;
            destcombo.DisplayMember = "LocationName";

            List<Location> dstloc = locArray.ToList();
            sourcecombo.DataSource = dstloc;
            sourcecombo.DisplayMember = "LocationName";

            List<ServiceType> srvType = dataAccess.GetAllServiceTypes();
            srvtypecombo.DataSource = srvType;
            srvtypecombo.DataSource = "ServiceTypeName";
            //List<ServiceEntry> srclist=dataAccess.GetAllServicesView();
            
        }
        private void btnaddservice_Click(object sender, EventArgs e)
        {
            try
            {
                Location srLoc = sourcecombo.SelectedItem as Location;
                Location destLoc = destcombo.SelectedItem as Location;
                ServiceType servtype = srvtypecombo.SelectedItem as ServiceType;
                if (srLoc != null && destLoc != null)
                {

                    long srcid = srLoc.LocationId;
                    long destid = destLoc.LocationId;
                    long srvtypeid = servtype.STypeId;
                    decimal dist = distanceDropdown.Value;
                    if (srcid != destid)
                    {
                        DataAccess dataAccess = new DataAccess();
                        bool status = dataAccess.AddService(srvtypeid, srcid, destid, (double)dist);
                        if (status)
                        {
                            MessageBox.Show("Success in the Adding service");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add service");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
