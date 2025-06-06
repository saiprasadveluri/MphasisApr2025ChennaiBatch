using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTravelEFWin
{
    public partial class NewServiceTypes : Form
    {
        DataAccess dataAccess;
        public NewServiceTypes(DataAccess _dataAccess)
        {
            InitializeComponent();
            dataAccess = _dataAccess;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string srvName = txtServiceTypeName.Text;
            double perkm = double.Parse(txtPricePerKm.Text);
            bool status = dataAccess.AddServiceType(srvName, perkm);
            if(status)
            {
                MessageBox.Show("ServiceType Added");
            }
            else
            {
                MessageBox.Show("ServiceType not Added");
            }

        }
    }
}
