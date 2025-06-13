using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }
        protected void bttn(object sender, EventArgs e)
        {
            // Here you would typically validate the user credentials
            // For example, check against a database or other data source

            string username = TextBox1.Text;
            string password = TextBox2.Text;
            BlogApp blogApp = new BlogApp();
            //if (blogApp.ValidateUser(username, password))
            //{
            //    // If validation is successful, redirect to the blog posts page
            //    Response.Redirect("ViewBlogPosts.aspx");
            //}
            //else
            //{
            //    // If validation fails, show an error message
            //    Label1.Text = "Invalid username or password.";
            //}
            Response.Redirect("/WebForm");
        }
    }
}