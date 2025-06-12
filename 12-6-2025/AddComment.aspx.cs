using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWinApp
{
    public partial class AddComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddCmt_Click(object sender, EventArgs e)
        {
            
            long postid = Convert.ToInt64(txtpostid.Text);
            string title = txtcmtTitle.Text;
            string commenttext = txtcmttxt.Text;
            string commentedby=txtcmtedby.Text;
            using (DBAccess dBAccess = new DBAccess())
            {
                bool res = dBAccess.AddComments(postid,title,commenttext,commentedby);
                if (res)
                {
                    Response.Redirect("ViewComments.aspx");
                }
            }
        }
    }
}