using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.DTO;
using WebApplication4.Data;


namespace WebApplication4
{
    public partial class ViewBlogPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DBAccess dbAccess=new DBAccess())
            {
                List<BlogPost> postList = dbAccess.GetAllPosts();
                gridBlogPosts.DataSource = postList;
                gridBlogPosts.DataBind();


            }
            //Master.Page.Title = "View Blog Post";
        }
        //protected void Page_PreInit()
        //{
        //    //this.MasterPageFile = "Site1.Master";
        //}
    }
}