using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeWinUI2
{
    public partial class AddNewService : Form
    {
        public AddNewService()
        {
            InitializeComponent();
        }

        private void AddNewService_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> Location = dataAccess.GetAllLocations();
            cmbDestinationLocation.DataSource = Location;
            cmbDestinationLocation.DisplayMember = "LocationName";
            List<Location> LocationList = dataAccess.GetAllLocations();
            cmbSourceLocation.DataSource = LocationList;
            cmbSourceLocation.DisplayMember = "LocationName";
            List<ServiceType> SrvTypes = dataAccess.GetAllServiceType();
            cmbServiceType.DataSource = SrvTypes;
            cmbServiceType.DisplayMember = "ServiceTypeName";
            //cmbServiceType.ValueMember = "STypeId";
        }

        private void btnAddNewService_Click(object sender, EventArgs e)
        {
            try
            {
                Location srcLoc = cmbSourceLocation.SelectedItem as Location;
                Location destLoc = cmbDestinationLocation.SelectedItem as Location;
                ServiceType srvType=cmbServiceType.SelectedItem as ServiceType;
                if(srcLoc!= null && destLoc!= null){
                    long SrcId = srcLoc.LocationId;
                    long DestId = destLoc.LocationId;
                    long SrvTypeId = srvType.STypeId;
                    decimal Dist = numDistance.Value;
                    if(SrcId != DestId){
                        DataAccess dataAccess = new DataAccess();
                       bool Status=dataAccess.AddService(SrvTypeId, SrcId, DestId,(double)Dist);
                        if (Status) {
                            MessageBox.Show("Success Adding in New Service");
                        }
                        else
                        {
                            MessageBox.Show("Error Adding in New Service");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error.....Src and Dest Cant be Same");
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
                
            }
        }
    }
}
