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
    public partial class AddLocation : Form
    {
        DataAccess dataAccess = new DataAccess();
        public AddLocation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long locId = Convert.ToInt64(textBox1.Text);
                string locName = textBox2.Text;
                string locDes = textBox3.Text;
                dataAccess.AddLocation(locId, locName, locDes);
                MessageBox.Show("Location added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding location: " + ex.Message);
            }
            finally
            {
                this.Close();
            }

        }
    }
}
