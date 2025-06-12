using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Security.Cryptography.X509Certificates;
using BlogWebApp1.DTO;

namespace BlogWebApp1.Data
{
    public class DBAccess : IDisposable
    {
        SqlConnection sqlConnection;
        public DBAccess() {
            string conString = WebConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;
            sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (sqlConnection != null)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        public void Dispose() { 
            CloseConnection();
        }

        public bool ValidateUser(string email, string password, out long UserId) {
            UserId = 0;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from UserData where Email=@email AND Password = @password";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
              
                reader.Read();
                UserId = reader.GetInt64(0);
                reader.Close();
                return true;
            }
            else {
                reader.Close();
                return false;
            }
        }

        public List<BlogPost> GetAllPosts() { 
            List<BlogPost> lstposts =new List<BlogPost>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Select * from BlogPost";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) { 
                BlogPost entry = new BlogPost();
                entry.PostId = reader.GetInt64(0);
                entry.PostTitle = reader.GetString(1);
                entry.PostText = reader.GetString(2);
                entry.PostedBy = reader.GetString(3);
                lstposts.Add(entry);                
            }
            reader.Close();
            return lstposts;
        }
        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> lstcomment = new List<BlogComment>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Select * from BlogComment";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogComment entry = new BlogComment();
                entry.PostId = reader.GetInt64(0);
                entry.Title = reader.GetInt64(1).ToString();
                entry.CommentText = reader.GetString(2);
                entry.CommentBy = reader.GetString(3);
                lstcomment.Add(entry);
            }
            reader.Close();
            return lstcomment;
        }

        public bool AddBlogPost(long UserId, string PostTitle, string PostText) {
            string SqlText = $"INSERT INTO BlogPost(PostTitle, PostText, PostedBy) Values('{PostTitle}','{PostText}','{UserId}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText=SqlText;
            int RowsEffected = sqlCommand.ExecuteNonQuery();
            return RowsEffected > 0;

        }
        public bool AddBlogComment(long PostId, string Title, string CommentText, long UserId)
        {
            string SqlText = "INSERT INTO BlogComment (PostId, Title, CommentText, CommentBy) VALUES (@PostId, @Title, @CommentText, @UserId)";

            using (SqlCommand sqlCommand = new SqlCommand(SqlText, sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@PostId", PostId);
                sqlCommand.Parameters.AddWithValue("@Title", Title);
                sqlCommand.Parameters.AddWithValue("@CommentText", CommentText);
                sqlCommand.Parameters.AddWithValue("@UserId", UserId);

                int RowsEffected = sqlCommand.ExecuteNonQuery();
                return RowsEffected > 0;
            }
        }
    }
}