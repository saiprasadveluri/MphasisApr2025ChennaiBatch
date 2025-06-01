using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manageLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocation newLocation = new NewLocation();
            newLocation.ShowDialog();
        }

        private void manageServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewServices newServices = new NewServices();
            newServices.ShowDialog();
        }

        private void manageServiceTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewServiceType newServiceType = new NewServiceType();
            newServiceType.ShowDialog();
        }
    }
}
