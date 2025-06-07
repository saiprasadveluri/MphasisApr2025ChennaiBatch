using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEeezzWinUI
{
    public partial class EditLocation : Form
    {
        DataAccess dataAccess;
        public long LocationId;
        public EditLocation(DataAccess _dataAccess, long locationId)
        {
            InitializeComponent();
            dataAccess = _dataAccess;
            LocationId = locationId;
        }

        private void EditLocation_Load(object sender, EventArgs e)
        {

        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            string LocationName=txtLocationn.Text;
            bool Status=dataAccess.EditLocation(LocationId, LocationName);
            if (Status)
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
