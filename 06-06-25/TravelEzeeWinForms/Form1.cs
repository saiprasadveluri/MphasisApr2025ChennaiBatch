using TravelEasyDB;
namespace TravelEasywinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            List<Location> locations = da.GetLocations();
            dataGridView1.DataSource = locations;

            List<ServiceType> servicet = da.GetServiceTypes();
            dataGridView2.DataSource = servicet;

            List<Service> services = da.GetServices();
            dataGridView3.DataSource = services;

            List<TravelEasyDB.Booking> bookings = da.GetBookings();
            dataGridView4.DataSource = bookings;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }


        private void addLocationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddLocation addLocationForm = new AddLocation();
            addLocationForm.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetLocations();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = locations;
            Form1_Load(sender, e);
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceTypeAdd addServiceTypeForm = new ServiceTypeAdd();
            addServiceTypeForm.ShowDialog();
            DataAccess a = new DataAccess();
            List<ServiceType> servicet = a.GetServiceTypes();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = servicet;
            Form1_Load(sender, e);
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddService addServiceForm = new AddService();
            addServiceForm.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Service> services = dataAccess.GetServices();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = services;
            Form1_Load(sender, e);
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
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
