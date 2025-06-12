using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Web2.DTO;

namespace Web2.Data
{
    public class DataAccess : IDisposable
    {
        SqlConnection sqlConnection;
        public DataAccess()
        {
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

        public void Dispose()
        {
            CloseConnection();
        }
        public bool ValidateUser(string email, string password, out long userId)
        {
            userId = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "select * from UserData where Email=@email  and Password=@password";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                userId = reader.GetInt64(0);
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
            List<BlogPost> listposts = new List<BlogPost>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "Select * from BlogPost";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                BlogPost blogPost = new BlogPost();
                blogPost.PostID = reader.GetInt64(0);
                blogPost.Title = reader.GetString(1);
                blogPost.PostText = reader.GetString(2);
                blogPost.PostedBy = reader.GetInt64(3);
                listposts.Add(blogPost);

            }
            reader.Close();
            return listposts;

        }

        public bool AddBlogPost(long UserId, string Title, string PostText)
        {
            string SqlText = $"Insert into BlogPost(Title,PostText,PostedBy)values('{Title}','{PostText}',{UserId})";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = SqlText;
            int Rowseffected = cmd.ExecuteNonQuery();
            return Rowseffected > 0;

        }
        public bool AddBlogComment(long PostId, string CommentTitle, string CommentText,long UserId)
        {
            string SqlText = $"insert into BlogComment(PostId,Title,CommentText,CommentBy)values({PostId},'{CommentTitle}','{CommentText}',{UserId})";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = SqlText;
            int rowseff=cmd.ExecuteNonQuery();
            return rowseff > 0;
        }
        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> listComments = new List<BlogComment>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "Select * from BlogComment";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                BlogComment blog = new BlogComment();
                blog.PostId = reader.GetInt64(0);
                blog.CommentId = reader.GetInt64(1);
                blog.CommentTitle = reader.GetString(2);
                blog.CommentText = reader.GetString(3);
                blog.CommentBy = reader.GetInt64(4);
                listComments.Add(blog);

            }
            reader.Close();
            return listComments;

        }
    }
    
}