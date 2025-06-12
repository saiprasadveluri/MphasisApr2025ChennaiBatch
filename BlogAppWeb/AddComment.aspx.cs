using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb.Data;
using BlogAppWeb.Data.DTO;

namespace BlogAppWeb
{
    public partial class AddComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dBAccess = new DBAccess())
            {
                List<BlogPost> blogPosts = dBAccess.GetAllPosts();
                DropDownList1.DataSource = blogPosts;
                DropDownList1.DataTextField = "Title";
                DropDownList1.DataValueField = "PostId";
                DropDownList1.DataBind();
            }
        }

        protected void btnAddComments_Click(object sender, EventArgs e)
        {
            long PostId= DropDownList1.SelectedIndex;
            string Title=txtTitle.Text;
            string CommentText=txtCommentText.Text;
            long CommentBy = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dBAccess = new DBAccess())
            {
                bool res = dBAccess.AddBlogComment(PostId, Title, CommentText, CommentBy);
                if (res)
                {
                    Response.Redirect("ViewBlogComment.aspx");
                }
            }

        }
    }
}