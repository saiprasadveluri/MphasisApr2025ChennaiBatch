using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb.Data;
using BlogAppWeb.Data.DTO;

namespace BlogAppWeb
{
    public partial class ViewPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           using(DBAccess dbAccess = new DBAccess())
            {
               List<BlogPost>postList= dbAccess.GetAllPosts();
                gridBlogPosts.DataSource = postList;
                gridBlogPosts.DataBind();
            }
        }
       
    }
}