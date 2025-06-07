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
    public partial class ServiceSearch : Form
    {
        public ServiceSearch()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();

            Location[] locs = new Location[locations.Count];
            locations.ToArray().CopyTo(locs, 0);

            cmbSrcS.DataSource = locations;
            cmbSrcS.DisplayMember = "LocationName";

            List<Location> locations1 = locs.ToList();
            cmbDesS.DataSource = locations1;
            cmbDesS.DisplayMember = "LocationName";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Location srcLoc = cmbSrcS.SelectedItem as Location;
            Location destLoc = cmbDesS.SelectedItem as Location;
            if (srcLoc != null && destLoc != null)
            {
                string SrcId = srcLoc.LocationName;
                string DestId = destLoc.LocationName;
                if (SrcId != DestId)
                {
                    DataAccess dataAccess = new DataAccess();
                    List<ServiceEntry> ser = dataAccess.GetServicesBasedOnLocation(srcLoc.LocationId, destLoc.LocationId);
                    GridSearch.DataSource = ser;
                    GridSearch.Columns.Clear();
                    DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Service Id",
                        DataPropertyName = "ServiceId"
                    };
                    DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "ServiceTypeName",
                        DataPropertyName = "ServiceTypeName"
                    };
                    DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Distance",
                        DataPropertyName = "Distance"
                    };
                    DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "TotalCharge ",
                        DataPropertyName = "TotalCharge"
                    };

                    var col5 = new DataGridViewButtonColumn()
                    {
                        HeaderText = "Book Ticket",
                        //CellTemplate = CellTemplate,
                        Text="Book"
                    };                   
                    
                    GridSearch.Columns.Add(col1);
                    GridSearch.Columns.Add(col2);
                    GridSearch.Columns.Add(col3);
                    GridSearch.Columns.Add(col4);

                    GridSearch.Columns.Add(col5);                }

            }
            else
            {
                MessageBox.Show("No Services");
            }

        }

        private void ServiceSearch_Load(object sender, EventArgs e)
        {
            
        }

        

        private void GridSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long srvId = Int64.Parse(GridSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show(srvId.ToString());
            }
        }

        
    }
}
