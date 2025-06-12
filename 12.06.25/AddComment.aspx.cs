using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Data;

namespace WebApplication4
{
    public partial class AddComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPostIds();
            }
        }
        private void LoadPostIds()
        {
            DBAccess dataAccess = new DBAccess();
            DataTable dt = dataAccess.GetAllBlogPosts(); 
            ddlPostId.DataSource = dt;
            ddlPostId.DataTextField = "Title";
            ddlPostId.DataValueField = "PostId";
            ddlPostId.DataBind();
        }

        protected void btnAddComment_Click(object sender, EventArgs e)
        {
            int PostId = int.Parse(ddlPostId.SelectedValue);
            string Title = txtTitle.Text;
            string CommentText = txtCommentText.Text;

            DBAccess dataAccess = new DBAccess();
            dataAccess.AddComment(PostId, Title, CommentText);

            lblStatus.Text = "Comment added successfully!";
            txtTitle.Text = txtCommentText.Text = "";
            Response.Redirect("ViewComments.aspx");

        }
    }
}