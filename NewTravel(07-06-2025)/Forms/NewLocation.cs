using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTravelEF
{
    public partial class NewLocation : Form
    {
        DataAccess dataAccess;
        public NewLocation()
        {
            dataAccess= new DataAccess();
            InitializeComponent();
        }

        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            long NextLocationId = 1;
            var locationList=dataAccess.GetAllLocations();
            if(locationList.Count>0)
            {
                long AvailableMaxId=locationList.Max(l=>l.LocationId);
                NextLocationId = AvailableMaxId+1;
            }
            string locName=textLocationName.Text;
            string locDes = textLocationDescription.Text;
            bool status=dataAccess.AddLocation(NextLocationId,locName, locDes);
            if(status)
            {
                MessageBox.Show("Location Added");
            }
            else
            {
                MessageBox.Show("Location Not Added");
            }
        }
    }
}
