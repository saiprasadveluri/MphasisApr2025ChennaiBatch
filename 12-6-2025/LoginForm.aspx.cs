using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogWinApp;

namespace BlogWinApp
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password=txtpassword.Text;
            using(DBAccess dbAccess = new DBAccess())
            {
                bool validuser=dbAccess.ValidateUser(email, password,out long UserId);
                if (validuser)
                {
                    Session.Add("UserId",UserId);
                    Response.Redirect("ViewBlogPost.aspx");
                }
            }
        }
    }
}