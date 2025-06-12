using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using BlogAppWeb12.DTO;
using System.Runtime.Remoting.Messaging;

namespace BlogAppWeb12.Data
{
    public class DBAccess : IDisposable
    {
        SqlConnection SqlConnection;
        public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings
                ["BlogPost1"].ConnectionString;
            SqlConnection = new SqlConnection(conString);
            SqlConnection.Open();
        }
        public void CloseConnection()
        {
            if (SqlConnection != null)
            {
                if (SqlConnection.State == ConnectionState.Open)
                {
                    SqlConnection.Close();
                }
            }
        }
        public void Dispose()
        {
            CloseConnection();
        }
        public bool ValidateUser(string email, string password, out long UserId)
        {
            UserId = 0;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "Select * from UserData where Email=@email AND Password = @password";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
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

        public List<BlogPost> GetAllPosts()

        {
            List<BlogPost> lstPosts = new List<BlogPost>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "select * from BlogPost";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {

                BlogPost entry = new BlogPost();
                entry.PostId = sqlDataReader.GetInt64(0);
                entry.Title = sqlDataReader.GetString(1);
                entry.PostText = sqlDataReader.GetString(2);
                lstPosts.Add(entry);
            }
            sqlDataReader.Close();
            return lstPosts;


        }

        public bool AddBlogPost(long UserId, string Title, string PostText)
        {
            string SqlText = $"Insert INTO BlogPost (Title,PostText,PostedBy) VALUES('{Title}','{PostText}','{UserId})";   
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = SqlText;
            int RowsEffected = sqlCommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }

    

public List<BlogComment> GetAllComment()

{
    List<BlogComment> lstPosts = new List<BlogComment>();
    SqlCommand sqlCommand = new SqlCommand();
    sqlCommand.Connection = SqlConnection;
    sqlCommand.CommandText = "select * from BlogComment";
    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

    while (sqlDataReader.Read())
    {

        BlogComment entry = new BlogComment();
        entry.PostId = sqlDataReader.GetInt64(0);
        entry.CommentId= sqlDataReader.GetInt64(1);
        entry.Title= sqlDataReader.GetString(2);
        entry.CommentText = sqlDataReader.GetString(3);
        entry.CommentBy = sqlDataReader.GetString(3);

                lstPosts.Add(entry);
    }
    sqlDataReader.Close();
    return lstPosts;


}

public bool AddBlogComment(long UserId, string Title, string PostText)
{
    string SqlText = $"Insert INTO BlogPost (Title,PostText,PostedBy) VALUES('{Title}','{PostText}','{UserId})";
    SqlCommand sqlCommand = new SqlCommand();
    sqlCommand.Connection = SqlConnection;
    sqlCommand.CommandText = SqlText;
    int RowsEffected = sqlCommand.ExecuteNonQuery();
    return RowsEffected > 0;
}

    }
}
    





