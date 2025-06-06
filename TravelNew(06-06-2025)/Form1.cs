namespace NewTravelEF
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
            LocationGrid.DataSource = dataAccess.GetAllLocations();
            ServicesGrid.DataSource = dataAccess.GetAllServicesView();
            ServiceTypeGrid.DataSource = dataAccess.GetAllServiceTypes();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocation newLocation = new NewLocation();
            newLocation.ShowDialog();
            List<Location> locationsList = dataAccess.GetAllLocations();
            LocationGrid.DataSource = null;
            LocationGrid.DataSource = locationsList;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewServiceTypes newServiceType = new NewServiceTypes(dataAccess);
            newServiceType.ShowDialog();
            List<ServiceType> serviceTypeList = dataAccess.GetAllServiceTypes();
            ServiceTypeGrid.DataSource = null;
            ServiceTypeGrid.DataSource = serviceTypeList;
        }

        private void addServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewServices servicesList = new NewServices(dataAccess);
            servicesList.ShowDialog();
            List<ServiceEntry> serviceList = dataAccess.GetAllServicesView();
            ServicesGrid.DataSource = null;
            ServicesGrid.DataSource = serviceList;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LocationGrid.SelectedRows.Count > 0)
            {
                var SelRow = LocationGrid.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                dataAccess.DeleteLocation(selId);
                var LocationList = dataAccess.GetAllLocations();
                LocationGrid.DataSource = null;
                LocationGrid.DataSource = LocationList;
                LocationGrid.Refresh();
            }
        }
    }
}
