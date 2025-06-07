using TravelEezeDataAccessLayer;
using TravelEezeDataAccessLayer.Data.DTO;
namespace TravelEezeWinApplication
{
    public partial class Form1 : Form
    {
        DataAccess dataAccess;
        public Form1()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = locations;

            //service types
            List<ServiceType> serviceTypes = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = serviceTypes;

            //Service list
            List<ServiceEntry> services = dataAccess.GetAllServicesView();
            serviceListGrid.DataSource = services;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDailog addLocDailog = new AddLocationDailog();
            addLocDailog.ShowDialog();
            //Update Grid

            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = null;
            locationGrid.DataSource = locations;

        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceType = new AddNewServiceType();
            addNewServiceType.ShowDialog();

            List<ServiceType> srvType = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = null;
            serviceTypeGrid.DataSource = srvType;
        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceDailog addNewServiceDailog = new AddNewServiceDailog();
            addNewServiceDailog.ShowDialog();

            List<ServiceEntry> services = dataAccess.GetAllServicesView();
            serviceListGrid.DataSource = null;
            serviceListGrid.DataSource = services;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void locationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DeleteLocation deleteLocation = new DeleteLocation();
            //deleteLocation.ShowDialog();
        }

        private void serviceListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (locationGrid.SelectedRows.Count > 0)
            {
                Location selectedLoc = locationGrid.SelectedRows[0].DataBoundItem as Location;
                if (selectedLoc != null)
                {
                    DataAccess dataAccess1 = new DataAccess();
                    bool Status = dataAccess1.RemoveLocation(selectedLoc.LocationId);
                    if (Status)
                    {
                        MessageBox.Show("Location deleted successfully");
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                        closeApplication();

                    }
                    else
                    {
                        MessageBox.Show("failed to delete location");
                    }
                }
            }
        }
        public void closeApplication()
        {
            Application.Exit();
        }

        private void btnDelLoc_Click(object sender, EventArgs e)
        {
            
        }
    }
}
