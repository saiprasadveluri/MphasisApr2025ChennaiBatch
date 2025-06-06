using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinformsTravelEzee
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
            //get available max id and add location to db
            long NextLocationId = 1;
            var locationList = dataAccess.getAllLocations();
            if (locationList.Count > 0)
            {
               long AvailableMaxId= locationList.Max(l => l.LocationId);
                NextLocationId = AvailableMaxId+1;
            }
            string locName=txtlocationName.Text;
            string locDescr=txtDescription.Text;
           bool Status= dataAccess.AddLocation(NextLocationId,locName,locDescr);
            if (Status)
            {
                MessageBox.Show("Success in adding new location");
            }
            else
            {
                MessageBox.Show("error in adding new location");
            }
        }
    }
}
