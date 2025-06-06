using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsTravelEzee
{
    public partial class AddNewServiceType : Form
    {
       // DataAccess dataAccess;
        public AddNewServiceType()
        {
            //dataAccess = new DataAccess();
            InitializeComponent();
            
        }

        private void btnAddNewType_Click(object sender, EventArgs e)
        {
           decimal price= numericPrice.Value;
            string TypeName=txtTypeName.Text;
            DataAccess dataAccess = new DataAccess();
            bool Status = dataAccess.AddServiceType(TypeName, (double)price);
            if (Status)
            {
                MessageBox.Show("Success in adding servicetype");

            }
            else 
            {
                MessageBox.Show("error ");
            }

        }
    }
}
