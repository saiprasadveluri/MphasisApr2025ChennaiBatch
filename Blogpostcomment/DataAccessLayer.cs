using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogpostcomment
{
    public class DataAccess : IDisposable
    {
        private const string ConString = "Data Source=.;Initial Catalog=BloggingAppDB;Integrated Security=SSPI;Trust Server Certificate=True";
        private readonly SqlConnection _connection;

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

        public List<BPost> GetAllPosts()
        {
            List<BPost> posts = new List<BPost>();

            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            string cmdText = "SELECT * FROM Blog";
            using SqlCommand sqlCommand = new(cmdText, _connection);
            using SqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    posts.Add(new BPost()
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Content = reader.GetString(2),
                        Author = reader.GetString(3),
                    });
                }
                reader.Close();
            }

            if (posts.Count > 0)
            {
                foreach (var post in posts)
                {
                    Console.WriteLine($"ID: {post.Id}, Title: {post.Title}, Content: {post.Content}, Author: {post.Author}");
                }
            }

            _connection.Close();
            return posts;
        }

        public bool AddPost(string title, string content, string author)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            string cmdText = "INSERT INTO Blog (BlogTitle, BlogText, PostedBy) VALUES (@Title, @Content, @Author)";
            using SqlCommand sqlCommand = new(cmdText, _connection);
            sqlCommand.Parameters.AddWithValue("@Title", title);
            sqlCommand.Parameters.AddWithValue("@Content", content);
            sqlCommand.Parameters.AddWithValue("@Author", author);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                _connection.Close();
                return true;
            }

            _connection.Close();
            return false;
        }

        public bool DeletePost(int postId)
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            string cmdText = "DELETE FROM Blog WHERE BlogPostId = @PostId";
            using SqlCommand sqlCommand = new(cmdText, _connection);
            sqlCommand.Parameters.AddWithValue("@PostId", postId);

            int rowsAffected = sqlCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                _connection.Close();
                return true;
            }

            _connection.Close();
            return false;
        }
    }
}
