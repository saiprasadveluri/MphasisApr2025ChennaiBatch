using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web2.Data;
using Web2.DTO;

namespace Web2
{
    public partial class Site2M : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Master.Page.Title = "View Blog Post";
            using (DataAccess data = new DataAccess())
            {
                List<BlogPost> posts = data.GetAllPosts();
                GridPosts.DataSource = posts;
                GridPosts.DataBind();
            }
        }
        
    }
}