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
    public partial class AddComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (DBAccess dbAccess = new DBAccess())
                {
                    List<BlogPost> blogPosts = dbAccess.GetAllPosts();
                    ddlPostId.DataSource = blogPosts;
                    ddlPostId.DataTextField = "Title";  // Display title
                    ddlPostId.DataValueField = "PostId";  // Store PostId
                    ddlPostId.DataBind();
                }

                using (DBAccess dbAccess = new DBAccess())
                {
                    if (ddlPostId.SelectedValue != null)
                    {
                        long PostId = Convert.ToInt64(ddlPostId.SelectedValue);
                        List<BlogComment> comments = dbAccess.GetCommentsByPostId(PostId);
                        gridComments.DataSource = comments;
                        gridComments.DataBind();
                    }
                }
            }

        }

        protected void btnAddComment_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            string CommentText = txtCommentText.Text;
            string CommentBy = txtCommentBy.Text;

            if (!string.IsNullOrEmpty(ddlPostId.SelectedValue))
            {
                long PostId = Convert.ToInt64(ddlPostId.SelectedValue);

                using (DBAccess dbAccess = new DBAccess())
                {
                    bool Res = dbAccess.AddComment(PostId, Title, CommentText, CommentBy);
                    if (Res)
                    {
                        List<BlogComment> comments = dbAccess.GetCommentsByPostId(PostId);
                        gridComments.DataSource = comments;
                        gridComments.DataBind();
                    }
                }
            }
        }
    }
}