using DataAccessLayer;
namespace WinformsTravelEzee
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
            List<Location> locations = dataAccess.getAllLocations();
            locationGrid.DataSource = locations;
            //service Type
            List<ServiceType> srvTypes = dataAccess.getAllServiceTypes();
            serviceTypeGrid.DataSource = srvTypes;
            //service grid
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            serviceGrid.DataSource = srvList;

           

        }
        

        private void addLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDialog addLocDialog = new AddLocationDialog();
            addLocDialog.ShowDialog();

            //update grid
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.getAllLocations();
            locationGrid.DataSource = null;
            locationGrid.DataSource = locations;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceType addNewServiceType = new AddNewServiceType();
            addNewServiceType.ShowDialog();

            DataAccess dataAccess = new DataAccess();
            List<ServiceType> srvTypes = dataAccess.getAllServiceTypes();
            serviceTypeGrid.DataSource = null;
            serviceTypeGrid.DataSource = srvTypes;

        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewService addNewService = new AddNewService();
            addNewService.ShowDialog();

            DataAccess dataAccess = new DataAccess();
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            serviceGrid.DataSource = null;
            serviceGrid.DataSource = srvList;
        }



        private void deleteLocationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            DataAccess dataAccess = new DataAccess();
            if (locationGrid.SelectedRows.Count > 0)
            {
                var SelRow = locationGrid.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                dataAccess.DeleteLocation(selId);
                    var Location = dataAccess.getAllLocations();
                    locationGrid.DataSource = null;
                    locationGrid.DataSource = Location;
                    locationGrid.Refresh();
                var serlist = dataAccess.GetAllServicesView();
                serviceGrid.DataSource = null;
                serviceGrid.DataSource= serlist;
                serviceGrid.Refresh();

            }
        }
    }

       
}

