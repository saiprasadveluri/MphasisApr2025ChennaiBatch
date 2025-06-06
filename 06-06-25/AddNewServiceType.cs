using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEzeeWinUI
{
    public partial class AddNewServiceType : Form
    {
        public AddNewServiceType()
        {
            InitializeComponent();

        }

       private void btnAddNewType_Click(object sender, EventArgs e)
{
            decimal price = numericPrice.Value;
            string ServiceType = txtServiceType.Text;
            DataAccess dataAccess = new DataAccess();
            bool Status = dataAccess.AddServiceType(ServiceType, (double)price);
            if (Status)
            {
                MessageBox.Show("Success....in adding new services");

            }
            else
            {
                MessageBox.Show("Error....in adding new services");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewServiceType_Load(object sender, EventArgs e)
        {

        }
    }
}
