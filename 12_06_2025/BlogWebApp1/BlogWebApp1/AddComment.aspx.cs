using BlogWebApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BlogWebApp1
{
    public partial class AddComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddComment_Click(object sender, EventArgs e)
        {
            
            string CommentDesc = txtCommentDesc.Text;
            long UserId = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dBAccess = new DBAccess())
            {
                bool Res = dBAccess.AddComment(UserId, CommentDesc);
                if (Res)
                {
                    Response.Redirect("ViewComments.aspx");
                }
            }
        }
    }
}