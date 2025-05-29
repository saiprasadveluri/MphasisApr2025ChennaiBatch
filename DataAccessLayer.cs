using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ADONetBlogWinApp
{
    public class DataAccessLayer:IDisposable
    {
        private const string ConString = "Data Source=WKSCHE03TRNG079\\SQLEXPRESS;Initial Catalog=BlogAppDb;Integrated Security=SSPI; Trust Server Certificate=True";

        private SqlConnection _connection;

        public DataAccessLayer()
        {
            _connection = new SqlConnection(ConString);
        }
        public void Dispose()
        {
            if (_connection != null) {
                _connection.Close();
            }

        }
        public List<BlogPost> GetAllPost()
        {
            List<BlogPost> blogPosts = new List<BlogPost>();
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            string cmdText = "Select * from BlogPost";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogPost blogPost = new BlogPost
                {
                    PostId =reader.GetInt64(0),
                    Title=reader.GetString(1),
                    PostText=reader.GetString(2),
                    PostedBy=reader.GetString(3)

                };


                blogPosts.Add(blogPost);
            }
            reader.Close();
            return blogPosts;

        }

        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> blogComments = new List<BlogComment>();
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            string cmdText = "Select * from BlogComment";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogComment blogcmt = new BlogComment
                {
                    CommentId=reader.GetInt64(0),
                    PostId = reader.GetInt64(1),
                    Title = reader.GetString(2),
                    CommentText = reader.GetString(3),
                    CommentedBy = reader.GetString(4)

                };


                blogComments.Add(blogcmt);
            }
            reader.Close();
            return blogComments;

        }



        public bool AddComment(long postid,string title,string commenttext,string commenteddBy)
        {
            _connection.Open();
            string cmdText = $"Insert into BlogComment(postid,title,commenttext,commentedby) values('{postid}','{title}','{commenttext}','{commenteddBy}')";  
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection= _connection;
            int nRecordsEffected=sqlCommand.ExecuteNonQuery();
            if (nRecordsEffected > 0)
            {
                return true;
            }
            return false;
         }

        
        public bool AddPost(string title,string text,string postedBy)
        {
            _connection.Open();
            string cmdText = $"Insert into BlogPost(title,posttext,postedby) values('{title}','{text}','{postedBy}')";  
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection= _connection;
            int nRecordsEffected=sqlCommand.ExecuteNonQuery();
            if (nRecordsEffected > 0)
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

        public bool DeleteComment(int postId)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"DELETE BlogComment where PostId={postId}";
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
