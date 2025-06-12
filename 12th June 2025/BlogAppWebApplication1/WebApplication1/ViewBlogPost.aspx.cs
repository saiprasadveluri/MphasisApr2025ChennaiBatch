using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.DTO;

namespace WebApplication1
{
    public partial class ViewBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DBAccess dbAccess = new DBAccess())
            {
                List<BlogPost> postList = dbAccess.GetAllPosts();
                gridPostList.DataSource = postList;
                gridPostList.DataBind();
            }
        }
        protected void Page_PreInit()
        {
            //this.MasterPageFile = "Site.Master";
        }
    }
}