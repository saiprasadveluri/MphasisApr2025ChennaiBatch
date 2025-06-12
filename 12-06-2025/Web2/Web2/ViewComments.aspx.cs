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
    public partial class ViewComments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataAccess data = new DataAccess())
            {
                List<BlogComment> posts = data.GetAllComments();
                GridComment.DataSource = posts;
                GridComment.DataBind();
            }
        }
    }
}