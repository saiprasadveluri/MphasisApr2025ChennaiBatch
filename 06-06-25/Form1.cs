using System.Windows.Forms;
using TravelEzeeWinUIConsole;
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
            ServiceTypeGrid.DataSource = srvTypes;

            List<ServiceEntry> srvList = dataAccess.GetAllServiceView();
            ServicesGrid.DataSource = srvList;
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
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
            AddNewServiceType addNewServiceType = new AddNewServiceType();
            addNewServiceType.ShowDialog();

            //Update grid

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

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Booking> bookings = dataAccess.GetBookings().ToList();
            bookingGrid.DataSource = null;
            bookingGrid.DataSource = bookings;
            Form1_Load(sender, e);
        }
    }
}