using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace TravelManagement.Classes
{
    public class DataAccess
    {
        private const string ConnectionString = "Data Source=DESKTOP-O3SKLBE\\SQLEXPRESS;Initial Catalog=AdvTravelEzeeDB;Integrated Security=SSPI;Trust Server Certificate=True";
        DataSet dataSet;
        SqlDataAdapter locationDataAdapter1;
        SqlDataAdapter locationDataAdapter2;
        SqlDataAdapter locationDataAdapter3;
        private DataAccess()
        {
            dataSet = new DataSet();
            locationDataAdapter1 = new SqlDataAdapter("select *from Location", ConnectionString);
            locationDataAdapter2 = new SqlDataAdapter("select *from ServiceTypeNew", ConnectionString);
            locationDataAdapter3 = new SqlDataAdapter("select *from Service", ConnectionString);
        }
        public static DataAccess _dataAccessInstance;
        public static DataAccess DataAccessInstance
        {
            get
            {
                if (_dataAccessInstance == null)
                {
                    _dataAccessInstance = new DataAccess();
                }
                return _dataAccessInstance;
            }
        }
        //Service Crud Operations
        public bool AddService(string ServiceText)
        {
            if (string.IsNullOrEmpty(ServiceText))
            {
                Console.WriteLine("enter Service Distance");
            }
            var dtServ1 = dataSet.Tables["Service"];
            var dr = dtServ1.NewRow();
            dr[0] = Guid.NewGuid();
            dr[1] = Guid.NewGuid();
            dr[2]= Guid.NewGuid();
            dr[3] = ServiceText;
            dtServ1.Rows.Add(dr);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(locationDataAdapter3);
            locationDataAdapter3.Update(dataSet, "Service");
            return true;
        }
        public DataTable GetAllServices()
        {
            locationDataAdapter3.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            locationDataAdapter3.Fill(dataSet, "Service");
            return dataSet.Tables["Service"];
        }

        //Service Type Crud Operations
        public bool AddServiceType(string ServiceTypeText)
        {
            if (string.IsNullOrEmpty(ServiceTypeText))
            {
                Console.WriteLine("enter ServiceTypeText");
            }
            var dtServ = dataSet.Tables["ServiceTypeNew"];
            var dr = dtServ.NewRow();
            dr[0] = Guid.NewGuid();
            dr[1] = ServiceTypeText;
            dr[2] = ServiceType.PricePerKm;
            dtServ.Rows.Add(dr);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(locationDataAdapter2);
            locationDataAdapter2.Update(dataSet, "ServiceTypeNew");
            return true;
        }
        public DataTable GetAllServiceType()
        {
            locationDataAdapter2.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            locationDataAdapter2.Fill(dataSet, "ServiceTypeNew");
            return dataSet.Tables["ServiceTypeNew"];
        }
        public bool DeleteServiceType(string serviceId)
        {
            var serviceTable = dataSet.Tables["ServiceTypeNew"];
            if (serviceTable != null)
            {
                var CurService = serviceTable.AsEnumerable().FirstOrDefault(ser => ser.Field<Guid>(0) == Guid.Parse(serviceId));
                if (CurService != null)
                {
                    CurService.Delete();
                    locationDataAdapter2.Update(dataSet, "ServiceTypeNew");
                    return true;
                }
            }
            return false;

        }

        //Location Crud Operations
        public bool AddLocation(string LocName)
        {
            if (string.IsNullOrEmpty(LocName))
            {
                Console.WriteLine("enter location name");
            }
            var dtLoc = dataSet.Tables["Loc"];
            var dr = dtLoc.NewRow();
            dr[0] = Guid.NewGuid();
            dr[1] = LocName;
            dtLoc.Rows.Add(dr);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(locationDataAdapter1);
            locationDataAdapter1.Update(dataSet, "Loc");
            return true;
        }
        public DataTable GetAllLocations()
        {
            locationDataAdapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            locationDataAdapter1.Fill(dataSet, "Loc");
            return dataSet.Tables["Loc"];
        }
        public bool DeleteLocation(string locationId)
        {
            var LocationTable = dataSet.Tables["Locations"];
            if (LocationTable != null)
            {
                var CurLocation = LocationTable.AsEnumerable().FirstOrDefault(loc => loc.Field<Guid>(0) == Guid.Parse(locationId));
                if (CurLocation != null)
                {
                    CurLocation.Delete();
                    locationDataAdapter1.Update(dataSet, "Locations");
                    return true;
                }
            }
            return false;
        }
    }
}
