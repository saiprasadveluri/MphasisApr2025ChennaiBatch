using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using BlogWebApp.DTO;

namespace BlogWebApp.Data
{
    public class DbAccess:IDisposable
    {
        SqlConnection sqlConnection;
        public DbAccess()
        {
            string conString = WebConfigurationManager.ConnectionStrings["BlogDb"].ConnectionString;
            sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
        }
        public void CloseConnection()
        {
            if(sqlConnection != null)
            {
                if( sqlConnection.State == ConnectionState.Open) 
                { 
                    sqlConnection.Close(); 
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
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from UserData where Email=@email and Password=@password";
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@password", password);
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
        public List<BlogComment> GetAllComments()
        {
            List<BlogComment> blogCommentsList = new List<BlogComment>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from BlogComment";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                BlogComment blogComment = new BlogComment();
                blogComment.CommentId = reader.GetInt64(0);
                blogComment.PostId = reader.GetInt64(1);
                blogComment.Title = reader.GetString(2);
                blogComment.CommentText = reader.GetString(3);
                blogComment.CommentBy = reader.GetInt64(4);
                blogCommentsList.Add(blogComment);
            }
            reader.Close();
            return blogCommentsList;
        }
        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> postslist=new List<BlogPost>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "select *from BlogPost";
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                BlogPost post = new BlogPost();
                post.PostId = reader.GetInt64(0);
                post.Title = reader.GetString(1);
                post.PostText= reader.GetString(2);
                post.PostedBy = reader.GetInt64(3);
                postslist.Add(post);
            }
            reader.Close();
            return postslist;  
        }
        public bool AddBlogPost(long UserId,string Title,string PostText)
        {
            string sqltext = $"insert into BlogPost(Title,PostText,PostedBy) values('{Title}','{PostText}',{UserId})";
            SqlCommand cmd = new SqlCommand(sqltext);
            cmd.Connection = sqlConnection;
            int effected=cmd.ExecuteNonQuery();
            if(effected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddComment(long PostId, string commentTitle, string commentText, long commentBy)
        {
            string AddComment = $"insert into BlogComment(PostId,Title,CommentText,CommentBy)Values({PostId},'{commentTitle}','{commentText}',{commentBy})";
            SqlCommand cmd = new SqlCommand(AddComment);
            cmd.Connection = sqlConnection;
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
    }
}