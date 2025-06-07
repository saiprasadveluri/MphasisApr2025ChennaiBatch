using DataAccessLayer;
using DataAccessLayer.Migrations;

namespace EzeeTravelWinUI
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
            dataGridView1.DataSource = locations;
            //Service TYpes
            List<ServiceType> srvTypes = dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = srvTypes;
            //Service Grid
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            servicesGrid.DataSource = srvList;

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocationDialog addLocDialog = new AddLocationDialog();
            addLocDialog.ShowDialog();
            //Update Grid
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();
            dataGridView1.DataSource = locations;
            dataGridView1.DataSource = null;

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

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewServiceDialog addNewServiceDialog = new AddNewServiceDialog();
            addNewServiceDialog.ShowDialog();
            DataAccess dataAccess = new DataAccess();
            List<ServiceEntry> srvList = dataAccess.GetAllServicesView();
            servicesGrid.DataSource = null;
            servicesGrid.DataSource = srvList;

        }


        private void deleteLocationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var SelRow = dataGridView1.SelectedRows[0];
                int SelId = int.Parse(SelRow.Cells[0].Value.ToString());
                DataAccess dataAccess = new DataAccess();
                dataAccess.DeleteLocation(SelId);

                var LocationList = dataAccess.GetAllLocations;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = LocationList;
                dataGridView1.Refresh();
            }
        }

        private void deleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataAccess dataACcess = new DataAccess();
            if (servicesGrid.SelectedRows.Count > 0)
            {
                var SelRow = servicesGrid.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                DataAccess dataAccess = new DataAccess();
                dataAccess.DeleteService(selId);
                var service = dataAccess.GetAllServicesView();
                servicesGrid.DataSource = null;
                servicesGrid.DataSource = service;
                servicesGrid.Refresh();
            }
        }

        private void deleteServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelRow = serviceTypeGrid.SelectedRows[0];
            int selId = int.Parse(SelRow.Cells[0].Value.ToString());
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteServiceType(selId);
            var ServiceTypeList= dataAccess.GetAllServiceTypes();
            serviceTypeGrid.DataSource = null;
            serviceTypeGrid.DataSource = ServiceTypeList;
            serviceTypeGrid.Refresh();


            var serviceList = dataAccess.GetAllServicesView();
            servicesGrid.DataSource = null;
            servicesGrid.DataSource = serviceList;
            servicesGrid.Refresh();
           
          
        }
    }
}
