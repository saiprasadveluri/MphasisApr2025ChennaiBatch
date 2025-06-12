using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb2.Data;

namespace BlogAppWeb2
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            using(DBAccess dbAccess = new DBAccess())
            {
                bool ValidUser = dbAccess.ValidateUser(email, password, out long UserId);
                if (ValidUser)
                {
                    Session.Add("UserId", UserId);
                    Response.Redirect("AddBlogPost.aspx");
                }
            }
        }
    }
}