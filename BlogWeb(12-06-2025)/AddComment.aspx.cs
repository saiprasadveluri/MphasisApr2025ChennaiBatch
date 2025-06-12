using BlogWebApp.Data;
using BlogWebApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp
{
    public partial class AddComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DbAccess dbAccess=new DbAccess())
            {
                List<BlogPost> postList=dbAccess.GetAllPosts();
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
            using (DbAccess dbAccess = new DbAccess())
            {
                bool res = dbAccess.AddComment(PostId,commentTitle, commentText, commentBy);
                if (res)
                {
                    Response.Redirect("ViewComment.aspx");
                }
            }

        }
    }
}