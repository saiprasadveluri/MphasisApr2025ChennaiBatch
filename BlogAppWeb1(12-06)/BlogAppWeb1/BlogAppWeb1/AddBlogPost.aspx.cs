using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb1.Data;

namespace BlogAppWeb1
{
    public partial class AddBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddPost_Click(object sender, EventArgs e)
        {
            string Title=txtTitle.Text;
            string PostText=txtPostText.Text;
            long UserId = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dbAccess = new DBAccess())
            {
                bool Res = dbAccess.AddBlogPost(UserId, Title, PostText);
                if (Res)
                {
                    Response.Redirect("ViewBlogpost.aspx");
                }

            }
        }
    }
}