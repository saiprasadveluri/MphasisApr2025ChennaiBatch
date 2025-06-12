using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using BlagAppWeb1.DTO;

namespace BlagAppWeb1.Data
{
    public class DBAccess:IDisposable
    {
        SqlConnection SqlConnection;
        public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;
            SqlConnection= new SqlConnection(conString);
            SqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (SqlConnection != null)
            {
                if (SqlConnection.State == ConnectionState.Open)
                {
                    SqlConnection.Close();
                }
            }
        }
        public void Dispose()
        {
            CloseConnection();
        }
        public bool ValidateUser(string email,string password,out long UserId)
        {
            UserId = 0;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "select * from UserData where Email=@email AND Password=@password";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                UserId = reader.GetInt64(0);
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }         

        }

        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> lstPosts= new List<BlogPost>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "Select * from BlogPost";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                BlogPost entry = new BlogPost();
                entry.PostId = sqlDataReader.GetInt64(0);
                entry.Title = sqlDataReader.GetString(1);
                entry.PostText= sqlDataReader.GetString(2);
                lstPosts.Add(entry);
            }
            sqlDataReader.Close();
            return lstPosts;
        }

        public bool AddBlogPost(long UserId,string Title,string PostText)
        {
            string SqlText = $"INSERT INTO BlogPost(Title,PostText,PostedBy) VALUES('{Title}','{PostText}',{UserId})";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = SqlText;
            int RowsEffected = sqlCommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }
    }
}