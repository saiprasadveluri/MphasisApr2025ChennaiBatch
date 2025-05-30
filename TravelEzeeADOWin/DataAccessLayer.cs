using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
namespace TravelEzeeADOWin
{
    public class DataAccess
    {
        DataSet dsData;
        string conString = "Data Source=.;Initial Catalog=TravelEzee;Integrated Security=SSPI;Trust Server Certificate=True";

        SqlDataAdapter LocationdataAdapter = null; 
        private DataAccess()
        {
            dsData=new DataSet();
            
            LocationdataAdapter = new SqlDataAdapter("Select * from Locations", conString);
            
        }

        private static DataAccess dataAccess;
        public static DataAccess Instance
        {
            get
            {
                if (dataAccess == null)
                {
                    dataAccess = new DataAccess();
                }
                return dataAccess;
            }
        }
        public DataTable GetAllLocations()
        {
            LocationdataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            LocationdataAdapter.Fill(dsData, "Locations");            
            return dsData.Tables["Locations"];
        }

        public bool AddLocation(string location)
        {
           var LocationTable= dsData.Tables["Locations"];
           var NewLocationRow= LocationTable.NewRow();
            NewLocationRow[0] = Guid.NewGuid();
            NewLocationRow[1] = location;
            LocationTable.Rows.Add(NewLocationRow);
            SqlCommandBuilder locationBuilde= new SqlCommandBuilder(LocationdataAdapter);           
            LocationdataAdapter.Update(dsData, "Locations");
            
            return true;
        }

        public bool DeleteLocation(string locationId)
        {
            var LocationTable = dsData.Tables["Locations"];
            if (LocationTable != null)
            {
              var CurLocation=  LocationTable.AsEnumerable().FirstOrDefault(loc=>loc.Field<Guid>(0)==Guid.Parse(locationId));
                if (CurLocation != null)
                {
                    CurLocation.Delete();
                    LocationdataAdapter.Update(dsData, "Locations");
                    return true;
                }
            }
            return false;
        }
    }
}
