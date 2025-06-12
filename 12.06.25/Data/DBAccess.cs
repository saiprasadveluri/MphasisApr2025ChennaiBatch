using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using WebApplication4.DTO;
using System.Data;
using System.Configuration;
using WebApplication4.Data;

namespace WebApplication4.Data
{
    public class DBAccess : IDisposable
    {
        SqlConnection SqlConnection;
        //string conString = "Data Source=.;Initial Catalog=BlogAppDB;Integrated Security=True;";
        public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;
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
        public bool ValidateUser(string email, string password, out long UserId)
        {
            UserId = 0;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = SqlConnection;
            sqlcommand.CommandText = "select * from UserData where Email=@email AND Password=@password";
            sqlcommand.Parameters.AddWithValue("@email", email);
            sqlcommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = sqlcommand.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                UserId=reader.GetInt64(0);
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
            sqlcommand.CommandText = "select * from BlogPost";
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogPost entry=new BlogPost();
                entry.PostId=sqlDataReader.GetInt64(0);
                entry.Title=sqlDataReader.GetString(1);
                entry.PostText=sqlDataReader.GetString(2);
                entry.PostedBy=sqlDataReader.GetString(3);
                lstPosts.Add(entry);

            }
           sqlDataReader.Close();
           return lstPosts;
        }
        public bool AddBlogPost(long UserId, string Title,string PostText)
        {
            string SqlText=$"INSERT INTO BlogPost(Title,PostText,PostedBy) Values('{Title}','{PostText}','{UserId}')";
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = SqlConnection;
            sqlcommand.CommandText= SqlText;
            int RowsEffected=sqlcommand.ExecuteNonQuery();
            return RowsEffected > 0;

        }
        private string connStr = ConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;

        public DataTable GetAllBlogPosts()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT PostId, Title FROM BlogPost", conn);
                SqlDataAdapter dataAccess = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAccess.Fill(dt);
                return dt;
            }
        }
        public void AddComment(int PostId, string Title, string CommentText)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"INSERT INTO BlogComment (PostId, Title, CommentText)
                         VALUES (@PostId, @Title, @CommentText)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PostId", PostId);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@CommentText", CommentText);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetCommentsByPostId(int PostId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT Title, CommentText FROM BlogComment WHERE PostId = @PostId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PostId", PostId);
                SqlDataAdapter dataAccess = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAccess.Fill(dt);
                return dt;
            }
        }
    }
}