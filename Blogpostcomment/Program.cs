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
            DataBComment dataBComment = new DataBComment();
            //dataBComment.AddBComment(1, "Science", "Science—the fascinating pursuit of understanding the universe! Science is a systematic discipline that builds and organizes knowledge through observation, experimentation, and reasoning.", "Sona");
            //dataBComment.GetAllPosts();
            dataBComment.DeletePost(2);
        }
    }
}
