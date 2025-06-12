using System;
using System.Collections.Generic;
using BlogWebApp1.Data;
using BlogWebApp1.DTO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWebApp1
{
    public partial class ViewBlogComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dBAccess = new DBAccess())
            {
                List<BlogComment> postList = dBAccess.GetAllComments();
                gridBlogComment.DataSource = postList;
                gridBlogComment.DataBind();
            }
        }
    }
}