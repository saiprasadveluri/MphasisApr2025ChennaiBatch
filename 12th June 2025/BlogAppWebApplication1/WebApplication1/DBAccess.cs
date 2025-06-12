using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplication1.DTO;

namespace WebApplication1
{
    public class DBAccess:IDisposable
    {
        SqlConnection sqlConnection;
        public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;
            sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
        }
        public void CloseConnection()
        {
            if(sqlConnection != null)
            {
                if(sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Close();
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
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from UserData where Email=@email AND Password=@password";
            sqlCommand.Parameters.AddWithValue("email", email);
            sqlCommand.Parameters.AddWithValue("password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
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
            string sqlTxt = "select * from BlogPost";
            List<BlogPost> lstPosts = new List<BlogPost>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sqlTxt;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogPost entry = new BlogPost();
                entry.PostId = sqlDataReader.GetInt64(0);
                entry.Title = sqlDataReader.GetString(1);
                entry.PostText = sqlDataReader.GetString(2);
                lstPosts.Add(entry);
            }
            sqlDataReader.Close();
            return lstPosts;
        }
        public List<Comments> GetAllComments()
        {
            string sqlTxt = "select * from Comments";
            List<Comments> lstComments = new List<Comments>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sqlTxt;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Comments entry = new Comments();
                entry.CommentId = sqlDataReader.GetInt64(0);
                entry.PostId = sqlDataReader.GetInt64(1);
                entry.Title =  sqlDataReader.GetString(2);
                entry.CommentText = sqlDataReader.GetString(3);
                lstComments.Add(entry);
            }
            sqlDataReader.Close();
            return lstComments;
        }
        public bool AddBlogPost(long UserId, string Title, string PostText)
        {
            string SqlText = $"INSERT INTO BlogPost (Title,PostText,PostedBy) VALUES('{Title}','{PostText}',{UserId})";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = SqlText;
            int rowsEffected = sqlCommand.ExecuteNonQuery();
            return (rowsEffected > 0);

        }
        public bool AddComments(long UserId,long PostId, string Title, string  CommentText)
        {
            string SqlTxt = $"INSERT INTO Comments (PostId,Title,CommentText,CommentedBy) VALUES({PostId},'{Title}','{CommentText}',{UserId})";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = SqlTxt;
            int rowsEffected = sqlCommand.ExecuteNonQuery();
            return (rowsEffected > 0);
        }
    }
}