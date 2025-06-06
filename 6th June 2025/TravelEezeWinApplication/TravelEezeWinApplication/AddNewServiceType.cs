using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEezeWinApplication
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
            string TypeName = txtServiceTypeName.Text;
            DataAccess dataAccess = new DataAccess();
            bool Status = dataAccess.AddServiceType(TypeName, (double)price);
            if (Status)
            {
                MessageBox.Show("Success.. in adding new Type");
            }
            else
            {
                MessageBox.Show("Failed to add new Type");
            }

        }

        private void AddNewServiceType_Load(object sender, EventArgs e)
        {

        }
    }
}
