using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP.NetDEMO212june2025.Data;

namespace ASP.NetDEMO212june2025
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string Password = txtPassword.Text;
            using (DBAccess dbAccess = new DBAccess())
            {
                bool ValidUser = dbAccess.ValidateUser(email, Password,out long UserId);
                if (ValidUser)
                {
                    Response.Redirect("ViewBlogPosts.aspx");
                }
            }
        }
    }
}