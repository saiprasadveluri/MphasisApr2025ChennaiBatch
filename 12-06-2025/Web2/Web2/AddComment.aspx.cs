using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web2.Data;
using Web2.DTO;

namespace Web2
{
    public partial class AddComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataAccess data = new DataAccess())
            {
                List<BlogPost> posts = data.GetAllPosts();
                DrpPost.DataSource=posts;
                DrpPost.DataTextField ="Title" ;
                DrpPost.DataValueField = "PostId";
                DrpPost.DataBind();
            }
        }

        protected void btnAddCom_Click(object sender, EventArgs e)
        {
            
            string CommentTitle=txtComtitle.Text;
            string CommentText=txtComText.Text;
            long CommentBy= Convert.ToInt64(Session["UserId"]);
            long PostId = Convert.ToInt64(DrpPost.SelectedItem.Value);
            using (DataAccess data = new DataAccess())
            {
                bool res = data.AddBlogComment(PostId,CommentTitle, CommentText, CommentBy);
                if(res)
                {
                    Response.Redirect("ViewComments.aspx");
                }
            }
        }
    }
}