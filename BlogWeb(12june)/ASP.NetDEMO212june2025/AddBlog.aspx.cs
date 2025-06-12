using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP.NetDEMO212june2025.Data;

namespace ASP.NetDEMO212june2025
{
    public partial class AddBlog : System.Web.UI.Page
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
                bool Res = dBAccess.AddBlogPost(UserId, Title, PostText);
                if (Res)
                {
                    Response.Redirect("ViewBlogPosts.aspx");
                }
            }
        }
    }
}