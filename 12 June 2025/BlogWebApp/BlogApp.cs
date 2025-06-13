using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;

namespace WebApplication12
{
    // Define the BlogPost class to resolve CS0246 error  
    public class BlogPost
    {
        public long BlogPostId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogText { get; set; }
        public string PostedBy { get; set; }
    }

    public class BlogApp : IDisposable
    {
        SqlConnection SqlConnection;
        public BlogApp()
        {
            string conString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            SqlConnection = new SqlConnection(conString);
            SqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (SqlConnection != null)
            {
                if (SqlConnection.State == System.Data.ConnectionState.Open)
                {
                    SqlConnection.Close();
                }
            }
        }
        public void Dispose()
        {
            CloseConnection();
        }
        public bool ValidateUser(string email, string password)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "select * from UserInfos where Email=@email AND Password=@password";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
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
            List<BlogPost> lstPosts = new List<BlogPost>();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = SqlConnection;
            sqlcommand.CommandText = "select * from Blog";
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogPost entry = new BlogPost();
                entry.BlogPostId = sqlDataReader.GetInt32(0);
                entry.BlogTitle = sqlDataReader.GetString(1);
                entry.BlogText = sqlDataReader.GetString(2);
                entry.PostedBy = sqlDataReader.GetString(3);
                lstPosts.Add(entry);

            }
            sqlDataReader.Close();
            return lstPosts;
        }

        public List<BlogPost> AddBlogPost(string BlogTitle, string BlogText, string PostedBy)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "insert into Blog (Title, PostText, PostedBy) values (@BlogTitle, @BlogText, @PostedBy)";
            sqlCommand.Parameters.AddWithValue("@BlogTitle", BlogTitle);
            sqlCommand.Parameters.AddWithValue("@BlogText", BlogText);
            sqlCommand.Parameters.AddWithValue("@PostedBy", PostedBy);
            int result = sqlCommand.ExecuteNonQuery();
            if (result > 0)
            {
                return GetAllPosts(); 
            }
            else
            {
                return null; 
            }
        }
    }
}