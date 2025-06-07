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

                List<ServiceEntry> serviceList = dataAccess.GetAllServicesView();
                ServicesGrid.DataSource = null;
                ServicesGrid.DataSource = serviceList;
            }
        }

        private void deleteServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ServiceTypeGrid.SelectedRows.Count > 0)
            {
                var SelRow = ServiceTypeGrid.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                dataAccess.DeleteServicesType(selId);
                var srvList = dataAccess.GetAllServiceTypes();
                ServiceTypeGrid.DataSource = null;
                ServiceTypeGrid.DataSource = srvList;
                ServiceTypeGrid.Refresh();

                List<ServiceEntry> serviceList = dataAccess.GetAllServicesView();
                ServicesGrid.DataSource = null;
                ServicesGrid.DataSource = serviceList;
            }
        }

        private void deleteServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ServicesGrid.SelectedRows.Count > 0)
            {
                var SelRow = ServicesGrid.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                dataAccess.DeleteServices(selId);
                var srvList = dataAccess.GetAllServices();

                List<ServiceEntry> serviceList = dataAccess.GetAllServicesView();
                ServicesGrid.DataSource = null;
                ServicesGrid.DataSource = serviceList;
                ServicesGrid.Refresh();
            }
        }

        private void searchServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchList searchList = new SearchList(dataAccess);
            searchList.ShowDialog();

            List<ServiceEntry> serviceList = dataAccess.GetAllServicesView();
            ServicesGrid.DataSource = null;
            ServicesGrid.DataSource = serviceList;
            ServicesGrid.Refresh();
        }

        private void editLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LocationGrid.SelectedRows.Count > 0)
            {
                var SelRow = LocationGrid.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                EditLocation editLocation = new EditLocation(dataAccess, selId);
                editLocation.ShowDialog();

                var LocationList = dataAccess.GetAllLocations();
                LocationGrid.DataSource = null;
                LocationGrid.DataSource = LocationList;
                LocationGrid.Refresh();
            }
        }
    }
}
