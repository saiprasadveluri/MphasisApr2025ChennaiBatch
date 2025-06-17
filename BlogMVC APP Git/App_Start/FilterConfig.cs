using BlogWebMVCApp.Infra;
using System.Web;
using System.Web.Mvc;

namespace BlogWebMVCApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new MyAppExceptionFilter());
            filters.Add(new AuthorizeAttribute());
        }
    }
}
