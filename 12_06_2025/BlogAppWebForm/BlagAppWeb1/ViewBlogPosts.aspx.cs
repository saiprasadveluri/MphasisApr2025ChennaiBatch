using BlagAppWeb1.Data;
using BlagAppWeb1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlagAppWeb1
{
    public partial class ViewBlogPosts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        using(DBAccess dbAccess = new DBAccess())
        {
             List<BlogPost> postList=   dbAccess.GetAllPosts();
             gridBlogPosts.DataSource = postList;
             gridBlogPosts.DataBind();
        }
        }        
    }
}