using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("SomeControlID");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string name = TextBox2.Text;
            //string email = TextBox3.Text;
            //string pwd = TextBox4.Text;
            //string cpwd = TextBox5.Text;
            //string news = TextBox6.Text;

            //Response.Write(Response.ContentType = "text/plain");
            //Response.Write(name);
            //Response.Close();
        }
    }
}