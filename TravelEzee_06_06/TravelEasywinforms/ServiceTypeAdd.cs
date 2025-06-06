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
    public partial class ServiceTypeAdd : Form
    {
        DataAccess dataAccess = new DataAccess();
        public ServiceTypeAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //long serId = Convert.ToInt64(textBox1.Text);
                string sertName = textBox2.Text;
                double price = Convert.ToDouble(textBox3.Text);
                dataAccess.AddServiceType(sertName, price);
                MessageBox.Show("ServiceType added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding service type: " + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
