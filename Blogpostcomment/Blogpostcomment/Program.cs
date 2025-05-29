// See https://aka.ms/new-console-template for more information  

using Blogpostcomment;
using Microsoft.Data.SqlClient;
//using DataAccessLayer;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace ADONetBlogWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DataAccess ds = new DataAccess();
            //ds.DeletePost(2);
            //ds.GetAllPosts();
            ////ds.AddPost("Science", "Science—the fascinating pursuit of understanding the universe! Science is a systematic discipline that builds and organizes knowledge through observation, experimentation, and reasoning.", "Sona");
            //ds.GetAllPosts();
            DataComment dataComment = new DataComment();
            //dataComment.AddComment(1,"Science", "Science—the fascinating pursuit of understanding the universe! Science is a systematic discipline that builds and organizes knowledge through observation, experimentation, and reasoning.", "Sona");
            //dataComment.GetAllPosts();
            dataComment.DeletePost(2);
        
        }
    }
}