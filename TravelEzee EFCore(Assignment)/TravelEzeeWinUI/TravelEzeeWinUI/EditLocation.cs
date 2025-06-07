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

namespace TravelEzeeWinUI
{
    public partial class EditLocation : Form
    {
        DataAccess dataAccess;
        public long LocId;
       
        public EditLocation(DataAccess _dataAccess,long locId)
        {
            InitializeComponent();
            dataAccess = _dataAccess;
            LocId = locId;
        }
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string LocName=txtLocation.Text;
            bool status = dataAccess.EditLocations(LocId, LocName);
            if (status)
            {
                MessageBox.Show("Location Updated");
            }
            else
            {
                MessageBox.Show("Location Not Updated");
            }
        }
    }
}
