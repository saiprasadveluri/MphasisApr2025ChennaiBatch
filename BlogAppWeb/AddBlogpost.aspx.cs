using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb.Data;

namespace BlogAppWeb
{
    public partial class AddBlogpost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string Title=txtTitle.Text;
            string PostText=txtPostText.Text;
            long UserId = Convert.ToInt64(Session["UserId"]);
            using (DBAccess dBAccess = new DBAccess())
            {
                bool res = dBAccess.AddBlogPost(UserId, Title, PostText);
                if (res)
                {
                    Response.Redirect("ViewPost.aspx");
                }
            }

        }
    }
}