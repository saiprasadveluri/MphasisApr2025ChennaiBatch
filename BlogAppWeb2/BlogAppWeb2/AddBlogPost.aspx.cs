using BlogAppWeb2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogAppWeb2
{
    public partial class AddBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAddPost_Click(object sender, EventArgs e)
        {
            string BlogTitle = txtTitle.Text;
            string BlogPostText = txtPostText.Text;
            long UserId = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dbAccess = new DBAccess())
            {
                bool Res = dbAccess.AddBlogComment(UserId, BlogTitle, BlogPostText);
                if(Res)
                {
                    Response.Redirect("ViewBlogPosts.aspx");
                }
            }
        }
    }
}