using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTravelEFWin
{
    public partial class SearchList : Form
    {
        DataAccess dataAccess;
        public SearchList()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void SearchList_Load(object sender, EventArgs e)
        {
            List<Location> locations = dataAccess.GetAllLocations();

            Location[] locs = new Location[locations.Count];
            locations.ToArray().CopyTo(locs, 0);

            comboBoxSource.DataSource = locations;
            comboBoxSource.DisplayMember = "LocationName";

            List<Location> destlocations = locs.ToList();
            comboBoxDestination.DataSource = destlocations;
            comboBoxDestination.DisplayMember = "LocationName";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Location src = comboBoxSource.SelectedItem as Location;
            Location dest = comboBoxDestination.SelectedItem as Location;
            if (src != null && dest != null)
            {

                long srcLocId = src.LocationId;
                long destLocId = dest.LocationId;
                if (srcLocId != destLocId)
                {
                    List<ServiceEntry> srv = dataAccess.GetSearchBasedOnLocation(srcLocId, destLocId);
                    GridSearch.DataSource = srv;
                    GridSearch.DataSource = null;
                    GridSearch.Refresh();
                }
            }
        }
    }
}
