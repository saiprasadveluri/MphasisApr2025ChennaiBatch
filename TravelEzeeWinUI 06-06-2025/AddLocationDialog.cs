using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeWinUI2
{
    public partial class AddLocationDialog : Form
    {
        DataAccess dataAccess;

        
        public AddLocationDialog()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            // Get Available Max Id.
            long NextLocationId = 1;
            var locationlist = dataAccess.GetAllLocations();
            if (locationlist.Count > 0) { 
                long AvailableMaxId=locationlist.Max(l=> l.LocationId);
                NextLocationId = AvailableMaxId+1;
            }
            string locName= txtLocationName.Text;
            string locDescription= txtDescription.Text;
            bool Status = dataAccess.AddLocation(NextLocationId, locName, locDescription);
            if (Status) {
                MessageBox.Show("Success in adding New Location");
            }
            else
            {
                MessageBox.Show("Error in adding New Location");
            }
        }
    }
}
