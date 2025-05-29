using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demopart1
{
    public class DataAccess : IDisposable
    {
        private const string ConString = "Data Source=;Initial Catalog=BlogAppDB;Integrated Security=SSPI;Trust Server Certificate=True";
        private SqlConnection _connection;

        public DataAccess()
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

        public List<Blogpost> GetAllPosts()
        {
            List<Blogpost> blogPosts = new List<Blogpost>();
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
                Blogpost blogPost = new Blogpost()
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
        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> blogcomments = new List<BlogComment>();
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
                BlogComment blogcomment = new BlogComment()
                {
                    //CommentId = reader.GetInt64(0),
                    PostId = reader.GetInt64(1),
                    Title = reader.GetString(0),
                    CommentText = reader.GetString(1),
                    CommentLine = reader.GetString(2),
                };
                blogcomments.Add(blogcomment);
            }
            reader.Close();
            return blogcomments;
        }
        public bool AddComment(int postId, string title, string CommentText, string CommentLine)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"INSERT INTO BlogComment(  POSTId ,TITLE,COMMENTTEXT,COMMENTLINE) VALUES('{title}','{CommentText}','{CommentLine}')";
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

        public bool DeletePost(int postId)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"DELETE BlogPost where PostId={postId}";
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


