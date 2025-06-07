using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeWinUI
{
    public partial class AddNewServiceDialog : Form
    {
        public AddNewServiceDialog()
        {
            InitializeComponent();
        }

        private void AddNewServiceDialog_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> SrcLocation = dataAccess.GetAllLocations();

            List<Location> destLocation = dataAccess.GetAllLocations();
            cmbSourceLocations.DataSource = SrcLocation;
            cmbSourceLocations.DisplayMember = "LocationName";

            List<ServiceType> SrvTypes = dataAccess.GetAllServiceTypes();
            cmbSrvType.DataSource = SrvTypes;
            cmbSrvType.DisplayMember = "ServiceTypeName";

            cmbDestinationLocations.DataSource = destLocation;
            cmbDestinationLocations.DisplayMember = "LocationName";
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Location? srcLoc = cmbSourceLocations.SelectedItem as Location;
                Location? descLoc = cmbDestinationLocations.SelectedItem as Location;
                ServiceType? srvType = cmbSrvType.SelectedItem as ServiceType;
                if (srcLoc != null && descLoc != null)
                {
                    long SrcId = srcLoc.LocationId;
                    long DestId = descLoc.LocationId;
                    long SrvTypeId = srvType.STypeId;
                    decimal Dist = numDistance.Value;
                    if (SrcId != DestId)
                    {
                        DataAccess dataaccess = new DataAccess();
                        bool Status = dataaccess.AddNewService(SrcId, DestId, SrvTypeId, (double)Dist);
                        if (Status)
                        {
                            MessageBox.Show("Success....in adding new services");
                        }
                        else
                        {
                            MessageBox.Show("Error....in adding new services");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error...Src and Dest can't be same");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error....{ex:Message}");
            }
        }
    }
    
}
