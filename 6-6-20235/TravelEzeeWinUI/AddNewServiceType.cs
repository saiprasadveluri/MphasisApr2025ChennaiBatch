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
        DataAccess da = new DataAccess();
        public AddNewServiceType()
        {
            InitializeComponent();
        }

        private void btnAddSrvType_Click(object sender, EventArgs e)
        {
            var servid = Convert.ToInt64(srvTypeId.Text);
            var servname = txtSrvType.Text;
            var price = Convert.ToDouble(numericUpDown.Text);
            var serv = da.AddServiceType(servid, servname, price);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
