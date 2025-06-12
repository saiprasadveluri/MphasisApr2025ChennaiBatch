using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.DTO;

namespace WebApplication1
{
    public partial class ViewComments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dbAccess = new DBAccess())
            {
                List<Comments> commentList = dbAccess.GetAllComments();
                gridCommentList.DataSource = commentList;
                gridCommentList.DataBind();
            }
        }
    }
    
}