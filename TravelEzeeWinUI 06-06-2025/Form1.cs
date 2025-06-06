using TravelEzeeWinUIConsole;
using TravelEzeeWinUI2;

namespace TravelEzeeWinUI2
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
            List<ServiceType> srvType = dataAccess.GetAllServiceType();
            sericeTypeGrid.DataSource = srvType;
            //Services 
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            ServicesGrid.DataSource = srvList;
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDialog addLocationDialog = new AddLocationDialog();
            addLocationDialog.ShowDialog();
            //Update Grid
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = null;
            locationGrid.DataSource = locations;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceType = new AddNewServiceType();
            addNewServiceType.ShowDialog();

            //Update grid

            DataAccess dataAccess = new DataAccess();
            List<ServiceType> srvType = dataAccess.GetAllServiceType();
            sericeTypeGrid.DataSource = null;
            sericeTypeGrid.DataSource = srvType;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNewService addNewService = new AddNewService();
            addNewService.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Services> services = dataAccess.GetAllServices();
            ServicesGrid.DataSource = null;
            ServicesGrid.DataSource = services;
        }

        private void bookTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Booking> bookings = dataAccess.GetAllBookings().Cast<Booking>().ToList();
            bookingGrid.DataSource = null;
            bookingGrid.DataSource = bookings;
            Form1_Load(sender, e);
        }
    }
}
