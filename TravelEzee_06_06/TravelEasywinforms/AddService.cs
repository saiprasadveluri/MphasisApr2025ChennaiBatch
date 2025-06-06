using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEasyDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelEasywinforms
{
    public partial class AddService : Form
    {
        DataAccess dataAccess = new DataAccess();
        public AddService()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataAccess.GetServiceTypes();


        }

        public List<ServiceType> GetServiceTypes()
        {
            using (var dbContext = new TravelEzeeEFContext())
            {
                return dbContext.ServiceTypes.ToList();
            }
        }
        public List<Location> GetLocations()
        {
            using (var dbContext = new TravelEzeeEFContext())
            {
                return dbContext.Locations.ToList();
            }
        }

        private void AddService_Load(object sender, EventArgs e)
        {

            List<ServiceType> serviceTypes = GetServiceTypes();
            comboBox2.DataSource = serviceTypes;
            comboBox2.DisplayMember = "ServiceTypeName"; 
            comboBox2.ValueMember = "ServiceTypeId";

            List<Location> locations = GetLocations();
            comboBox3.DataSource = locations;
            comboBox3.DisplayMember = "LocationName";
            comboBox3.ValueMember = "LocationId";

            List<Location> locations2 = GetLocations();
            comboBox4.DataSource = locations2;
            comboBox4.DisplayMember = "LocationName";
            comboBox4.ValueMember = "LocationId";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataAccess.AddService(
                Convert.ToInt64(textBox1.Text),
                Convert.ToInt64(comboBox2.SelectedValue),
                Convert.ToInt64(comboBox3.SelectedValue),
                Convert.ToInt64(comboBox4.SelectedValue),
                Convert.ToDouble(numericUpDown1.Text)
            );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Service added successfully!");
                this.Close();
            }
        }
    }
}
