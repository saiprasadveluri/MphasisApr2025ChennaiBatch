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
    public partial class btnSerType : Form
    {
        DataAccess dataAccess;
        public btnSerType()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void AddServiceType_Click(object sender, EventArgs e)
        {
            long NextSertypeId = 1;
            var servicetypeList=dataAccess.GetAllServiceTypes();
            if(servicetypeList.Count>0 )
            {
                long AvailMaxId = servicetypeList.Max(st => st.STypeId);
                NextSertypeId = AvailMaxId + 1;
            }
            string sertype=txtSerTypeName.Text;
            decimal price=PricePerKm.Value;
            bool Status = dataAccess.AddServiceType(NextSertypeId, sertype, (double)price);
            if(Status)
            {
                MessageBox.Show("Added ServiceType");
            }
            else
            {
                MessageBox.Show("Failed to Add ServiceType");
            }
        }
    }
}
