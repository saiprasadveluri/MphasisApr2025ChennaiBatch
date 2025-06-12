using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using BlogWinApp.DTO;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace BlogWinApp
{
    public class DBAccess : IDisposable
    {
        SqlConnection sqlConnection;
        public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings["BlogAppDB"].ConnectionString;
            sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
        }
        public void CloseConnection()
        {
            if (sqlConnection != null)
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Close();
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "select * from UserData where email=@email AND password=@password";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("Password", password);
            SqlDataReader reader = cmd.ExecuteReader();
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "Select * from Blogpost";
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
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
        public bool AddBlogPost(long Userid, string title, string blogText)
        {
            string sqlText = $" Insert into Blogpost(title,posttext,postedby) values('{title}','{blogText}','{Userid}')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sqlText;
            int rowseffected = cmd.ExecuteNonQuery();
            return rowseffected > 0;
        }
        public List<Comments> GetAllComments()
        {
            List<Comments> lstComments = new List<Comments>();
            SqlCommand sql = new SqlCommand();
            sql.Connection = sqlConnection;
            sql.CommandText = "select * from Comments";
            SqlDataReader sqlDataReader = sql.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Comments cmtentry = new Comments();
                cmtentry.CommentId = sqlDataReader.GetInt64(0);
                cmtentry.PostId = sqlDataReader.GetInt64(1);
                cmtentry.Title = sqlDataReader.GetString(2);
                cmtentry.cmtText = sqlDataReader.GetString(3);
                lstComments.Add(cmtentry);
            }
            sqlDataReader.Close();
            return lstComments;
            
        }
        public bool AddComments(long postid,string title,string cmttxt,string commentedby)
        {
            string sqlText2 = $" Insert into Comments(postid,title,commenttext,commentedby) values('{postid}','{title}','{cmttxt}','{commentedby}')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sqlText2;
            int rowseffected = cmd.ExecuteNonQuery();
            return rowseffected > 0;
        }
    }
}
//cmtid postid title cmttxt cmtby