using TravelEezeDataAccessLayer;
using TravelEezeDataAccessLayer.Data.DTO;
namespace TravelEezeWinApplication
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

            //service types
            List<ServiceType> serviceTypes = new List<ServiceType>();
            serviceTypeGrid.DataSource = serviceTypes;

            //Service list
            List<ServiceEntry> services = new List<ServiceEntry>();
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
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = null;
            locationGrid.DataSource = locations;

        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceType = new AddNewServiceType();
            addNewServiceType.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceType> srvType = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = null;
            serviceTypeGrid.DataSource = srvType;
        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceDailog addNewServiceDailog = new AddNewServiceDailog();
            addNewServiceDailog.ShowDialog();
            List<ServiceEntry> services = new List<ServiceEntry>();
            serviceListGrid.DataSource = null;
            serviceListGrid.DataSource = services;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
