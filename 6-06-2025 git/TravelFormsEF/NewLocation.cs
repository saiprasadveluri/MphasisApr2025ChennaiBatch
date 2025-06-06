using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelFormsEF
{
    public partial class NewLocation : Form
    {
        DataAccess dataAccess;
        public NewLocation()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            long NextLocationId = 1;
            var locationList=dataAccess.GetAllLocations();
            if (locationList.Count > 0)
            {
                long AvailMaxId=locationList.Max(l=>l.LocationId);
                NextLocationId = AvailMaxId + 1;
            }
            string locName=txtLocName.Text;
            string Descr=txtDescription.Text;
            bool Status = dataAccess.AddLocation(NextLocationId, locName, Descr);
            if(Status)
            {
                MessageBox.Show("Location Added");
            }
            else
            {
                MessageBox.Show("Failed to Add Location");
            }
        }
    }
}
