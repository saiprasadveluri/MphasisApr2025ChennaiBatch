using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTravelEF
{
    public partial class NewServices : Form
    {
        DataAccess dataAccess;
        public NewServices(DataAccess _dataAccess)
        {
            InitializeComponent();
            dataAccess = _dataAccess;
        }

        private void NewServices_Load(object sender, EventArgs e)
        {
            List<Location> locations = dataAccess.GetAllLocations();

            Location[] locs = new Location[locations.Count];
            locations.ToArray().CopyTo(locs, 0);

            SourceLocIdBox.DataSource = locations;
            SourceLocIdBox.DisplayMember = "LocationName";

            List<Location> destlocations = locs.ToList();
            DestLocIdBox.DataSource = destlocations;
            DestLocIdBox.DisplayMember = "LocationName";

            List<ServiceType> serviceTypes = dataAccess.GetAllServiceTypes();
            ServTypeIdBox.DataSource = serviceTypes;
            ServTypeIdBox.DisplayMember = "ServiceTypeName";
        }

        private void AddServicesButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceType srvid=ServTypeIdBox.SelectedItem as ServiceType;
                Location src = SourceLocIdBox.SelectedItem as Location;
                Location dest = DestLocIdBox.SelectedItem as Location;
                if(src!=null && dest!=null && srvid!=null)
                {
                    long srvTypeId = srvid.ServTypeId;
                    long srcLocid = src.LocationId;
                    long desLocid = dest.LocationId;
                    decimal dist = DistanceNumericUpDown.Value;
                    if(srcLocid!= desLocid)
                    {
                        bool status = dataAccess.AddService(srvTypeId, srcLocid, desLocid,(double)dist);
                        if (status)
                        {
                            MessageBox.Show("Service Added");
                        }
                        else
                        {
                            MessageBox.Show("Service Not Added");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
