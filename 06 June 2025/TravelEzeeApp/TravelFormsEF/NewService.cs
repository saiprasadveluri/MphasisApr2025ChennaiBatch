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
    public partial class NewService : Form
    {
        public NewService()
        {
            InitializeComponent();
        }

        private void NewService_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();

            Location[] locs = new Location[locations.Count];
            locations.ToArray().CopyTo(locs, 0);

            cmbSource.DataSource = locations;
            cmbSource.DisplayMember = "LocationName";

            List<Location> locations1=locs.ToList();
            cmbDest.DataSource = locations1;
            cmbDest.DisplayMember = "LocationName";

            List<ServiceType> servtype = dataAccess.GetAllServiceTypes();
            cmbServType.DataSource = servtype;
            cmbServType.DisplayMember = "ServiceTypeName";
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Location srcLoc=cmbSource.SelectedItem as Location;
                Location destLoc=cmbDest.SelectedItem as Location;
                ServiceType serviceType = cmbServType.SelectedItem as ServiceType;
                if(srcLoc!=null && destLoc!=null&& serviceType!=null)
                {
                    long SrcId=srcLoc.LocationId;
                    long DestId=destLoc.LocationId;
                    long SrvTypeId = serviceType.STypeId;
                    decimal dist=Distance.Value;
                    if(SrcId!=DestId)
                    {
                        DataAccess dataAccess=new DataAccess();
                        bool Status = dataAccess.AddService(SrvTypeId, SrcId, DestId, (double)dist);
                        if(Status)
                        {
                            MessageBox.Show("Added Service");
                        }
                        else
                        {
                            MessageBox.Show("Failed to Add");
                        }
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
