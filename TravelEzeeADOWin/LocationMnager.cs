using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeADOWin
{
    public partial class LocationMnager : Form
    {
        public LocationMnager()
        {
            InitializeComponent();
        }

        private void AddLocation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LocationName.Text))
            {
                DataAccess.Instance.AddLocation(LocationName.Text);
                
                locationGrid.DataSource = DataAccess.Instance.GetAllLocations();
            }
        }

        private void LocationMnager_Load(object sender, EventArgs e)
        {
            locationGrid.DataSource = DataAccess.Instance.GetAllLocations();
            locationGrid.Refresh();
        }

        private void deleteLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (locationGrid.SelectedRows.Count > 0)
            {
                string LocId = locationGrid.SelectedRows[0].Cells[0].Value.ToString();
                DataAccess.Instance.DeleteLocation(LocId);
                locationGrid.DataSource = DataAccess.Instance.GetAllLocations();
                locationGrid.Refresh();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
