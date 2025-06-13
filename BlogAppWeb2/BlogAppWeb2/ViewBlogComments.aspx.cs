using BlogAppWeb2.Data;
using BlogAppWeb2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogAppWeb2
{
    public partial class ViewBlogComments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dBAccess = new DBAccess())
            {
                List<BlogComment> commentList = dBAccess.GetAllComments();
                gridBlogComment.DataSource = commentList;
                gridBlogComment.DataBind();
            }
        }
    }
}