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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewType_Click(object sender, EventArgs e)
        {
            decimal price = numericPrice.Value;
            string TypeName = txtTypeName.Text;

        }
    }
}
