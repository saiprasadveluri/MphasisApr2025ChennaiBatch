using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzeeTravelWinUI
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
            List<Location> Location = dataAccess.GetAllLocations();

            Location[] locationsArr = new Location[Location.Count];
            Location.ToArray().CopyTo(locationsArr, 0);


            cmbDestinationLocation.DataSource = Location;
            cmbDestinationLocation.DisplayMember = "LocationName";

            List<Location> Destlocations = locationsArr.ToList();
            cmbSourceLocation.DataSource = Destlocations;
            cmbSourceLocation.DisplayMember = "LocationName";

            List<ServiceType> SrvTypes = dataAccess.GetAllServiceTypes();
            cmbsrvType.DataSource = SrvTypes;
            cmbsrvType.DisplayMember = "ServiceTypeName";

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Location srcLoc = cmbSourceLocation.SelectedItem as Location;
               Location destLoc = cmbDestinationLocation.SelectedItem as Location;
                ServiceType srvType= cmbsrvType.SelectedItem as ServiceType;   
                if (srcLoc != null && destLoc != null && srvType != null)
                {
                    long SrcId = srcLoc.LocationId;
                    long DestId = destLoc.LocationId;
                    long SrvTypeId = srvType.STypeId;
                    decimal Dist = numDistance.Value;
                    if(SrcId!= DestId)
                    {
                        DataAccess dataAccess = new DataAccess();
                        bool status = dataAccess.AddNewService(SrcId,DestId,SrvTypeId,(double)Dist);
                        if (status)
                        {
                            MessageBox.Show("Success...Adding new Service");
                        }
                        else
                        {
                            MessageBox.Show("Error... Adding New service");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error...SRc and Dest cant be same");
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
