using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Blogpostcomment
{
    public class DataComment : IDisposable
    {
        private const string ConString = "Data Source=.;Initial Catalog=BloggingAppDB;Integrated Security=SSPI;Trust Server Certificate=True";
        private SqlConnection _connection;

        public DataComment()
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

        public List<Comment> GetAllPosts()
        {
            List<Comment> commentPosts = new List<Comment>();
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = "Select * from Comment";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            SqlDataReader reader
                = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Comment comm = new Comment()
                {
                    CommentId = reader.GetInt32(reader.GetOrdinal("CommentId")),
                    BlogPostId = reader.GetInt32(reader.GetOrdinal("BlogPostId")),
                    CommentTitle = reader.GetString(reader.GetOrdinal("CommentTitle")),
                    CommentText = reader.GetString(reader.GetOrdinal("CommentText")),
                    CommentBy = reader.GetString(reader.GetOrdinal("CommentBy")),
                };
                commentPosts.Add(comm);
            }
            reader.Close();

            foreach (var post in commentPosts)
            {
                Console.WriteLine($"ID: {post.CommentId}\n,Blog Id: {post.BlogPostId}\n, Title: {post.CommentTitle}\n, Text: {post.CommentText}\n, PostedBy: {post.CommentBy}");
            }

            return commentPosts;
        }

        public bool AddComment(int postid, string title, string text, string CommentBy)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"INSERT INTO Comment(BlogPostId,CommentTitle,CommentText,CommentBy) VALUES('{postid}','{title}','{text}','{CommentBy}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = cmdText;
            sqlCommand.Connection = _connection;
            int nRecEffected = sqlCommand.ExecuteNonQuery();
            if (nRecEffected > 0)
            {
                return true;
            }
            Console.WriteLine("Data hasbeen added!!");
            return false;
        }

        public bool DeletePost(int postId)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            string cmdText = $"DELETE Comment where CommentId={postId}";
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
