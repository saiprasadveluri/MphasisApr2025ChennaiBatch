using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Data;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void Page_PreInit()
        //{
        //    //this.MasterPageFile = "Site1.Master";
        //}

        protected void btnAddPost_Click(object sender, EventArgs e)
        {
            string Title=txtTtile.Text;
            string PostText=txtPostText.Text;
            //string PostedBy = txtPostedBy.Text;
            long UserId=Convert.ToInt64(Session["UserId"]);
            using (DBAccess dbAccess = new DBAccess())
            {
                bool Res = dbAccess.AddBlogPost(UserId, Title, PostText);
                if (Res)
                {
                    Response.Redirect("ViewBlogPost.aspx");
                }
            }
        }
    }
}