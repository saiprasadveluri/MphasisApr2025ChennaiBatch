using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsTravelEzee
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
            List<Location> locations = dataAccess.getAllLocations();

            

            Location[] locationArr=new Location[locations.Count];
            locations.ToArray().CopyTo(locationArr, 0);

            cmbDestinationLocations.DataSource = locations;
            cmbDestinationLocations.DisplayMember = "LocationName";

            List<Location> Destlocations = locationArr.ToList();
            cmbSourceLocations.DataSource = Destlocations;
            cmbSourceLocations.DisplayMember = "LocationName";

            List<ServiceType> SrvTypes = dataAccess.getAllServiceTypes();
            cmbSrvType.DataSource = SrvTypes;
            cmbSrvType.DisplayMember = "ServiceTypeName";

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Location srLoc= cmbSourceLocations.SelectedItem as Location;
                Location destLoc=cmbDestinationLocations.SelectedItem as Location;
                ServiceType srvType=cmbSrvType.SelectedItem as ServiceType;

                if(srLoc !=null && destLoc !=null && srvType !=null)
                {
                    long SrcId=srLoc.LocationId;
                    long DestId=destLoc.LocationId;
                    long SrvTypeId = srvType.STypeId;
                    decimal Dist = numDistance.Value;
                    if(SrcId !=DestId)
                    {
                        DataAccess dataAccess=new DataAccess();
                      bool Status= dataAccess.AddNewService(SrcId, DestId, SrvTypeId, (double)Dist);
                        if (Status)
                        {
                            MessageBox.Show("succes...adding new service");
                        }
                        else
                        {
                            MessageBox.Show("error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("error .......   src and dest cant be same");
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
