using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using ASP.NetDEMO212june2025.DTO;

namespace ASP.NetDEMO212june2025.Data
{
    public class DBAccess : IDisposable
    {
        SqlConnection SqlConnection;
        public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;
            SqlConnection = new SqlConnection(conString);
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
        public bool ValidateUser(string email, string password, out long UserId)
        {
            UserId = 0;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "select * from UserData where Email=@email AND Password=@password";
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
            else
            {
                reader.Close();
                return false;
            }

        }
        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> blogCommentsList = new List<BlogComment>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "select * from BlogComment";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogComment blogComment = new BlogComment();
                blogComment.CommentId = reader.GetInt64(0);
                blogComment.PostId = reader.GetInt64(1);
                blogComment.Title = reader.GetString(2);
                blogComment.CommentTest = reader.GetString(3);
              
                blogCommentsList.Add(blogComment);
            }
            reader.Close();
            return blogCommentsList;
        }

        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> lstPosts = new List<BlogPost>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "Select * from BloPost";
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

        public bool AddBlogPost(long UserId, string Title, string PostText)
        {
            string sqltext = $"insert into BlogPost(Title,PostText,PostedBy) values('{Title}','{PostText}',{UserId})";
            SqlCommand cmd = new SqlCommand(sqltext);
            cmd.Connection = SqlConnection;
            int effected = cmd.ExecuteNonQuery();
            if (effected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddComment(long PostId, string commentTitle, string commentText, long commentBy)
        {
            string AddComment = $"insert into BlogComment(PostId,Title,CommentText,CommentBy)Values({PostId},'{commentTitle}','{commentText}',{commentBy})";
            SqlCommand cmd = new SqlCommand(AddComment);
            cmd.Connection = SqlConnection;
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
    }
}