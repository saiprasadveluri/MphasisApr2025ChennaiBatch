using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb12.Data;
using BlogAppWeb12.DTO;

namespace BlogAppWeb12
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
             protected void SaveCommentButton_Click(object sender, EventArgs e)
        {
            long PostId = Convert.ToInt64(PostIdDropDown.SelectedItem.Value);
            string commentTitle = TextCommentTitle.Text;
            string commentText = TextComment.Text;
            long commentBy = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dbAccess = new DBAccess())
            {
                bool res = dbAccess.AddBlogComment(PostId, commentTitle, commentText, commentBy);
                if (res)
                {
                    Response.Redirect("ViewComment.aspx");
                }
            }
        }
    }
}