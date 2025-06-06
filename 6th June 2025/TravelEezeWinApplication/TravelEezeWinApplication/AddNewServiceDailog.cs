using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEezeWinApplication
{
    public partial class AddNewServiceDailog : Form
    {
        public AddNewServiceDailog()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewServiceDailog_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> Location = dataAccess.GetAllLocations();
            Location[] locationArr = new Location[Location.Count];
            Location.ToArray().CopyTo(locationArr, 0);
            comboDestinationLoc.DataSource = Location;
            comboDestinationLoc.DisplayMember = "LocationName";

            List<Location> DestLocations = locationArr.ToList();
            comboSourceLoc.DataSource = DestLocations;
            comboSourceLoc.DisplayMember = "LocationName";
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            comboServiceType.DataSource = srvTypes;
            comboServiceType.DisplayMember = "ServiceTypeName";

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Location srLoc = comboServiceType.SelectedItem as Location;
                Location destLoc = comboDestinationLoc.SelectedItem as Location;
                ServiceType srvType = comboServiceType.SelectedItem as ServiceType;
                if(srLoc != null && destLoc != null)
                {
                    long SrcId = srLoc.LocationId;
                    long DestId = destLoc.LocationId;
                    long SrvTypeId = srvType.STypeId;
                    decimal Dist = numericDistance.Value;
                    if(SrcId != DestId)
                    {
                        DataAccess dataAccess = new DataAccess();
                        bool Status = dataAccess.AddNewService(SrcId, DestId, SrvTypeId, (double)Dist);
                        if (Status)
                        {
                            MessageBox.Show("Success in the adding service");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add service");
                        }
                    }

                }
            }
            catch(Exception ex)
            {


            }
        }
    }
}
