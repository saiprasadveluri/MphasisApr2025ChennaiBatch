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
    public partial class ViewBlogpost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DBAccess dBAccess=new DBAccess())
            {
                List<BlogPost> postList=dBAccess.GetAllPosts();
                gridBpost.DataSource = postList;    
                gridBpost.DataBind();   
            }
           // Master.Page.Title = "View Blog Post";
        }
        protected void Page_PreInit()
        {
            //this.MasterPageFile = "site1.master";
        }

    }
}