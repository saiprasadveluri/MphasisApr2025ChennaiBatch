using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzzCoreConsole2
{
    public partial class EditLocation : Form
    {
        public DataAccess dataAccess;
        public long LocId;
        public EditLocation(DataAccess _dataAccess,long locId )
        {
            InitializeComponent();
            dataAccess = _dataAccess;
            LocId = locId;

        }

        private void LocationEditButton_Click(object sender, EventArgs e)
        {
            string LocName = txtLocationName.Text;
            bool status = dataAccess.UpdateLocation(LocId, LocName);
            if (status)
            {
                MessageBox.Show("Location Updated");
            }
            else
            {
                MessageBox.Show("Location Not  Updated");

            }
        }
    }
}
