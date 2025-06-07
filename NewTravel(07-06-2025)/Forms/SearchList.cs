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

namespace NewTravelEF
{
    public partial class SearchList : Form
    {
        DataAccess dataAccess;
        public SearchList(DataAccess _dataAccess)
        {
            InitializeComponent();
            dataAccess = _dataAccess;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Location srcLoc = SourceBox.SelectedItem as Location;
            Location destLoc = DestinationBox.SelectedItem as Location;
            if (srcLoc != null && destLoc != null)
            {
                long SrcId = srcLoc.LocationId;
                long DestId = destLoc.LocationId;
                if (SrcId != DestId)
                {
                    List<ServiceEntry> srv = dataAccess.GetServicesBasedonLocationView(SrcId, DestId);

                    //List<ServiceEntry> serviceList = dataAccess.GetAllServicesView();
                    SearchGrid.DataSource = null;
                    SearchGrid.DataSource = srv;
                    SearchGrid.Refresh();
                }
            }
        }

        private void SearchList_Load(object sender, EventArgs e)
        {
            List<Location> locations = dataAccess.GetAllLocations();

            Location[] locs = new Location[locations.Count];
            locations.ToArray().CopyTo(locs, 0);

            SourceBox.DataSource = locations;
            SourceBox.DisplayMember = "LocationName";

            List<Location> locations1 = locs.ToList();
            DestinationBox.DataSource = locations1;
            DestinationBox.DisplayMember = "LocationName";
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SearchGrid.SelectedRows.Count > 0)
            {
                var SelRow = SearchGrid.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                //Booking booking = new Booking(dataAccess, selId);
               // booking.ShowDialog();

                //var LocationList = dataAccess.GetAllLocations();
                //SearchGrid.DataSource = null;
                //SearchGrid.DataSource = LocationList;
                //SearchGrid.Refresh();
            }
            
        }
    }
}
