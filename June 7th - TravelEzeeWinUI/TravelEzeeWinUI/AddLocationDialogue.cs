using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeWinUI
{
    public partial class AddLocationDialogue : Form
    {
        DataAccess dataAccess;
        public AddLocationDialogue()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddloc_Click(object sender, EventArgs e)
        {
            //Get Available Max Id and Add Location DB.
            long NextLocationId = 1;
            var locationlist=dataAccess.GetAllLocations();
            if (locationlist.Count > 0)
            {
                long AvailableMaxId=locationlist.Max(l=>l.LocationId);
                NextLocationId = AvailableMaxId + 1;
            }
            string locName=txtLocation.Text;
            string locDescription = txtDescription.Text;
            bool Status=dataAccess.AddLocation(NextLocationId, locName, locDescription);
            if (Status)
            {
                MessageBox.Show("success in adding new location");
            }
            else
            {
                MessageBox.Show("Error in adding new location");
            }
        }
    }
}
