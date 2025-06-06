namespace TravelFormsEF
{
    public partial class Form1 : Form
    {
        DataAccess dbHandler;

        public Form1()
        {
            dbHandler = new DataAccess();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbHandler = new DataAccess();
            GridLocations.DataSource = dbHandler.FetchAllLocations();
            GridServiceType.DataSource = dbHandler.FetchServiceTypes();
            GridServices.DataSource = dbHandler.FetchAllServiceDetails();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocation locationForm = new NewLocation();
            locationForm.ShowDialog();

            dbHandler = new DataAccess();
            var locationList = dbHandler.FetchAllLocations();

            GridLocations.DataSource = null;
            GridLocations.DataSource = locationList;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSerType serviceTypeForm = new btnSerType();
            serviceTypeForm.ShowDialog();

            dbHandler = new DataAccess();
            var typeList = dbHandler.FetchServiceTypes();

            GridServiceType.DataSource = null;
            GridServiceType.DataSource = typeList;
        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewService serviceForm = new NewService();
            serviceForm.ShowDialog();

            var serviceEntries = dbHandler.FetchAllServiceDetails();

            GridServices.DataSource = null;
            GridServices.DataSource = serviceEntries;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridLocations.SelectedRows.Count > 0)
            {
                var selectedRow = GridLocations.SelectedRows[0];
                int locationId = Convert.ToInt32(selectedRow.Cells[0].Value);

                dbHandler.RemoveLocation(locationId);

                var updatedLocations = dbHandler.FetchAllLocations();
                GridLocations.DataSource = null;
                GridLocations.DataSource = updatedLocations;
                GridLocations.Refresh();

                var updatedServices = dbHandler.FetchAllServiceDetails();
                GridServices.DataSource = null;
                GridServices.DataSource = updatedServices;
                GridServices.Refresh();
            }
        }

        private void searchEngineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceSearch searchForm = new ServiceSearch();
            searchForm.ShowDialog();
            // Add search functionality as needed
        }
    }
}
