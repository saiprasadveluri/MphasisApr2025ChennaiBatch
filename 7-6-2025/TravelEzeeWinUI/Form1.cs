using TravelEzeeDataAccessLayer.Data;

namespace TravelEzeeWinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = locations;
            //Service Types
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            servicetypeGrid.DataSource = srvTypes;
            //Service Grid

            List<ServiceEntry> srv = dataAccess.GetAllServicesView();
            servicesGrid.DataSource = srv;
        }
        private void addLoactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDialogue addLocationDialogue = new AddLocationDialogue();
            addLocationDialogue.ShowDialog();
            //Update Grid
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = null;
            locationGrid.DataSource = locations;

        }

        private void addServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceTypeDialogue = new AddNewServiceType();
            addNewServiceTypeDialogue.ShowDialog();
            DataAccess newDataAccess = new DataAccess();
            List<ServiceType> srvType = newDataAccess.GetAllServiceTypes();
            servicetypeGrid.DataSource = null;
            servicetypeGrid.DataSource = srvType;
        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceDialogue addNewServiceDialogue = new AddNewServiceDialogue();
            addNewServiceDialogue.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceEntry> srv = dataAccess.GetAllServicesView();
            servicesGrid.DataSource = srv;
            //servicesGrid.DataSource = null;
        }

        private void locationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void servicesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btndltServType_Click(object sender, EventArgs e)
        {
            if (servicetypeGrid.SelectedRows.Count > 0)
            {
                ServiceType selectedServiceType = servicetypeGrid.SelectedRows[0].DataBoundItem as ServiceType;
                if (selectedServiceType != null)
                {
                    DataAccess dataAccess = new DataAccess();
                    bool status = dataAccess.DeleteServiceType(selectedServiceType.STypeId);
                    if (status)
                    {
                        MessageBox.Show("Service type deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete service type.");
                    }
                }
            }
        }


        private void btndltservice_Click(object sender, EventArgs e)
        {
            if (servicesGrid.SelectedRows.Count > 0)
            {
                ServiceEntry selectedService = servicesGrid.SelectedRows[0].DataBoundItem as ServiceEntry;
                if (selectedService != null)
                {
                    DataAccess dataAccess = new DataAccess();
                    bool status = dataAccess.DeleteService(selectedService.ServiceId);
                    if (status)
                    {
                        MessageBox.Show("Service entry deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete service entry.");
                    }
                }
            }
        }


        private void btndltLoc_Click(object sender, EventArgs e)
        {
            if (locationGrid.SelectedRows.Count > 0)
            {
                Location selectedLocation = locationGrid.SelectedRows[0].DataBoundItem as Location;
                if (selectedLocation != null)
                {
                    DataAccess dataAccess = new DataAccess();
                    bool status = dataAccess.DeleteLocation(selectedLocation.LocationId);
                    if (status)
                    {
                        MessageBox.Show("Location deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete location.");
                    }
                }
            }
        }

    }
}
