using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWinApp
{
    public partial class NewUserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Confirmation.aspx");
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            //this.Theme.("/Skin2.skin");
        }
        protected void Page_PreInit()
        {
            Theme = "Skin2";
        }
    }
}