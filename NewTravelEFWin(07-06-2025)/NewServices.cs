using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTravelEFWin
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

            comboBoxSource.DataSource = locations;
            comboBoxSource.DisplayMember = "LocationName";

            List<Location> destlocations = locs.ToList();
            comboBoxDestination.DataSource = destlocations;
            comboBoxDestination.DisplayMember = "LocationName";

            List<ServiceType> serviceTypes = dataAccess.GetAllServiceTypes();   
            comboBoxServiceType.DataSource = serviceTypes;
            comboBoxServiceType.DisplayMember = "ServiceTypeName";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceType srvid = comboBoxServiceType.SelectedItem as ServiceType;
                Location src = comboBoxSource.SelectedItem as Location;
                Location dest = comboBoxDestination.SelectedItem as Location;
                if (src != null && dest != null)
                {
                    long srvTypeId = srvid.STypeId;
                    long srcLocId = src.LocationId;
                    long destLocId = dest.LocationId;
                    decimal dist = DistancenumericUpDown1.Value;
                    if (srcLocId != destLocId)
                    {
                        bool status = dataAccess.AddService(srvTypeId, srcLocId, destLocId, (double)dist);
                        if (status)
                        {
                            MessageBox.Show("Service Added");
                        }
                        else
                        {
                            MessageBox.Show("Services not Added");
                        }
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
