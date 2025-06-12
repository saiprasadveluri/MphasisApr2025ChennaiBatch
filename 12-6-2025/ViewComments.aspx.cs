using BlogWinApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWinApp
{
    public partial class ViewComments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dbAccess = new DBAccess())
            {
                List<Comments> commentslist = dbAccess.GetAllComments();
                gridcmtlist.DataSource = commentslist;
                gridcmtlist.DataBind();
            }
        }
    }
}