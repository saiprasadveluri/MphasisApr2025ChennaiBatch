using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzzCoreConsole2
{
    public partial class Add_New_Service : Form
    {
        public Add_New_Service()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Add_New_Service_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> Location = dataAccess.GetAllLocations();
            Location[] locationsArr=new Location[Location.Count];
            Location.ToArray().CopyTo(locationsArr, 0);

            cmbDestinationLoaction.DataSource = Location;
            cmbDestinationLoaction.DisplayMember = "LocationName";

            List<Location> DestLocations = locationsArr.ToList();
            cmbSourceLocation.DataSource = DestLocations;
            cmbSourceLocation.DisplayMember = "LocationName";

            List<ServiceType> SrvTypes = dataAccess.GetAllServiceTypes();
            cmbSrvType.DataSource = SrvTypes;
            cmbSrvType.DisplayMember = "ServiceTypeName";

        }

        private void btnaddservice_Click(object sender, EventArgs e)
        {
            try
            {
                Location srLoc = cmbSourceLocation.SelectedItem as Location;
                Location destLoc = cmbDestinationLoaction.SelectedItem as Location;
                ServiceType srvType = cmbSrvType.SelectedItem as ServiceType;
                if (srLoc != null && destLoc != null)
                {
                    long SrcId = srLoc.LocationId;
                    long DestId = destLoc.LocationId;
                    long srvTypeId = srvType.StypeId;
                    decimal Dist = numDistance.Value;
                    if (SrcId != DestId)
                    {
                        DataAccess dataAccess = new DataAccess();
                        bool Status = dataAccess.AddNewService(SrcId, DestId, srvTypeId, (double)Dist);
                        if (Status)
                        {
                            MessageBox.Show("Success...Adding new Servicess");
                        }
                        else
                        {
                            MessageBox.Show("Error...Adding new Servicess");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error...Src and dest can't be same");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

