using TravelEzeeDataAccessLayer;
namespace TravelEzeeWinUII
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
            ServiceTypeGrid.DataSource = srvTypes;
            //Services Grid
            List<ServiceEntry> srvList = dataAccess.GetAllServiceView();
            ServicesGrid.DataSource = srvList;
        }

        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDialog addLocDialog = new AddLocationDialog();
            addLocDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = null;
            locationGrid.DataSource = locations;

        }

        private void addServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceType = new AddNewServiceType();
            addNewServiceType.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            ServiceTypeGrid.DataSource = null;
            ServiceTypeGrid.DataSource = srvTypes;


        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceDialog addNewServiceDialog = new AddNewServiceDialog();
            addNewServiceDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceEntry> srvList = dataAccess.GetAllServiceView();
            ServicesGrid.DataSource = null;
            ServicesGrid.DataSource = srvList;

        }
    }
}
