using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web2.Data;
using Web2.DTO;

namespace Web2
{
    public partial class siteM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddPost_Click(object sender, EventArgs e)
        {
            string Title=txtTitle.Text;
            string PostText=txtPostText.Text;
            long Userid = Convert.ToInt64(Session["UserId"]);
            using(DataAccess data=new DataAccess())
            {
                bool Res=data.AddBlogPost(Userid,Title, PostText);
                if (Res)
                {
                    Response.Redirect("ViewBlog.aspx");
                }
            }
        }
    }
}