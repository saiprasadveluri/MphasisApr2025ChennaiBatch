using TravelEzeeeeee1;


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
            LocationGrid.DataSource = locations;

            //Service Types
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            ServiceTypeGrid.DataSource = srvTypes;

            //Service grid
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            ServiceGrid.DataSource = srvList;
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDialog addLocationDialog = new AddLocationDialog();
            addLocationDialog.ShowDialog();

            //Update Grid
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            LocationGrid.DataSource = null;
            LocationGrid.DataSource = locations;


        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceDialog = new AddNewServiceType();
            addNewServiceDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            ServiceTypeGrid.DataSource = null;
            ServiceTypeGrid.DataSource = srvTypes;
        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewService addNewService = new AddNewService();
            addNewService.ShowDialog();

            DataAccess dataAccess = new DataAccess();
            List<ServiceEntry> srvTypes = dataAccess.GetAllServicesView();
            ServiceGrid.DataSource = null;
            ServiceGrid.DataSource = srvTypes;

        }

        private void ServiceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void deleteLocationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (LocationGrid.SelectedRows.Count > 0)
            {
                DataAccess dataAccess = new DataAccess();
                var SelRow = LocationGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                dataAccess.DeleteLocation(SelId);
                var LocationList = dataAccess.GetAllLocations();
                LocationGrid.DataSource = null;
                LocationGrid.DataSource = LocationList;
                LocationGrid.Refresh();
                var serlist = dataAccess.GetAllServicesView();
                ServiceGrid.DataSource = null;
                ServiceGrid.DataSource = serlist;
                ServiceGrid.Refresh();
            }

        }



        private void deleteServiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ServiceGrid.SelectedRows.Count > 0)
            {
                DataAccess dataAccess = new DataAccess();
                var SelRow = ServiceGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                dataAccess.DeleteService(SelId);
                var ServiceList = dataAccess.GetAllServicesView();
                ServiceGrid.DataSource = null;
                ServiceGrid.DataSource = ServiceList;
                ServiceGrid.Refresh();

            }
        }



        private void deleteServiceTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ServiceTypeGrid.SelectedRows.Count > 0)
            {
                DataAccess dataAccess = new DataAccess();
                var SelRow = ServiceTypeGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                dataAccess.DeleteServiceType(SelId);
                var ServiceTypeList = dataAccess.GetAllServiceTypes();
                ServiceTypeGrid.DataSource = null;
                ServiceTypeGrid.DataSource = ServiceTypeList;
                ServiceTypeGrid.Refresh();
                var serlist = dataAccess.GetAllServicesView();
                ServiceGrid.DataSource = null;
                ServiceGrid.DataSource = serlist;
                ServiceGrid.Refresh();


            }

        }

        private void editLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LocationGrid.SelectedRows.Count > 0)
            {
                DataAccess dataAccess = new DataAccess();
                var SelRow = LocationGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                EditLocation editlocation =new EditLocation(dataAccess,SelId);
                editlocation.ShowDialog();
                var Location = dataAccess.GetAllLocations();
                LocationGrid.DataSource = null;
                LocationGrid.DataSource = Location;
                LocationGrid.Refresh();

          


            }

        }
    }
}
