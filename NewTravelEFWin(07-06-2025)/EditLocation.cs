using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTravelEFWin
{
    public partial class EditLocation : Form
    {
        DataAccess dataAccess;
        long LocId;
        public EditLocation(DataAccess _dataAccess, long locId)
        {
            dataAccess =_dataAccess;
            InitializeComponent();
            LocId = locId;
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            string LocationName = txtLocName.Text;
            bool status = dataAccess.UpdateLocation(LocId, LocationName);
            if (status)
            {
                MessageBox.Show("Location Updated");
            }
            else
            {
                MessageBox.Show("Located not Updated");
            }
                
        }
    }
}
