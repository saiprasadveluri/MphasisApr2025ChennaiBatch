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
    public partial class NewServices : Form
    {
        DataAccess dataAccess;
        public NewServices()
        {
            dataAccess=DataAccess.DataAccessInstance;
            InitializeComponent();
        }

        private void SaveServiceButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textDistance.Text))
            {
                string Distance = textDistance.Text;
                dataAccess.AddService(Distance);

                var ServLists = dataAccess.GetAllServices();
                gridService.DataSource = ServLists;
            }
        }

        private void NewServices_Load(object sender, EventArgs e)
        {
            var ServLists = dataAccess.GetAllServices();
            gridService.DataSource = ServLists;
            gridService.Refresh();
        }
    }
}
