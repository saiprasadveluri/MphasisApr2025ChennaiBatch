using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogAppWeb1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.Page.Title = "View Blog Post";
        }
        protected void Page_PreInit()
        {
            //this.MasterPageFile = "Site1.Master";
        }
    }
}