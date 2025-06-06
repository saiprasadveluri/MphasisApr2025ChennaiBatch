using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace TravelEzeeWinUI
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

            Location[] locationArr = new Location[Location.Count];
            Location.ToArray().CopyTo(locationArr, 0);

            comDestinationLocation.DataSource = Location;
            comDestinationLocation.DisplayMember = "LocationName";

            List<Location> DestLocation = locationArr.ToList();
            comSourceLocation.DataSource = DestLocation;
            comSourceLocation.DisplayMember = "LocationName";

            List<ServiceType> SrvTypes = dataAccess.GetAllServiceTypes();
            comSrvType.DataSource = SrvTypes;
            comSrvType.DisplayMember = "ServiceTypeName";

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Location srLoc=comSourceLocation.SelectedItem as Location;
                Location destLoc= comDestinationLocation.SelectedItem as Location;  
                ServiceType srvType=comSrvType.SelectedItem as ServiceType;
                
                if (srLoc != null && destLoc != null && srvType != null)
                {
                    long SrcId = srLoc.LocationId;
                    long DestId = destLoc.LocationId;
                    long SrvTypeId = srvType.STypeId;
                    decimal Dist = numDistance.Value;
                    if(SrcId!=DestId)
                    {
                        DataAccess dataAccess=new DataAccess();
                        bool Status=dataAccess.AddNewService(SrcId, DestId, SrvTypeId, (double)Dist);
                        if(Status)
                        {
                            MessageBox.Show("Success....Adding new Service");
                        }
                        else
                        {
                            MessageBox.Show("Error....Adding new Service");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Error....src and Dest can't be same");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
