// See https://aka.ms/new-console-template for more information

using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization.Json;

//Console.WriteLine("Hello, World!");
string ConnectionString = "Data Source=.; Initial Catalog=BlogAppDB;Integrated Security=SSPI;Trust Server Certificate=True";
SqlDataAdapter adapter = new SqlDataAdapter("Select * from BlogComment", ConnectionString);
DataSet ds = new DataSet();
adapter.Fill(ds, "BlogComment");

if (ds.Tables.Count > 0)
{
    DataTable dtComments = ds.Tables["BlogComment"];


    if (dtComments.Rows.Count > 0)
    {
        Console.WriteLine("Existing Comments:");
        foreach (DataRow dr in dtComments.Rows)
        {
            Console.WriteLine($"Comment ID: {dr["CommentId"]} | Post ID: {dr["PostId"]} | Title: {dr["Title"]} | Text: {dr["CommentText"]} | By: {dr["CommentBy"]}");
        }
    }

    DataRow newRow = dtComments.NewRow();
    newRow["CommentId"] = 2;
    newRow["PostId"] = 2;
    newRow["Title"] = "c#";
    newRow["CommentText"] = "super";
    newRow["CommentBy"] = "sham";

    dtComments.Rows.Add(newRow);
    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
    adapter.Update(ds, "BlogComment");
    Console.WriteLine("New comment added successfully!");


    Console.Write("Enter Comment ID to modify: ");
    long RowNo = long.Parse(Console.ReadLine());

    foreach (DataRow dr in dtComments.Rows)
    {
        if (Convert.ToInt64(dr["CommentId"]) == RowNo)
        {
            dr["PostId"] = 3;  
            dr["Title"] = "Updated Comment";
            dr["CommentText"] = "good";
            dr["CommentBy"] = "trinay";

   
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "BlogComment");

            Console.WriteLine("Comment updated successfully!");
            break;
        }
    }


    Console.Write("Enter Comment ID to delete: ");
    long deleteId = long.Parse(Console.ReadLine());

    foreach (DataRow dr in dtComments.Rows)
    {
        if (Convert.ToInt64(dr["CommentId"]) == deleteId)
        {
            dr.Delete();
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "BlogComment");
            Console.WriteLine("Comment deleted successfully!");
            break;
        }
    }
}
else
{
    Console.WriteLine("Error: Table 'BlogComment' does not exist.");
}

//DataSet ds = new DataSet();
//adapter.Fill(ds, "BlogComment");
//if (ds.Tables.Count > 0)
//{
//    DataTable dtComments = ds.Tables["BlogComment"];
//    if (dtComments.Rows.Count > 0)
//    {
//        foreach (DataRow dr in dtComments.Rows)
//        {
//            Console.WriteLine(dr["PostId"] + " - " + dr["Title"]);
//        }
//    }
//    DataRow myRow = dtComments.NewRow();
//    myRow[1] = 4;
//    myRow[2] = 2;
//    myRow[3] = "Adv Dot Net";
//    myRow[4] = "Some Text for Post";
//    myRow[5] = "Bobby RAJEEV";

//    dtComments.Rows.Add(myRow);
//    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
//    adapter.Update(ds, "BlogComment");



//    int RowNo = int.Parse(Console.ReadLine());
//    foreach (DataRow dr in dtComments.Rows)
//    {
//        if (Convert.ToInt64(dr[0]) == RowNo)
//        {
//            dr[1] = "Modified";
//            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
//            adapter.Update(ds, "BlogComments");
//            break;
//        }
//    }
//}







//SqlDataAdapter adapter=new SqlDataAdapter("Select * from BlogPost", ConnectionString);
//DataSet ds = new DataSet();
//adapter.Fill(ds,"BlogPost");
//if (ds.Tables.Count > 0)
//{
//    DataTable dtPosts = ds.Tables["BlogPost"];
//    if (dtPosts.Rows.Count > 0)
//    {
//        foreach (DataRow dr in dtPosts.Rows)
//        {
//            Console.WriteLine(dr["PostId"] + " - " + dr["Title"]);
//        }
//    }
//    DataRow myRow = dtPosts.NewRow();
//    myRow[1] = 4;
//myRow[2] = "Adv Dot Net";
//myRow[3] = "Some Text for Post";
//myRow[4] = "Bobby";

//dtPosts.Rows.Add(myRow);
//SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
//adapter.Update(ds, "BlogPost");



//int RowNo=int.Parse(Console.ReadLine());
//    foreach (DataRow dr in dtPosts.Rows)
//    {
//        if (Convert.ToInt64(dr[0]) == RowNo)
//        {
//            dr[1] = "Modified";
//            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
//            adapter.Update(ds, "BlogPost");
//            break;
//        }
//    }
//}


























