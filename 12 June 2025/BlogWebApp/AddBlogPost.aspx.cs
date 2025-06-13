using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class AddBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Btttn(object sender, EventArgs e)
        {
            string BlogTitle = TextBox2.Text;
            string BlogPostText = txtPostText.Text;
            string PostedBy = TextBox1.Text;        
            using (BlogApp dbAccess = new BlogApp())
            {
                List<BlogPost> result = dbAccess.AddBlogPost(BlogTitle, BlogPostText, PostedBy);
                if (result != null && result.Count > 0)
                {
                    Response.Redirect("ViewBlogPost.aspx");
                }
            }
        }
    }
}