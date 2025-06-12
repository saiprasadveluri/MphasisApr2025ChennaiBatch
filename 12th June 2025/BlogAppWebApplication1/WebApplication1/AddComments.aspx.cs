using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddComments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAddComment_Click(object sender, EventArgs e)
        {
            long postId = Convert.ToInt64(txtPostId.Text);
            string Title = txtTitle.Text;
            string CommentText = txtCommentTxt.Text;
            long UserId = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dbAccess = new DBAccess())
            {
                bool Res = dbAccess.AddComments(UserId, postId, Title, CommentText);
                if (Res)
                {

                    Response.Redirect("ViewComments.aspx");
                }
            }
        }
    }
}