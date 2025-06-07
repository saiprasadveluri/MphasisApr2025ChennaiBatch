using System.Windows.Forms;
using TravelEzeeWinUIConsole;
using System.Collections.Generic;
namespace TravelEzeeWinUI
{
    public partial class Form1 : Form
    {
        private DataAccess da;
        public Form1()
        {
            InitializeComponent();
            da = new DataAccess();
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

            List<TravelEzeeWinUIConsole.Booking> bookings = dataAccess.GetBookings();
            bookingGrid.DataSource = bookings;

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
            List<TravelEzeeWinUIConsole.Booking> bookings = dataAccess.GetBookings().ToList();
            bookingGrid.DataSource = null;
            bookingGrid.DataSource = bookings;
            Form1_Load(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        { DataAccess da = new DataAccess(); 
            try
            {
                // Check if any grid has a selected row
                if (locationGrid.SelectedRows.Count > 0)
                {
                    long selectedId = Convert.ToInt64(locationGrid.SelectedRows[0].Cells["LocationId"].Value);
                    bool isDeleted = da.DeleteLocation(selectedId);
                    if (isDeleted) locationGrid.DataSource = da.GetAllLocations();
                }
                else if (ServiceTypeGrid.SelectedRows.Count > 0)
                {
                    long selectedId = Convert.ToInt64(ServiceTypeGrid.SelectedRows[0].Cells["STypeId"].Value);
                    bool isDeleted = da.DeleteServiceType(selectedId);
                    if (isDeleted) ServiceTypeGrid.DataSource = da.GetAllServiceTypes();
                }
                else if (ServicesGrid.SelectedRows.Count > 0)
                {
                    long selectedId = Convert.ToInt64(ServicesGrid.SelectedRows[0].Cells["ServiceId"].Value);
                    bool isDeleted = da.DeleteService(selectedId);
                    if (isDeleted) ServicesGrid.DataSource = da.GetAllServiceView();
                }
                else if (bookingGrid.SelectedRows.Count > 0)
                {
                    long selectedId = Convert.ToInt64(bookingGrid.SelectedRows[0].Cells["BookId"].Value);
                    bool isDeleted = da.DeleteBooking(selectedId);
                    if (isDeleted) bookingGrid.DataSource = da.GetBookings();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}");
            }
        }
    }
}