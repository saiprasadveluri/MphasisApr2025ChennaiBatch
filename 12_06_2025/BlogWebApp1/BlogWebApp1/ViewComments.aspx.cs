using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogWebApp1.Data;
using BlogWebApp1.DTO;

namespace BlogWebApp1
{
    public partial class ViewComments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DBAccess dbAccess = new DBAccess())
            {
                List<Comments> commentList = dbAccess.GetAllComments();
                gridCommentList.DataSource = commentList;
                gridCommentList.DataBind();

            }

          
        }

        protected void Page_PreInit()
        {

        }
    }
}