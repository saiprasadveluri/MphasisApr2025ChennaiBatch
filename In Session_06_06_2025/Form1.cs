using TravelEzeeDataAccessLayer;

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
            serviceTypeGrid.DataSource = srvTypes;
            //Service Grid
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            servicesGrid.DataSource = srvList;
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddLocationDialog addLocDialog = new AddLocationDialog();
            addLocDialog.ShowDialog();
            //Update Grid
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = null;
            locationGrid.DataSource = locations;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceDialog = new AddNewServiceType();
            addNewServiceDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = null;
            serviceTypeGrid.DataSource = srvTypes;
        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceDialog addNewServiceDialog1 = new AddNewServiceDialog();
            addNewServiceDialog1.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            servicesGrid.DataSource = null;
            servicesGrid.DataSource = srvList;
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SearchAndBookDialog searchAndBookDialog = new SearchAndBookDialog();
            searchAndBookDialog.ShowDialog();
            this.Visible = true;
        }
    }
}
