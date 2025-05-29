using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace windowsql
{
    public class DataAccessLayer:IDisposable
    {
        private const string ConString = "Data Source=WKSCHE03TRNG078\\SQLEXPRESS;Initial Catalog=TaskManagement;Integrated Security=SSPI;Trust Server Certificate=True";
        private SqlConnection connect;
       

        public DataAccessLayer()
        {
            connect=new SqlConnection(ConString);
        }
        public void Dispose()
        {
          if(connect != null)
            {
                connect.Close();
            }
        }
        public List<BlogPost> GetAllPosts()
        {
            List<BlogPost> blogPosts = new List<BlogPost>();
            if (connect.State != ConnectionState.Open)
            {
              connect.Open();  
            }
           
            string cmdtext = "Select * from BlogPost";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = cmdtext;
            cmd.Connection = connect;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BlogPost blogPost = new BlogPost()
                {
                    PostID = reader.GetInt64(0),
                    Title = reader.GetString(1),
                    PostText = reader.GetString(2),
                    PostedBy = reader.GetString(3),
                };
                blogPosts.Add(blogPost);
            }
            reader.Close();
           return blogPosts;
        }
       public bool AddPost(string Title, string text,string postedby)
        {
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
            }

           
            string cmdText=$"insert into BlogPost(title,posttext,postedby)values('{Title}'---{text}--{postedby})";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = cmdText;
            cmd.Connection = connect;
            int nrec=cmd.ExecuteNonQuery();
            if(nrec > 0)
            {
                return true;
            }
            return false;
        }
    }
}
