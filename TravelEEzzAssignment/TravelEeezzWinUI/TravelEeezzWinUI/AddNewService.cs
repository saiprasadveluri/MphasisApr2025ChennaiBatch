using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEeezzWinUI
{
    public partial class AddNewService : Form
    {
        public AddNewService()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewService_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();

            Location[] locationsArr = new Location[locations.Count];
            locations.ToArray().CopyTo(locationsArr, 0);

            comboDestinationLocation.DataSource = locations;
            comboDestinationLocation.DisplayMember = "LocationName";

            List<Location> Destlocations = locationsArr.ToList();
            comboSourceLocation.DataSource = Destlocations;
            comboSourceLocation.DisplayMember = "LocationName";

            List<ServiceType> SrvTypes = dataAccess.GetAllServiceTypes();
            comboSrvType.DataSource = SrvTypes;
            comboSrvType.DisplayMember = "ServiceTypeName";



        }

        private void btnAddServicee_Click(object sender, EventArgs e)
        {
            try
            {
                Location srLoc = comboSourceLocation.SelectedItem as Location;
                Location dstLoc = comboDestinationLocation.SelectedItem as Location;
                ServiceType srvType = comboSrvType.SelectedItem as ServiceType;
                if (srLoc != null && dstLoc != null && srvType != null)
                {
                    long SrcId = srLoc.LocationId;
                    long DstId = dstLoc.LocationId;
                    long SrvTypeId = srvType.STypeId;
                    decimal Dist = numDistance.Value;
                    if (SrcId != DstId)
                    {
                        DataAccess dataAccess = new DataAccess();
                        bool Status = dataAccess.AddNewService(SrcId, DstId, SrvTypeId, (double)Dist);
                        if (Status)
                        {
                            MessageBox.Show("Success....Adding New Service");
                        }
                        else
                        {
                            MessageBox.Show("Error....Adding New Service");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Error..Source and Destination Can't be same");
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
         

