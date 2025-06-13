using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using BlogAppWeb2.DTO;

namespace BlogAppWeb2.Data
{
    public class DBAccess : IDisposable
    {
        SqlConnection SqlConnection;
        public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings["BloggingApp"].ConnectionString;
            SqlConnection = new SqlConnection(conString);
            SqlConnection.Open();
        }

        public void CloseConnection()
        {
            if(SqlConnection != null)
            {
                if( SqlConnection.State == ConnectionState.Open)
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
            sqlCommand.CommandText = "Select * from UserData where Email=@email AND Password=@password";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@Password", password);
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
                return false;
            }
            
        }

        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> lstPosts = new List<BlogPost>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "Select * from Blog";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogPost entry = new BlogPost();
                entry.BlogPostId = sqlDataReader.GetInt64(0);
                entry.BlogTitle = sqlDataReader.GetString(1);
                entry.BlogText = sqlDataReader.GetString(4);
                lstPosts.Add(entry);
            }
            sqlDataReader.Close();
            return lstPosts;
        }

        public bool AddBlogPost(long UserId,string BlogTitle, string BlogText)
        {
            string SqlText = $"INSERT INTO Blog(BlogTitle,BlogText,PostedBy) VALUES('{BlogTitle}','{BlogText}','{UserId}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = SqlText;
            int RowsEffected = sqlCommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }

        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> lstComments = new List<BlogComment>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "Select * from Comment";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogComment entry = new BlogComment();
                entry.BlogPostId = sqlDataReader.GetInt64(1);
                entry.CommentTitle = sqlDataReader.GetString(2);
                entry.CommentText = sqlDataReader.GetString(3);
                lstComments.Add(entry);
            }
            sqlDataReader.Close();
            return lstComments;
        }

        public bool AddBlogComment(long BlogPostId, string CommentTitle, string CommentText)
        {
            string SqlText = $"INSERT INTO Comment(BlogPostId,CommentTitle,CommentText) VALUES('{BlogPostId}','{CommentTitle}','{CommentText}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = SqlText;
            int RowsEffected = sqlCommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }
    }
}