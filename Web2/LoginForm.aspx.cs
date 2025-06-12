using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web2.Data;

namespace Web2
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email=txtEmail.Text;
            string password=txtPassword.Text;
            using (DataAccess dataAccess = new DataAccess())
            {
                bool ValidUser=dataAccess.ValidateUser(email, password,out long UserId);
                if (ValidUser)
                {
                    Session.Add("UserId",UserId);
                    Response.Redirect("ViewBlog.aspx");
                }
            }
        }
    }
}