using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb1.Data;

namespace BlogAppWeb1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddPost_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            string PostText = txtPostText.Text;
            long UserId = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dBAccess = new DBAccess())
            {
                bool Res = dBAccess.AddBlogPost(UserId,Title, PostText);
                if (Res)
                {
                    Response.Redirect("ViewBlogPosts.aspx");
                }
            }
        }
    }
}