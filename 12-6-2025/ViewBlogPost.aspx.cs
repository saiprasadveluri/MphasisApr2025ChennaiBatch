using BlogWinApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWinApp
{
    public partial class ViewBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dbAccess = new DBAccess())
            {
                List<BlogPost> postlist=dbAccess.GetAllPosts();
                gridUserData.DataSource = postlist;
                gridUserData.DataBind();
            }
        }
    }
}