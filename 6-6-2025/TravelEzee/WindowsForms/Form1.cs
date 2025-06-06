using System.Windows.Forms;
using TravelEzeeEFCoreConsole;
using TravelEzeeEFCoreConsole.Data.DTO;
namespace TravelEzeeWinFormUI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            LocationsGrid.DataSource = locations;

            List<ServiceType> srvTypes = dataAccess.GetAllServiceType();
            ServiceTypesGrid.DataSource = srvTypes;

            List<ServiceEntry> srvList = dataAccess.GetAllServiceView();
            serviceListGrid.DataSource = srvList;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDialog addLocDialog = new AddLocationDialog();
            addLocDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            LocationsGrid.DataSource = null;
            LocationsGrid.DataSource = locations;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewSrviceType addNewServiceDialog = new AddNewSrviceType();
            addNewServiceDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceType> locations = dataAccess.GetAllServiceType();
            ServiceTypesGrid.DataSource = null;
            ServiceTypesGrid.DataSource = locations;

        }

        private void ServiceTypesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceDialog addNewService = new AddNewServiceDialog();
            addNewService.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Service> services = dataAccess.GetAllServices();
            serviceListGrid.DataSource = services;
            serviceListGrid.DataSource = null;

        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<TravelEasyDB.Booking> bookings = dataAccess.GetBookings();
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = bookings;
            Form1_Load(sender, e);
        }
        private void deleteLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteLocation deleteLocation = new DeleteLocation();
            deleteLocation.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetLocations();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = locations;
            Form1_Load(sender, e);
        }
    }
}
