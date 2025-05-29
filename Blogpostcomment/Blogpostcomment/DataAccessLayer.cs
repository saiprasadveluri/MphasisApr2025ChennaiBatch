using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogpostcomment
{
    //internal class DataAccessLayer
    //{
    //}
    public class DataAccess : IDisposable
    {
        private const string ConString = "Data Source=.;Initial Catalog=BloggingAppDB;Integrated Security=SSPI;Trust Server Certificate=True";
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
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = "Select * from Blog";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            SqlDataReader reader
                = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BlogPost blogPost = new BlogPost()
                {
                    BlogPostId = reader.GetInt32(0),
                    BlogTitle = reader.GetString(1),
                    BlogText = reader.GetString(2),
                    PostedBy = reader.GetString(3),
                };
                blogPosts.Add(blogPost);
            }
            reader.Close();

            foreach (var post in blogPosts)
            {
                Console.WriteLine($"ID: {post.BlogPostId}\n, Title: {post.BlogTitle}\n, Text: {post.BlogText}\n, PostedBy: {post.PostedBy}");
            }

            return blogPosts;
        }

        public bool AddPost(string title, string text, string postedBy)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"INSERT INTO Blog(BlogTitle,BlogText,PostedBy) VALUES('{title}','{text}','{postedBy}')";
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
            string cmdText = $"DELETE Blog where BlogPostId={postId}";
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

