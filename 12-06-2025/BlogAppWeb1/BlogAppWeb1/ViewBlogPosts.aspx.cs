using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb1.Data;
using BlogAppWeb1.DTO;

namespace BlogAppWeb1
{
    public partial class ViewBlogPosts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           using(DBAccess dBAccess = new DBAccess())
            {
                List<BlogPost> postList = dBAccess.GetAllPosts();
                gridBlogPosts.DataSource = postList;
                gridBlogPosts.DataBind();

            }
        }
    }
}