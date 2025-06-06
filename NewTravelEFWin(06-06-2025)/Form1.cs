namespace NewTravelEFWin
{
    public partial class Form1 : Form
    {
        DataAccess dataAccess;
        public Form1()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LocationGrid.DataSource = dataAccess.GetAllLocations();
            ServiceTypeGrid.DataSource = dataAccess.GetAllServiceTypes();
            ServiceGrid.DataSource = dataAccess.GetAllServicesView();
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
            NewServices newServices = new NewServices(dataAccess);
            newServices.ShowDialog();
            List<ServiceEntry> serviceList = dataAccess.GetAllServicesView();
            ServiceGrid.DataSource = null;
            ServiceGrid.DataSource = serviceList;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(LocationGrid.SelectedRows.Count>0)
            {
                var SelRow = LocationGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                dataAccess.DeleteLocation(SelId);
                var LocationList = dataAccess.GetAllLocations();
                LocationGrid.DataSource = null;
                LocationGrid.DataSource = LocationList;
                LocationGrid.Refresh();
            }
        }
    }
}
