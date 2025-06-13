using BlogAppWeb2.Data;
using BlogAppWeb2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogAppWeb2
{
    public partial class AddBlogComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddComment_Click1(object sender, EventArgs e)
        {
            long BlogPostId = Convert.ToInt64(ddlBlogPostId.SelectedValue);
            string CommentTitle = txtCommentTitle.Text;
            string CommentText = txtCommentText.Text;
            using (DBAccess dbAccess = new DBAccess())
            {
                bool Res = dbAccess.AddBlogPost(BlogPostId, CommentTitle, CommentText);
                if (Res)
                {
                    Response.Redirect("ViewBlogComments.aspx");
                }
            }
        }
    }
}