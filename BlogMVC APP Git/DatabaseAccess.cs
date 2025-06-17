using BlogWebMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Helpers;

namespace BlogWebMVCApp
{
    public class DatabaseAccess:IDisposable
    {
        string SQLConString = "Data Source=.;Initial Catalog=BlogAppDB;Integrated Security=True";
        SqlConnection sqlConnection = null;
        public DatabaseAccess()
        {
            sqlConnection = new SqlConnection(SQLConString);
            sqlConnection.Open();
        }
        public void Dispose()
        {
            if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public bool AddUser(string Email,string Password,string Role)
        {
            string cmdString = $"INSERT INTO USERDATA(Email,Password,UserRole) VALUES('{Email}','{Password}','{Role}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText= cmdString;
            sqlCommand.Connection = sqlConnection;
            int RecCount=sqlCommand.ExecuteNonQuery();
            return RecCount > 0;
        }

        public List<NewUserModel> GetAllUsers()
        {
            List<NewUserModel> outputLIst = new List<NewUserModel>();

            string cmdString = $"SELECT * FROM USERDATA";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdString;
            sqlCommand.Connection = sqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                NewUserModel obj = new NewUserModel()
                {
                    UserId = reader.GetInt64(0),
                    Email = reader.GetString(1),
                    Password = reader.GetString(2),
                    UserRole = reader.GetString(3)
                };
                outputLIst.Add(obj);
            }
            reader.Close();
            return outputLIst;
        }

        public bool DeleteUser(long userId)
        {
            string cmdString = $"DELETE FROM USERDATA WHERE USERID={userId}";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdString;
            sqlCommand.Connection = sqlConnection;
            int RecCount = sqlCommand.ExecuteNonQuery();
            return RecCount > 0;
        }

        public (long,string) ValidateUser(string email,string password)
        {
            long UserId = 0;
            string RoleName = "";
            string cmdString = $"SELECT USERID,UserRole FROM USERDATA WHERE EMAIL='{email}' AND PASSWORD='{password}'";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdString;
            sqlCommand.Connection = sqlConnection;
            //object ret=sqlCommand.ExecuteScalar();
            var reader=sqlCommand.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                UserId= reader.GetInt64(0);
                RoleName= reader.GetString(1);
            }
            reader.Close();

            return (UserId, RoleName);
        }
    }
}