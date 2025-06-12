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
    public partial class ViewComments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPosts();
            }
        }
        private void LoadPosts()
        {
            DBAccess dataAccess = new DBAccess();
            DataTable dt = dataAccess.GetAllBlogPosts(); // Should return PostId and Title
            ddlPosts.DataSource = dt;
            ddlPosts.DataTextField = "Title";
            ddlPosts.DataValueField = "PostId";
            ddlPosts.DataBind();

            if (ddlPosts.Items.Count > 0)
            {
                LoadComments(int.Parse(ddlPosts.SelectedValue));
            }
        }
        protected void ddlPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int postId = int.Parse(ddlPosts.SelectedValue);
            LoadComments(postId);
        }

        private void LoadComments(int postId)
        {
            DBAccess dataAccess = new DBAccess();
            DataTable dt = dataAccess.GetCommentsByPostId(postId);
            gvComments.DataSource = dt;
            gvComments.DataBind();
        }
    }
}