using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb12.Data;
using BlogAppWeb12.DTO;

namespace BlogAppWeb12
{
    public partial class ViewBlogComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dBAccess = new DBAccess())
            {
                List<BlogComment> commentList = dBAccess.GetAllComment();
                GridViewComment.DataSource = CommentList;
                GridViewComment.DataBind();
            }
        }
    }
}