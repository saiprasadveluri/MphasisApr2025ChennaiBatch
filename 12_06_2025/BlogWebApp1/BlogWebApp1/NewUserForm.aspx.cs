using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp1
{
    public partial class NewUserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void boxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSaveUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ConfirmationForm.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        protected void Page_PreInit()
        {
            Theme = "Skin2";
        }
    }
}