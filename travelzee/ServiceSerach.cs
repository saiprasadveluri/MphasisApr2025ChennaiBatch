using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using travelzee;

namespace TravelFormsEF
{
    public partial class ServiceSearch : Form
    {
        private readonly DataAccess _dataAccess;

        public ServiceSearch()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        private void ServiceSearch_Load(object sender, EventArgs e)
        {
            PopulateLocationDropdowns();
        }

        private void PopulateLocationDropdowns()
        {
            try
            {
                var allLocations = _dataAccess.GetAllLocations();

                cmbSrcS.DataSource = new List<Location>(allLocations);
                cmbSrcS.DisplayMember = nameof(Location.LocationName);

                cmbDesS.DataSource = new List<Location>(allLocations);
                cmbDesS.DisplayMember = nameof(Location.LocationName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading locations: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var source = cmbSrcS.SelectedItem as Location;
            var destination = cmbDesS.SelectedItem as Location;

            if (source == null || destination == null)
            {
                MessageBox.Show("Please select both source and destination.");
                return;
            }

            if (source.LocationId == destination.LocationId)
            {
                MessageBox.Show("Source and destination cannot be the same.");
                return;
            }

            try
            {
                var matchingServices = _dataAccess.GetServicesBasedOnLocation(source, destination);
                GridSearch.DataSource = matchingServices;

                if (matchingServices.Count == 0)
                {
                    MessageBox.Show("No services found for the selected route.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching services: " + ex.Message);
            }
        }
    }
}
