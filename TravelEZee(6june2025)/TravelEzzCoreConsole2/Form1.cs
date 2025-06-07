using System.Security.Cryptography.Pkcs;
using System.ServiceProcess;
using TravelEzeeDataAccessLayer;
namespace TravelEzzCoreConsole2
{
    public partial class from1 : Form
    {
        public from1()
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
            ServiceTypeGrid.DataSource = srvTypes;
            //Service Grid
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            ServicesGrid.DataSource = srvList;
        }

        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocation addLocation = new AddLocation();
            addLocation.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<Location> Locations = dataAccess.GetAllLocations();
            LocationGrid.DataSource = null;
            LocationGrid.DataSource = Locations;
        }

        //private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddNewServiceType addNewServiceType = new AddNewServiceType();
        //    addNewServiceType.ShowDialog();
        //    DataAccess dataAccess = new DataAccess();
        //    List<ServiceType> ServiceTypes = dataAccess.GetAllServiceTypes();
        //    ServiceTypeGrid.DataSource = null;
        //    ServiceTypeGrid.DataSource = ServiceTypes;

        //}

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Service addNewService = new Add_New_Service();
            addNewService.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceEntry> SrvList = dataAccess.GetAllServicesView();
            ServicesGrid.DataSource = null;
            ServicesGrid.DataSource = SrvList;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceType = new AddNewServiceType();
            addNewServiceType.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceType> ServiceTypes = dataAccess.GetAllServiceTypes();
            ServiceTypeGrid.DataSource = null;
            ServiceTypeGrid.DataSource = ServiceTypes;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selRow = LocationGrid.SelectedRows[0];
            int selId = int.Parse(selRow.Cells[0].Value.ToString());
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteLocation(selId);
            var LocationList = dataAccess.GetAllLocations();
            LocationGrid.DataSource = null;
            LocationGrid.DataSource = LocationList;
            LocationGrid.Refresh();
            var ServiceList = dataAccess.GetAllServicesView();
            ServicesGrid.DataSource = null;
            ServicesGrid.DataSource = ServiceList;
            ServicesGrid.Refresh();

        }

        private void deleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selRow = ServicesGrid.SelectedRows[0];
            int selId = int.Parse(selRow.Cells[0].Value.ToString());
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteServices(selId);


            var ServiceList = dataAccess.GetAllServicesView();
            ServicesGrid.DataSource = null;
            ServicesGrid.DataSource = ServiceList;
            ServicesGrid.Refresh();

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //ServiceTypes
        {
            var selRow = ServiceTypeGrid.SelectedRows[0];
            int selId = int.Parse(selRow.Cells[0].Value.ToString());
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteServicesType(selId);


            var ServicetypeList = dataAccess.GetAllServiceTypes();
            ServiceTypeGrid.DataSource = null;
            ServiceTypeGrid.DataSource = ServicetypeList;
            ServiceTypeGrid.Refresh();

            var ServiceList = dataAccess.GetAllServicesView();
            ServicesGrid.DataSource = null;
            ServicesGrid.DataSource = ServiceList;
            ServicesGrid.Refresh();
        }

        private void updateLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DataAccess dataAccess = new DataAccess();    
            if(LocationGrid.SelectedRows.Count > 0)
            {
                var selRow = LocationGrid.SelectedRows[0];
                int selId = int.Parse(selRow.Cells[0].Value.ToString());
                EditLocation editLocation = new EditLocation(dataAccess,selId);
                editLocation.ShowDialog();
                var Loaction = dataAccess.GetAllLocations();
                LocationGrid.DataSource = null;
                LocationGrid.DataSource = Loaction;
                LocationGrid.Refresh();
            }

          

        }
    }
}
