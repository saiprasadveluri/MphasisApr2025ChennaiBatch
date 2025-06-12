using BlogWebApp1.Data;
using BlogWebApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp1
{
    public partial class AddBlogComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Prevent multiple bindings on postbacks
            {
                LoadPostIds(); // Call method to populate dropdown
            }
        }

        private void LoadPostIds()
        {
            using (DBAccess dbAccess = new DBAccess())
            {
                List<BlogPost> posts = dbAccess.GetAllPosts(); // Fetch blog posts

                if (posts.Count > 0)
                {
                    drpDownPostId.DataSource = posts;
                    drpDownPostId.DataTextField = "PostTitle"; // Display post title
                    drpDownPostId.DataValueField = "PostId"; // Store PostId as value
                    drpDownPostId.DataBind();   
                }
               
            }
        }

        protected void btnAddComment_Click(object sender, EventArgs e)
        {
            long PostId = Convert.ToInt64(drpDownPostId.SelectedValue);
            string Title = txtTitle.Text;
            string CommentText= txtCommentText.Text;
            long UserId = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dbAccess = new DBAccess())
            {
                bool Res = dbAccess.AddBlogComment(PostId, Title, CommentText, UserId);
                if (Res)
                {
                    Response.Redirect("ViewBlogComment.aspx");
                }
            }
        }
    }
}