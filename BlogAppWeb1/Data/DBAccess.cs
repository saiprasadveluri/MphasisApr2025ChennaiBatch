using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using BlogAppWeb1.DTO;

namespace BlogAppWeb1.Data
{
    public class DBAccess:IDisposable
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
                if (SqlConnection.State == System.Data.ConnectionState.Open)
                {
                    SqlConnection.Close();
                }
            }
        }
        public void Dispose()
        {
            CloseConnection();
        }
        public bool ValidateUser(string email,string password, out long UserId)
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
        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> lstPosts = new List<BlogPost>();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = SqlConnection;
            sqlcommand.CommandText = "select * from BlogPost";
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogPost entry = new BlogPost();
                entry.PostId = sqlDataReader.GetInt64(0);
                entry.Title = sqlDataReader.GetString(1);
                entry.PostText = sqlDataReader.GetString(2);
                entry.PostedBy = sqlDataReader.GetString(3);
                lstPosts.Add(entry);

            }
            sqlDataReader.Close();
            return lstPosts;
        }
        public bool AddBlogPost(long UserId,string Title,string PostText)
        {
            string SqlText = $"INSERT INTO BlogPost(Title,PostText,PostedBy) Values('{Title}','{PostText}','{UserId}')";
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = SqlConnection;
            sqlcommand.CommandText = SqlText;
            int RowsEffected = sqlcommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }
        public bool AddComment(long PostId, string Title, string CommentText, string CommentBy)
        {
            string SqlText = "INSERT INTO BlogComment (PostId, Title, CommentText, CommentBy) VALUES (@PostId, @Title, @CommentText, @CommentBy)";
            SqlCommand sqlCommand = new SqlCommand(SqlText, SqlConnection);

            sqlCommand.Parameters.AddWithValue("@PostId", PostId);
            sqlCommand.Parameters.AddWithValue("@Title", Title);
            sqlCommand.Parameters.AddWithValue("@CommentText", CommentText);
            sqlCommand.Parameters.AddWithValue("@CommentBy", CommentBy);

            int RowsEffected = sqlCommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }

        public List<BlogComment> GetCommentsByPostId(long PostId)
        {
            List<BlogComment> comments = new List<BlogComment>();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM BlogComment WHERE PostId = @PostId", SqlConnection);
            sqlCommand.Parameters.AddWithValue("@PostId", PostId);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogComment comment = new BlogComment
                {
                    CommentID = reader.GetInt64(0),
                    PostId = reader.GetInt64(1),
                    Title = reader.GetString(2),
                    CommentText = reader.GetString(3),
                    CommentBy = reader.GetString(4)
                };
                comments.Add(comment);
            }
            reader.Close();
            return comments;
        }

    }
}