//SqlConnection connection =new SqlConnection(ConnectionString);
//connection.Open();
//DataSet ds = new DataSet();
//DataTable dt = new DataTable("Task");
//ds.Tables.Add(dt);
//Console.WriteLine(ds.Tables.Count);
//DataTable dtComment = new DataTable("Comment");
//ds.Tables.Add(dtComment);
//Console.WriteLine(ds.Tables.Count);
//dt.Columns.Add("TaskId", typeof(System.Int64));
//dt.Columns.Add("TaskTitle",typeof(string));
//Console.WriteLine(ds.Tables["Task"].Columns.Count);
//DataTable dtCur = ds.Tables["Task"];
//DataRow drCur = dtCur.NewRow();
//drCur["TaskId"] = 10;
//drCur["TaskTitle"] = "Task Managers";
//dtCur.Rows.Add(drCur);
//Console.WriteLine(ds.Tables["Task"].Rows.Count);
//Console.WriteLine(ds.Tables[0].Rows[0][0]);
////Console.WriteLine(ds.GetXmlSchema());
////Console.WriteLine(dtCur.Rows.Count);
//return;


//List<BlogPost> posts =new List<BlogPost>();
//string sqlQuery = "GETALLPOSTS";
//SqlCommand command = new SqlCommand();
//command.CommandText = sqlQuery;
//command.CommandType = System.Data.CommandType.StoredProcedure;
//SqlDataReader reader = command.ExecuteReader();
//if (reader.HasRows)
//{
//    while (reader.Read())
//    {
//        long BlogID = reader.GetInt64(0);
//        string BlogTitle = reader.GetString(1);
//        string BlogPostText = reader.GetString(2);
//        string BlogPostedBy = reader.GetString(3);
//        BlogPost post = new BlogPost();
//        post.PostId = BlogID;
//        post.Title = BlogTitle;
//        post.PostedBy = BlogPostedBy;
//        posts.Add(post);    


//        Console.WriteLine($"{BlogID}-{BlogTitle}-{BlogPostText}");

//    }
//}
//else
//{
//    Console.WriteLine("No Records Found");
//}

//string sqlQuery = "GETPOSTBYID";
//SqlCommand command = new SqlCommand();
//command.CommandText = sqlQuery;
//command.CommandType = System.Data.CommandType.StoredProcedure;
//command.Connection = connection;
//SqlParameter IdPara=new SqlParameter("@POSTID",1);
//command.Parameters.Add(IdPara);
//SqlDataReader reader = command.ExecuteReader();
//if (reader.HasRows)
//{
//    while (reader.Read())
//    {
//        long BlogID = reader.GetInt64(0);
//        string BlogTitle = reader.GetString(1);
//        string BlogPostText = reader.GetString(2);
//        string BlogPostedBy = reader.GetString(3);
//BlogPost post=new BlogPost();


//        Console.WriteLine($"{BlogID}-{BlogTitle}-{BlogPostText}");

//    }
//}
//else
//{
//    Console.WriteLine("No Records Found");
//}
//SqlDataReader reader = command.ExecuteReader();
//if (reader.HasRows)
//{
//    while (reader.Read())
//    {
//        long BlogID = reader.GetInt64(0);
//        string BlogTitle = reader.GetString(1);
//        string BlogPostText = reader.GetString(2);
//        string BlogPostedBy = reader.GetString(3);

//        Console.WriteLine($"{BlogID}-{BlogTitle}-{BlogPostText}");

//    }
//}
//else
//{
//    Console.WriteLine("No Records Found");
//}


//string SqlQuery = "GETPOSTCOUNT";
//SqlCommand sqlCommand = new SqlCommand();
//sqlCommand.CommandText = SqlQuery;
//sqlCommand. CommandType=System.Data.CommandType.StoredProcedure;
//sqlCommand.Connection = connection;
//SqlParameter nameParam= new SqlParameter("@POSTEDBY","RAJ");
//sqlCommand.Parameters.Add(nameParam);
//SqlParameter countParam = new SqlParameter();
//countParam.ParameterName = "@POSTCOUNT";
//countParam.DbType=System.Data.DbType.Int32;
//countParam.Direction = System.Data.ParameterDirection.Output;
//sqlCommand.Parameters.Add(countParam);
//sqlCommand.ExecuteNonQuery();
//int RowCount=Convert.ToInt32(countParam.Value);
//Console.WriteLine($"Number of Records:{RowCount}");

//connection.Close();







//string sqlQuery = "Select * from BlogPost";
//SqlCommand sqlCommand = new SqlCommand();
//sqlCommand.CommandText=sqlQuery;
//sqlCommand.Connection=connection;
//SqlDataReader reader = sqlCommand.ExecuteReader();
//if (reader.HasRows)
//{
//    while (reader.Read())
//    {
//        long BlogID = reader.GetInt64(0);
//        string BlogTitle = reader.GetString(1);
//        string BlogPostText = reader.GetString(2);
//        string BlogPostedBy = reader.GetString(3);

//        Console.WriteLine($"{BlogID}-{BlogTitle}-{BlogPostText}");
//    }
//}
//else
//{
//    Console.WriteLine("No Records Found");
//}

