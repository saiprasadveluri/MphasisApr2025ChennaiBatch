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
    public partial class EditLocation : Form
    {
        DataAccess dataAccess;
        public long LocId;




        public EditLocation(DataAccess _dataAccess, long locId)
        {
            InitializeComponent();
            dataAccess = _dataAccess;
            LocId = locId;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            string LocationName = txtLocation.Text;
            bool status = dataAccess.EditLocations(LocId, LocationName);
            if (status)
            {
                MessageBox.Show("Location updated");
            }
            else 
            {
                MessageBox.Show("Location not updated");
            }

        }
    }
}
