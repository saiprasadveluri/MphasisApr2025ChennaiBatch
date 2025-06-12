using BlogWebApp1.Data;
using BlogWebApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp1
{
    public partial class ViewBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           using(DBAccess dBAccess = new DBAccess())
            {
                List<BlogPost> postList= dBAccess.GetAllPosts();
                gridBlogPost.DataSource = postList;
                gridBlogPost.DataBind();   
            }
        }
        
    }
}