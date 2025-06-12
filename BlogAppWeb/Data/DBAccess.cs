using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using BlogAppWeb.Data.DTO;

namespace BlogAppWeb.Data
{
    public class DBAccess:IDisposable
    {
        SqlConnection SqlConnection;
       public DBAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;
            SqlConnection=new SqlConnection(conString);
            SqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (SqlConnection != null)
            {
                if(SqlConnection.State != ConnectionState.Open)
                {
                    SqlConnection.Close();
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
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection= SqlConnection;
            sqlCommand.CommandText = "select * from UserData where Email=@email ANd Password=@password";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("Password", password);
            SqlDataReader reader = sqlCommand.ExecuteReader();
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
            List<BlogPost> lstposts= new List<BlogPost>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection= SqlConnection;
            sqlCommand.CommandText = "Select * from BlogPost";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogPost  entry = new BlogPost();
                entry.PostId = sqlDataReader.GetInt64(0);
                entry.Title = sqlDataReader.GetString(1);
                entry.PostText = sqlDataReader.GetString(2);
                lstposts.Add(entry);
            }
            sqlDataReader.Close();
            return lstposts;
        }



        public bool AddBlogPost(long UesrId,string Title,string PostText)
        {
            string SqlText = $"Insert Into BlogPost(Title,PostText,PostedBy) Values('{Title}','{PostText}','{UesrId}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection= SqlConnection;
            sqlCommand.CommandText=SqlText;
            int Rowseffected=sqlCommand.ExecuteNonQuery();
            return Rowseffected > 0;
        }






        public List<BlogComment> GetAllComment()
        {
            List<BlogComment> lstcomment = new List<BlogComment>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = "Select * from BlogComment";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                BlogComment entry = new BlogComment();
                entry.CommentId = sqlDataReader.GetInt64(0);
                entry.PostId = sqlDataReader.GetInt64(1);
                entry.Title = sqlDataReader.GetString(2);
                entry.CommentText = sqlDataReader.GetString(3);
                entry.CommentBy = sqlDataReader.GetInt64(4);
                lstcomment.Add(entry);
            }
            sqlDataReader.Close();
            return lstcomment;
        }


        public bool AddBlogComment(long postId, string Title , string commentText,long commentby )
        {
            string SqlText = $"Insert Into BlogComment(PostId,Title,CommentText,CommentBy) Values('{postId}','{Title}','{commentText}','{commentby}')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            sqlCommand.CommandText = SqlText;
            int Rowseffected = sqlCommand.ExecuteNonQuery();
            return Rowseffected > 0;
        }



    }
}