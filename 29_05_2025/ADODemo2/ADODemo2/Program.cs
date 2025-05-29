using ADODemo2;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
SqlDataAdapter adapter = new SqlDataAdapter();
/*
DataSet ds = new DataSet();
DataTable dt=new DataTable("Task");

ds.Tables.Add(dt);

Console.WriteLine(ds.Tables.Count);

DataTable dtComment = new DataTable("Comment");
ds.Tables.Add(dtComment);
Console.WriteLine(ds.Tables.Count);

//Add Colums
dt.Columns.Add("TaskId", typeof(System.Int64));
dt.Columns.Add("TaskTitle", typeof(string));

Console.WriteLine(ds.Tables["Task"].Columns.Count);

DataTable dtCur = ds.Tables["Task"];
DataRow drCur= dtCur.NewRow();
drCur["TaskId"] = 10;
drCur["TaskTitle"] = "Task manager";
dtCur.Rows.Add(drCur);

Console.WriteLine(ds.Tables["Task"].Rows.Count);

Console.WriteLine(ds.Tables["Task"].Rows[0]["TaskId"]);
*/
return;
/*string ConnectionString = "Data Source=.;Initial Catalog=BlogAppDB;Integrated Security=SSPI;Trust Server Certificate=True;";
SqlConnection connection=new SqlConnection(ConnectionString);
try
{
    connection.Open();
    List<BlogPost> posts = new List<BlogPost>();
    string sqlQuery = "GETALLPOSTS";
    SqlCommand command = new SqlCommand();
    command.CommandText = sqlQuery;
    command.CommandType = System.Data.CommandType.StoredProcedure;
    command.Connection = connection;
    SqlDataReader reader = command.ExecuteReader();
    if (reader.HasRows)
    {
        while (reader.Read())
        {
            //Access the Column Values
            long BlogID = reader.GetInt64(0);
            string BlogTitle = reader.GetString(1);
            string BlogPostText = reader.GetString(2);//reader["PostText"].ToString();
            string BlogPostedBy = reader.GetString(3);//reader[3].ToString();
                                                      //Console.WriteLine($"{BlogID}-{BlogTitle}-{BlogPostText}");
            BlogPost post = new BlogPost();
            post.PostId = BlogID;
            post.Title = BlogTitle;
            post.PostText = BlogPostText;
            post.PostedBy = BlogPostedBy;
            posts.Add(post);
        }
    }
    else
    {
        Console.WriteLine("No Records found");
    }
    reader.Close();
    if (posts.Count > 0)
    {
        foreach (var pst in posts)
        {
            Console.WriteLine($"{pst.Title}");
        }
    }
    //Access the Post with Id 2
    BlogPost SelPost = posts.FirstOrDefault(p => p.PostId == 12);
    if (SelPost != null)
    {
        Console.WriteLine(SelPost.Title);
    }
    else
    {
        Console.WriteLine("No post with Id: 2");
    }
}
catch(SqlException ex)
{
    Console.WriteLine(ex.Errors[0].Message);    
}
finally
{
    if (connection.State == ConnectionState.Open)
    {
        connection.Close();
    }
}*/
/*
string SqlQuery = "GETPOSTCOUNT";
SqlCommand sqlCommand = new SqlCommand();
sqlCommand.CommandText = SqlQuery;
sqlCommand.CommandType = CommandType.StoredProcedure;
sqlCommand.Connection= connection;
//Add Params.
SqlParameter nameParam = new SqlParameter("@POSTEDBY", "Durga");
sqlCommand.Parameters.Add(nameParam);

SqlParameter countParam = new SqlParameter();
countParam.ParameterName = "@POSTCOUNT";
countParam.DbType = DbType.Int32;
countParam.Direction = ParameterDirection.Output;
sqlCommand.Parameters.Add(countParam);

sqlCommand.ExecuteNonQuery();
int RowCount = Convert.ToInt32(countParam.Value);
Console.Write($"Number of Records: {RowCount}");
*/
/*
string SqlQuery = "GETPOSTBYID";

SqlCommand cmd = new SqlCommand();
cmd.CommandText = SqlQuery;
cmd.CommandType = CommandType.StoredProcedure;
cmd.Connection=connection;

//Add Params
SqlParameter IdParam = new SqlParameter("@POSTID", 1);
cmd.Parameters.Add(IdParam);
SqlDataReader reader=cmd.ExecuteReader();

if (reader.HasRows)
{
    while (reader.Read())
    {
        //Access the Column Values
        long BlogID = reader.GetInt64(0);
        string BlogTitle = reader.GetString(1);
        string BlogPostText = reader.GetString(2);//reader["PostText"].ToString();
        string BlogPostedBy = reader.GetString(3);//reader[3].ToString();
        Console.WriteLine($"{BlogID}-{BlogTitle}-{BlogPostText}");
    }
}
else
{
    Console.WriteLine("No Records found");
}
reader.Close();

*/
/*string sqlQuery = "GETALLPOSTS";
SqlCommand command = new SqlCommand();
command.CommandText = sqlQuery;
command.CommandType = System.Data.CommandType.StoredProcedure;
command.Connection = connection;
SqlDataReader reader = command.ExecuteReader();
if (reader.HasRows)
{
    while (reader.Read())
    {
        //Access the Column Values
        long BlogID = reader.GetInt64(0);
        string BlogTitle = reader.GetString(1);
        string BlogPostText = reader.GetString(2);//reader["PostText"].ToString();
        string BlogPostedBy = reader.GetString(3);//reader[3].ToString();
        Console.WriteLine($"{BlogID}-{BlogTitle}-{BlogPostText}");
    }
}
else
{
    Console.WriteLine("No Records found");
}
reader.Close();
*/

/*string sqlQuery = "Select * from BlogPost";

SqlCommand sqlCommand = new SqlCommand();
sqlCommand.CommandText = sqlQuery;
sqlCommand.Connection = connection;
SqlDataReader reader = sqlCommand.ExecuteReader();
if (reader.HasRows)
{
    while (reader.Read())
    {
        //Access the Column Values
        long BlogID = reader.GetInt64(0);
        string BlogTitle = reader.GetString(1);
        string BlogPostText = reader.GetString(2);//reader["PostText"].ToString();
        string BlogPostedBy = reader.GetString(3);//reader[3].ToString();
        Console.WriteLine($"{BlogID}-{BlogTitle}-{BlogPostText}");
    }
}
else
{
    Console.WriteLine("No Records found");
}
reader.Close();*/

//connection.Close();