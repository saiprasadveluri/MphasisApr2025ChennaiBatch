using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace AddNewBogWinApp
{
    public class DataAccessLayer:IDisposable
    {
        private const string ConString = "Data Source=WKSCHE03TRNG047;Initial Catalog=blogdbapp;Integrated Security=SSPI;Trust Server Certificate=True";
        private SqlConnection _connection;

        public DataAccessLayer()
        {
            _connection = new SqlConnection(ConString);
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Close();
            }
        }

        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> blogPosts = new List<BlogPost>();
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = "Select * from BlogPost";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            SqlDataReader reader
                = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogPost blogPost = new BlogPost()
                {
                    PostId = reader.GetInt64(0),
                    Title = reader.GetString(1),
                    PostText = reader.GetString(2),
                    PostedBy = reader.GetString(3),
                };
                blogPosts.Add(blogPost);
            }
            reader.Close();
            return blogPosts;
        }

        public bool AddPost(string title, string text, string postedBy)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"INSERT INTO BlogPost(TITLE,POSTTEXT,POSTEDBY) VALUES('{title}','{text}','{postedBy}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            int nRecEffected = sqlCommand.ExecuteNonQuery();
            if (nRecEffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeletePost(int PostId)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"DELETE BlogPost where PostId={PostId}";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            int nRecEffected = sqlCommand.ExecuteNonQuery();
            if (nRecEffected > 0)
            {
                return true;
            }
            return false;
        }
        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> blogComments = new List<BlogComment>();
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = "Select * from BlogComment";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            SqlDataReader reader
                = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogComment blogComment = new BlogComment()
                {
                    CommentId = reader.GetInt64(0),
                    Title = reader.GetString(1),
                    CommentText = reader.GetString(2),
                    CommentedBy = reader.GetString(3),
                };
                blogComments.Add(blogComment);
            }
            reader.Close();
            return blogComments;
        }

        public bool AddComment(string title, string Commenttext, string Commentedby)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"INSERT INTO BlogComment(TITLE,COMMENTTEXT,COMMENTEDBY) VALUES('{title}','{Commenttext}','{Commentedby}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            int nRecEffected = sqlCommand.ExecuteNonQuery();
            if (nRecEffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
