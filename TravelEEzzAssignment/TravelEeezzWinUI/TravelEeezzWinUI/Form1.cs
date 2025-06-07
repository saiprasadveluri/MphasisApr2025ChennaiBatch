//using TravelEeezzWinUI;
using TravelEezzz1;
namespace TravelEeezzWinUI
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
            List<Location> Locations = dataAccess.GetAllLocations();
            LocationGrid.DataSource = Locations;
            //Service Types
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = srvTypes;
            //Service Grid
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            SevicesGrid.DataSource = srvList;
        }

        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDialog addLocDialog = new AddLocationDialog();
            addLocDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Location> Locations = dataAccess.GetAllLocations();
            LocationGrid.DataSource = null;
            LocationGrid.DataSource = Locations;

        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceDialog = new AddNewServiceType();
            addNewServiceDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = null;
            serviceTypeGrid.DataSource = srvTypes;

        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewService addNewService = new AddNewService();
            addNewService.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            SevicesGrid.DataSource = null;
            SevicesGrid.DataSource = srvList;

        }

        private void deleteLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteLocationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (LocationGrid.SelectedRows.Count > 0)
            {
                var SelRow = LocationGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                DataAccess dataAccess = new DataAccess();
                dataAccess.DeleteLocation(SelId);
                var LocationList = dataAccess.GetAllLocations();
                LocationGrid.DataSource = null;
                LocationGrid.DataSource = LocationList;
                LocationGrid.Refresh();
                var serList = dataAccess.GetAllServicesView();
                SevicesGrid.DataSource = null;
                SevicesGrid.DataSource = serList;
                SevicesGrid.Refresh();

            }
        }

        private void deleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SevicesGrid.SelectedRows.Count > 0)
            {
                var SelRow = SevicesGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                DataAccess dataAccess = new DataAccess();
                dataAccess.DeleteService(SelId);
                var ServiceList = dataAccess.GetAllServicesView();
                SevicesGrid.DataSource = null;
                SevicesGrid.DataSource = ServiceList;
                SevicesGrid.Refresh();
                var serList = dataAccess.GetAllServicesView();
                SevicesGrid.DataSource = null;
                SevicesGrid.DataSource = serList;
                SevicesGrid.Refresh();

            }
        }

        private void deleteServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serviceTypeGrid.SelectedRows.Count > 0)
            {
                var SelRow = serviceTypeGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                DataAccess dataAccess = new DataAccess();
                dataAccess.DeleteServiceType(SelId);
                var ServiceTypeList = dataAccess.GetAllServiceTypes();
                serviceTypeGrid.DataSource = null;
                serviceTypeGrid.DataSource = ServiceTypeList;
                serviceTypeGrid.Refresh();
                var serList = dataAccess.GetAllServicesView();
                SevicesGrid.DataSource = null;
                SevicesGrid.DataSource = serList;
                SevicesGrid.Refresh();

            }
        }

        private void editLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            if (LocationGrid.SelectedRows.Count > 0)
            {
                var SelRow = LocationGrid.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                EditLocation editLocation= new EditLocation(dataAccess,SelId);
                editLocation.ShowDialog();

                var LocationList = dataAccess.GetAllLocations();
                LocationGrid.DataSource = null;
                LocationGrid.DataSource = LocationList;
                LocationGrid.Refresh();

            }
        }
    }
}
