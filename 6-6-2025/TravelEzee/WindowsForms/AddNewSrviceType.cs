using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelEzeeWinFormUI
{
    public partial class AddNewSrviceType : Form
    {
        public AddNewSrviceType()
        {
            InitializeComponent();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            decimal price = txtPrice.Value;
            string TypeName = txtTypeName.Text;
            DataAccess dataAccess = new DataAccess();
            bool AddServiceType=dataAccess.AddServiceType(TypeName, (double)price);
            if (AddServiceType)
            {
                MessageBox.Show("Success in adding new Service");
            }
            else
            {
                MessageBox.Show("Error in adding new Service");
            }
        }
    }
}
