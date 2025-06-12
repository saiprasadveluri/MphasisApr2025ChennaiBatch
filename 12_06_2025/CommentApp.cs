using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication12
{
    public class CommentApp
    {
        SqlConnection SqlConnection { get; set; }
        public CommentApp()
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
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
        public List<Comment> GetAllComments(long blogPostId)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "SELECT * FROM Comment WHERE BlogPostId=@blogPostId";
            sqlCommand.Parameters.AddWithValue("@blogPostId", blogPostId);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Comment> comments = new List<Comment>();
            while (reader.Read())
            {
                Comment comment = new Comment
                {
                    CommentId = Convert.ToInt32(reader["CommentId"]),
                    BlogPostId = Convert.ToInt32(reader["BlogPostId"]),
                    CommentTitle = reader["CommentTitle"].ToString(),
                    CommentText = reader["CommentText"].ToString(),
                    CommentBy = reader["PostedBy"].ToString(),
                };
                comments.Add(comment);
            }
            reader.Close();
            return comments;
        }
    }

    public class Comment
    {
       public int CommentId { get; set; }
        public int BlogPostId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public string CommentBy { get; set; }
    }
}