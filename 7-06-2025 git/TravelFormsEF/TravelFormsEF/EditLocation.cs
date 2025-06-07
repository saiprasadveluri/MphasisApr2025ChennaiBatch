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
    public partial class EditLocation : Form
    {
        DataAccess dataAccess;
        long locId;
        public EditLocation(long lId)
        {
            dataAccess = new DataAccess();
            InitializeComponent();
            locId = lId;
           
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
          
           
            string lname= txtLocName.Text;
            bool status=dataAccess.EditLocation(locId, lname);
            if(status) 
            {
                MessageBox.Show("Location updated");
            }
            else
            {
                MessageBox.Show("Cannot updated");
            }

        }
    }
}
