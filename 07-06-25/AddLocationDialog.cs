using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEzeeWinUIConsole;

namespace TravelEzeeWinUI
{
    public partial class AddLocationDialog : Form
    {
        DataAccess dataAccess;
        public AddLocationDialog()
        {
            dataAccess = new DataAccess();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long NextLocationId = 1;
            var locationList = dataAccess.GetAllLocations();
            if (locationList.Count > 0)
            {
                long AvailableMaxId = locationList.Max(l => l.LocationId);
                NextLocationId = AvailableMaxId + 1; ;
            }
            string locName = txtlocationName.Text;
            string locDescr = txtDescription.Text;
            bool Status = dataAccess.AddLocation(NextLocationId, locName, locDescr);
            if (Status)
            {
                MessageBox.Show("Success in Adding New Location");
            }
            else
            {
                MessageBox.Show("Error in Adding New Location");
            }
        }

            //public bool AddServiceType(string Name,double price)
            //{
                //var typeList = ContextBoundObject.ServiceType.ToList();
    //            long NextAvailId = 1;
    //            if (typeList.Count > 0)
    //            {
    //                NextAvailId = typeList.Count + 1;
    //            }
    //            AddNewServiceType srvType = new AddNewServiceType();
    //            ServiceTypeName = Name;
    //            PricePerKm = price;

    //        };
    //        ContextBoundObject.ServiceType.Add(srvType);
    //        int RecEffected = ContextBoundObject.SaveChanges();
    //        if (RecEffected > 0)
    //        {
    //            return true;
    //        }
    //        else return false;
    }
}
