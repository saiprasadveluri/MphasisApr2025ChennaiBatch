using BlogWebApp.Data;
using BlogWebApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Master.Page.Title = "View Page Load";
            using(DbAccess dbAccess = new DbAccess())
            {
                List<BlogPost> postlist =dbAccess.GetAllPosts();
                GridView1.DataSource=postlist;
                GridView1.DataBind();
            }
        }
    }
}