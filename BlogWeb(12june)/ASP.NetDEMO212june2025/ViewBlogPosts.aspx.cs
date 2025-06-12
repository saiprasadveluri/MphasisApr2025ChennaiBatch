using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP.NetDEMO212june2025.Data;
using ASP.NetDEMO212june2025.DTO;

namespace ASP.NetDEMO212june2025
{
    public partial class ViewBlogPosts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DBAccess dbAccess = new DBAccess())
            {
                List<BlogPost> postList = dbAccess.GetAllPosts();
                gridBPost.DataSource = postList;
                gridBPost.DataBind();
                
            }
        }
    }
}