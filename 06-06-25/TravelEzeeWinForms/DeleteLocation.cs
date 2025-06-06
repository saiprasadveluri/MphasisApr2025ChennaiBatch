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

namespace TravelEasywinforms
{
    public partial class DeleteLocation : Form
    {
        DataAccess dataAccess = new DataAccess();
        public DeleteLocation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteLocation_Load(object sender, EventArgs e)
        {
            List<Location> list = dataAccess.GetLocations();
            comboBox1.DataSource = list;
            comboBox1.ValueMember = "LocationId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long locid = Convert.ToInt64(comboBox1.SelectedValue);
                dataAccess.DeleteLocation(locid);
                MessageBox.Show("Location deleted successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                this.Close();
            }
        }
    }
}
