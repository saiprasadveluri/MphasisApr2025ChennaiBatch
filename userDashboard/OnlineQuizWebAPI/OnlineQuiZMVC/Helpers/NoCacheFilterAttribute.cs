using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;

namespace OnlineQuiZMVC.Helpers
{
    public class NoCacheFilterAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context) 
        {
            var response = context.HttpContext.Response; 
            response.Headers[HeaderNames.CacheControl] = "no-cache, no-store, must-revalidate";
            response.Headers[HeaderNames.Pragma] = "no-cache";
            response.Headers[HeaderNames.Expires] = "0"; 
            base.OnResultExecuting(context); 
        }
    }
}
