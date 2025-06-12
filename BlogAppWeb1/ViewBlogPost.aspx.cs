using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogAppWeb1.Data;
using BlogAppWeb1.DTO;


namespace BlogAppWeb1
{
    public partial class ViewBlogPost : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.GridView gridComments;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dbAccess = new DBAccess())
            {
                List<BlogPost> postList = dbAccess.GetAllPosts();
                gridBlogPost.DataSource = postList;
                gridBlogPost.DataBind();
                if (Session["CurrentPostId"] != null && long.TryParse(Session["CurrentPostId"].ToString(), out long PostId))
                {
                    using (DBAccess dbAccess1 = new DBAccess())
                    {
                        List<BlogComment> comments = dbAccess1.GetCommentsByPostId(PostId);
                        gridComments.DataSource = comments;
                        gridComments.DataBind();
                    }
                }
                else
                {
                    // Handle the case where PostId is invalid or missing
                    Response.Write("<script>alert('No blog post selected for viewing comments.');</script>");
                }

            }
           
        }
           
        protected void Page_PreInit()
        {
            //this.MasterPageFile = "Site1.Master";
        }
    }
}