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
    public partial class AddBlogComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dbAccess = new DBAccess())
            {
                List<BlogPost> postList = dbAccess.GetAllPosts();
                PostIdDropDown.DataSource = postList;
                PostIdDropDown.DataTextField = "Title";
                PostIdDropDown.DataValueField = "PostId";
                PostIdDropDown.DataBind();
            }
        }

        protected void btnAddComment_Click(object sender, EventArgs e)
        {
            long PostId = Convert.ToInt64(PostIdDropDown.SelectedItem.Value);
            string Title = txtTitle.Text;
            string CommentText = txtCommentText.Text;
            long CommentedBy = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dbAccess = new DBAccess())
            {
                bool Res = dbAccess.AddBlogComment(PostId,Title, CommentText, CommentedBy);
                if (Res)
                {
                    Response.Redirect("ViewBlogComment.aspx");
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}