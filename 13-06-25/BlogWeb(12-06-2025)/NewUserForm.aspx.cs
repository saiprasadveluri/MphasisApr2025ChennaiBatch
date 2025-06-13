using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp
{
    public partial class NewUserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Confirmation.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //this.Theme= "Skin1";
        }
        protected void Page_PreInit()
        {
            Theme = "Skin2";
        }
    }
}