using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWinApp
{
    public partial class AddBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddpost_Click(object sender, EventArgs e)
        {
            string title=txttitle.Text;
            string posttext=txtPosttxt.Text;
            long userid = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dBAccess = new DBAccess())
            {
                bool res = dBAccess.AddBlogPost(userid, title, posttext);
                if (res)
                {
                    Response.Redirect("ViewBlogPost.aspx");
                }
            }
        }
    }
}