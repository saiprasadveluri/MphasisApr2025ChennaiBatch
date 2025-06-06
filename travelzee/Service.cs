using System;
using System.Collections.Generic;
using System.Windows.Forms;
using travelzee;

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
            InitializeDropdowns();
        }

        private void InitializeDropdowns()
        {
            var dataAccess = new DataAccess();

            // Load locations
            var allLocations = dataAccess.GetAllLocations();
            cmbSource.DataSource = new List<Location>(allLocations);
            cmbSource.DisplayMember = nameof(Location.LocationName);

            cmbDest.DataSource = new List<Location>(allLocations);
            cmbDest.DisplayMember = nameof(Location.LocationName);

            // Load service types
            var serviceTypes = dataAccess.GetAllServiceTypes();
            cmbServType.DataSource = serviceTypes;
            cmbServType.DisplayMember = nameof(ServiceType.ServiceTypeName);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                var sourceLocation = cmbSource.SelectedItem as Location;
                var destinationLocation = cmbDest.SelectedItem as Location;
                var selectedServiceType = cmbServType.SelectedItem as ServiceType;

                if (sourceLocation == null || destinationLocation == null || selectedServiceType == null)
                {
                    MessageBox.Show("Please select valid source, destination, and service type.");
                    return;
                }

                if (sourceLocation.LocationId == destinationLocation.LocationId)
                {
                    MessageBox.Show("Source and destination cannot be the same.");
                    return;
                }

                var distanceInKm = (double)Distance.Value;

                var db = new DataAccess();
                var isServiceAdded = db.AddService(
                    selectedServiceType.STypeId,
                    sourceLocation.LocationId,
                    destinationLocation.LocationId,
                    distanceInKm
                );

                MessageBox.Show(isServiceAdded ? "Service added successfully." : "Failed to add service.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
