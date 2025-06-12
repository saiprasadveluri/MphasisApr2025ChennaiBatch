using BlogWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextUserEmail.Text;
            string password = TextPassword.Text;
            using(DbAccess  dbAccess = new DbAccess())
            {
                bool validateUser=dbAccess.ValidateUser(email, password,out long UserId);
                if(validateUser)
                {
                    Session.Add("UserId", UserId);
                    Response.Redirect("/View.aspx");
                }
            }
        }
    }
}