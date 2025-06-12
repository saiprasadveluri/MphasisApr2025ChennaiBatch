using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string UEmail = txtUEmail.Text;
            string Pswd = txtPswd.Text;
            using(DBAccess dbAccess = new DBAccess())
            {
                bool ValidUser=dbAccess.ValidateUser(UEmail,Pswd,out long UserId);
                if (ValidUser)
                {
                    Session.Add("UserId",UserId);
                    Response.Redirect("ViewBlogPost.aspx");
                }
            }
        }
    }
}