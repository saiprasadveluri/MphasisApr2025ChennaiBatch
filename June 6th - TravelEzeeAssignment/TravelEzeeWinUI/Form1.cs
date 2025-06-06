namespace TravelEzeeWinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            locationGrid.DataSource = locations;

            //Service Types
            List<ServiceType> serviceTypes = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = serviceTypes;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceType = new AddNewServiceType();
            addNewServiceType.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = null;
            serviceTypeGrid.DataSource = srvTypes;
        }

        private void serviceTypeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
