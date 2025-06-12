using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using BlogAppWeb1.DTO;


namespace BlogAppWeb1.Data
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
            if (sqlConnection != null)
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        public void Dispose()
        {
            CloseConnection();
        }
        public bool ValidateUser(string email, string password,out long UserId)
        {
            UserId = 0;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from UserData where Email=@email AND password=@password";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
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
        public List<BlogPost>GetAllPosts()
        {
            List<BlogPost> posts= new List<BlogPost>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from BlogPost";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                BlogPost post = new BlogPost();
                post.PostIId = reader.GetInt64(0);
                post.Title= reader.GetString(1);
                post.PostText = reader.GetString(2);
                posts.Add(post);
            }
           reader.Close ();
            return posts;
        }
        public List<BlogComment>GetAllComments()
        {
            List<BlogComment> comments = new List<BlogComment>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from BlogComment";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogComment comment = new BlogComment();
                comment.CommentId = reader.GetInt64(0);
                comment.PostId = reader.GetInt64(1);
                comment.Title = reader.GetString(2);
                comment.CommentText = reader.GetString(3);
                comment.CommentBy = reader.GetString(4);
                comments.Add(comment);
            }
            reader.Close();
            return comments;
        }

        
        public bool AddBlogPost(long UserId,string Title,string PostText)
        {
            string SqlText = $"INSERT INTO BlogPost(Title,PostText,PostedBy)VALUES('{Title}','{PostText}','{UserId})";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText=SqlText;
            int RowsEffected=sqlCommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }
        public bool AddBlogComment(long PostId, string Title, string CommentText,long CommentBy)
        {
            string SqlText = $"INSERT INTO BlogComment(PostId,Title,CommentText,Commentby)VALUES({PostId}'{Title}','{CommentText}','{CommentBy})";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = SqlText;
            int RowsEffected = sqlCommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }

    }
}