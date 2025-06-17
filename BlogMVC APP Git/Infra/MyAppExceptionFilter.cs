using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWebMVCApp.Infra
{
    public class MyAppExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Result = new RedirectResult("~/content/MyError.html");
            filterContext.ExceptionHandled = true;
        }
    }
}