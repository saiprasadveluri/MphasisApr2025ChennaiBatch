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
    public partial class NewServiceTypes : Form
    {
        DataAccess dataAccess;
        public NewServiceTypes(DataAccess _dataAccess)
        {
            InitializeComponent();
            dataAccess = _dataAccess;
        }

        private void AddServiceTypeButton_Click(object sender, EventArgs e)
        {
            string srvName=textServiceTypeName.Text;
            double perkm=double.Parse(textPricePerKm.Text);
            bool status=dataAccess.AddServiceType(srvName, perkm);
            if (status)
            {
                MessageBox.Show("ServiceType Added");
            }
            else
            {
                MessageBox.Show("ServiceType Not Added");
            }
        }
    }
}
