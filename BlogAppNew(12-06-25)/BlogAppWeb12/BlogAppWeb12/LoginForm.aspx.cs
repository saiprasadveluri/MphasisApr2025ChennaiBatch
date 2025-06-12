using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb12;
using BlogAppWeb12.Data;

namespace BlogAppWeb12
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Email =txtEmail.Text;
            string Password = txtPassword.Text; 
            using(DBAccess dbAccess = new DBAccess())
            {
                bool ValidUser=dbAccess.ValidateUser(Email, Password,out long UserId);
                if (ValidUser)
                {
                    Session.Add("UserId",UserId);
                    Response.Redirect("ViewBlogPost.aspx");
                }
            }
        }
    }
}