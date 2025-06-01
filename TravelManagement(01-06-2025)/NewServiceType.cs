using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelManagement.Classes;

namespace TravelManagement
{
    public partial class NewServiceType : Form
    {
        DataAccess dataAccess;
        public NewServiceType()
        {
            dataAccess=DataAccess.DataAccessInstance;
            InitializeComponent();
        }

        private void SaveServiceTypeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textServiceType.Text))
            {
                string ServName = textServiceType.Text;
                dataAccess.AddServiceType(ServName);

                var ServList = dataAccess.GetAllServiceType();
                gridServiceType.DataSource = ServList;
            }
        }

        private void NewServiceType_Load(object sender, EventArgs e)
        {
            var ServList = dataAccess.GetAllServiceType();
            gridServiceType.DataSource = ServList;
            gridServiceType.Refresh();
        }

        private void deleteServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridServiceType.SelectedRows.Count > 0)
            {
                string ServId = gridServiceType.SelectedRows[0].Cells[0].Value.ToString();
                dataAccess.DeleteServiceType(ServId);
                gridServiceType.DataSource = dataAccess.GetAllServiceType();
                gridServiceType.Refresh();
            }
        }
    }
}
