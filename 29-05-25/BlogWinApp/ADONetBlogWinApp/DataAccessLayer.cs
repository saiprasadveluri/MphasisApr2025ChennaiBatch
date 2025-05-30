using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
namespace ADONetBlogWinApp
{
    public class DataAccess:IDisposable
    {
        private const string ConString = "Data Source=.;Initial Catalog=BlogAppDB;Integrated Security=SSPI;Trust Server Certificate=True";
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

        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> blogPosts = new List<BlogPost>();
            if(_connection.State!=ConnectionState.Open) 
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
                    Title=reader.GetString(1),
                    PostText=reader.GetString(2),
                    PostedBy=reader.GetString(3),
                };
                blogPosts.Add(blogPost);
            }
            reader.Close();
            return blogPosts;
        }

        public bool AddPost(string title,string text,string postedBy)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"INSERT INTO BlogPost(TITLE,POSTTEXT,POSTEDBY) VALUES('{title}','{text}','{postedBy}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            int nRecEffected=sqlCommand.ExecuteNonQuery();
            if(nRecEffected > 0)
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
