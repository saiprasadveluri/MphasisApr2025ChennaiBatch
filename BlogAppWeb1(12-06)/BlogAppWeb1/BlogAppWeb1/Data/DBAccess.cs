using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using BlogAppWeb1;
using BlogAppWeb1.DTO;

namespace BlogAppWeb1.Data
{
    public class DBAccess:IDisposable

    {
        SqlConnection sqlConnection;

        public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings
                ["BlogDB"].ConnectionString;
            sqlConnection = new SqlConnection (conString);
            sqlConnection.Open ();

        }
        public void CloseConnection()
        {
            if(sqlConnection != null)
            {
                if(sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close ();
                }
            }

        }
        public void Dispose()
        {
            CloseConnection();
        }
        public bool ValidateUser(string email,string password,out long UserId)
        {
            UserId = 0;
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection=sqlConnection;
            sqlcommand.CommandText = "Select * from UserData where Email=@email AND Password=@password";
            sqlcommand.Parameters.AddWithValue ("@email", email);
            sqlcommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = sqlcommand.ExecuteReader ();
            if(reader.HasRows)
            {
                reader.Read();
                UserId = reader.GetInt64(0);
                reader.Close ();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }


        }
        public List<BlogPost>GetAllPosts()
        {
           List<BlogPost> Posts=new List<BlogPost>();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection= sqlConnection;
            sqlcommand.CommandText = "select * from BlogPost";
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader ();
            while(sqlDataReader.Read())
            {
                BlogPost entry = new BlogPost();
                entry.PostId=sqlDataReader.GetInt64 (0);
                entry.Title=sqlDataReader.GetString (1);
                entry.PostText = sqlDataReader.GetString(2);
                entry.PostedBy = sqlDataReader.GetString (3);
                Posts.Add(entry);
            }
            sqlDataReader.Close ();
            return Posts;
        }
        public bool AddBlogPost(long UserId,string Title,string PostTerxt)
        {
            string SqlText=$"INSERT INTO BlogPost (Title,PostText,PostedBy) VALUES('{Title}','{PostTerxt}','{UserId}')";
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection= sqlConnection;
            sqlcommand.CommandText=SqlText;
            int RowsEffected=sqlcommand.ExecuteNonQuery ();
            return RowsEffected > 0;
        }


        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> Comments = new List<BlogComment>();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlcommand.CommandText = "select * from BlogComment";
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogComment entry = new BlogComment();
                entry.PostId = sqlDataReader.GetInt64(0);
                entry.CommentId=sqlDataReader.GetInt64(1);
                entry.Title = sqlDataReader.GetString(2);
                entry.CommentText = sqlDataReader.GetString(3);
                entry.CommentedBy = sqlDataReader.GetString(4);
                Comments.Add(entry);
            }
            sqlDataReader.Close();
            return Comments;
        }
        public bool AddBlogComment(long PostId, string Title, string CommentText,long CommentBy)
        {
            string SqlText = $"INSERT INTO BlogComment (PostId,Title,CommentText,CommentBy) VALUES({PostId},'{Title}','{CommentText}',{CommentBy})";
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlcommand.CommandText = SqlText;
            int RowsEffected = sqlcommand.ExecuteNonQuery();
            return RowsEffected > 0;
        }
    }
}