using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWebMVCApp.Infra
{
    public class MyAuth:AuthorizeAttribute
    {
        public string ReqRole;
        public MyAuth(string reqRole)
        {
            ReqRole = reqRole;
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserRole"] != null)
            {
                string UserAvlRole = filterContext.HttpContext.Session["UserRole"].ToString();
                if(ReqRole!= UserAvlRole)
                {
                    filterContext.HttpContext.Response.Redirect("/Account/LoginUser");
                }
            }
            base.OnAuthorization(filterContext);
        }
    }
}