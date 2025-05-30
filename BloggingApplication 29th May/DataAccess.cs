using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;



namespace ADDNetBlogWinApp
{
    public class DataAccess:IDisposable
    {
        private const string ConString = "Data Source=WKSCHE03TRNG033\\SQLEXPRESS;Initial Catalog=BlogAppDB;Integrated Security=SSPI;Trust Server Certificate=True";
        private SqlConnection _connection;
        public DataAccess()
        {
            _connection = new SqlConnection(ConString);
        }
        public void Dispose()
        {
            if(_connection != null)
            {
                _connection.Close();
            }
        }
        
        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> blogComments = new List<BlogComment>();
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            string cmdText = "Select *from Comment";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            SqlDataReader reader = sqlCommand.ExecuteReader(); 
            while (reader.Read())
            {
                BlogComment blogComment = new BlogComment()
                {
                    CommentId = reader.GetInt64(0),
                    BlogPostId = reader.GetInt64(1),
                    CommentTitle = reader.GetString(2),
                    CommentText = reader.GetString(3),
                    CommentBy = reader.GetString(4)
                };
                blogComments.Add(blogComment);
            }
            reader.Close();
            return blogComments;
        }
        public bool AddComment(string Title, string CommentText, string CommentBy,int selid)
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            string cmdText = $"insert into Comment(BlogPostId,CommentTitle,CommentText,CommentBy) values('{selid}','{Title}','{CommentText}','{CommentBy}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            int nRecordsEffected = sqlCommand.ExecuteNonQuery();
            if (nRecordsEffected > 0)
            {
                return true;
            }
            return false;  
        }
        public bool AddPost(string title,string ptext,string pby)
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            string cmdText = $"insert into Blog(BlogTitle,BlogText,PostedDatetime) values('{title}','{ptext}','{pby}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            int nRecordsEffected=sqlCommand.ExecuteNonQuery();
            if (nRecordsEffected > 0)
            {
                return true;
            }
            return false;
        }
        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> blogPosts = new List<BlogPost>();
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            string cmdText = "Select *from Blog";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogPost blogPost = new BlogPost()
                {
                    BlogPostId = reader.GetInt64(0),
                    BlogTitle = reader.GetString(1),
                    BlogText = reader.GetString(2),
                    PostedDatetime = reader.GetString(3)
                };
                blogPosts.Add(blogPost);
            }
            reader.Close();
            return blogPosts;
        }
        public bool DeletePost(int postId)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"DELETE Blog where PostId={BlogPostId}";
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
