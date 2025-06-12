using BlogWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp
{
    public partial class Site1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Master.Page.Title = "Add New Blog";
        }

        protected void AddPost_Click(object sender, EventArgs e)
        {
            string title= TextTitle.Text;
            string PostText= TextPostText.Text;
            long UserId = Convert.ToInt64(Session["UserId"]);
            using (DbAccess dbAccess=new DbAccess())
            {
                bool res=dbAccess.AddBlogPost(UserId, title, PostText);
                if (res)
                {
                    Response.Redirect("View.aspx");
                }
            }
        }
    }
}