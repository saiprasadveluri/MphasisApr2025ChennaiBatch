namespace TravelFormsEF
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
            dataAccess = new DataAccess();
            GridLocations.DataSource = dataAccess.GetAllLocations();
            GridServiceType.DataSource = dataAccess.GetAllServiceTypes();
            GridServices.DataSource = dataAccess.GetAllServicesView();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocation loc = new NewLocation();
            loc.ShowDialog();
            dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            GridLocations.DataSource = null;
            GridLocations.DataSource = locations;
        }

        private void addServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        { //New Service type
            btnSerType sertype = new btnSerType();
            sertype.ShowDialog();
            dataAccess = new DataAccess();
            List<ServiceType> serviceTypes = dataAccess.GetAllServiceTypes();
            GridServiceType.DataSource = null;
            GridServiceType.DataSource = serviceTypes;

        }

        private void addServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewService service = new NewService();
            service.ShowDialog();
            List<ServiceEntry> services = dataAccess.GetAllServicesView();
            GridServices.DataSource = null;
            GridServices.DataSource = services;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridLocations.SelectedRows.Count > 0)
            {
                var delrow=GridLocations.SelectedRows[0];
                int srv=int.Parse(delrow.Cells[0].Value.ToString());
                dataAccess.DeleteLocation(srv);
                var locList = dataAccess.GetAllLocations();
                GridLocations.DataSource = null;
                GridLocations.DataSource = locList;
                GridLocations.Refresh(); 
                var serlist=dataAccess.GetAllServicesView();
                GridServices.DataSource= null;
                GridServices.DataSource= serlist;
                GridServices.Refresh();
               
            }
        }
    }
}
