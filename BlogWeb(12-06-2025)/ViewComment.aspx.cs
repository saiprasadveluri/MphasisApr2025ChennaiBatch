using BlogWebApp.Data;
using BlogWebApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp
{
    public partial class ViewComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DbAccess dbAccess = new DbAccess())
            {
                List<BlogComment> commentList = dbAccess.GetAllComments();
                GridViewComment.DataSource = commentList;
                GridViewComment.DataBind();
            }
        }
    }
}