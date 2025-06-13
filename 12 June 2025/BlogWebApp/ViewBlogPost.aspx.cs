using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class ViewBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBlogPosts();
            }
        }

        private void LoadBlogPosts()
        {
            using (BlogApp dbAccess = new BlogApp())
            {
                List<BlogPost> postList = dbAccess.GetAllPosts();
                gridBlogPost.DataSource = postList;
                gridBlogPost.DataBind();
            }
        }
    }
}