namespace RoomManagerMVCApp.Infra
{
    public class CustomExceptionMiddleware: IMiddleware
    {       
        private readonly ILogger<CustomExceptionMiddleware> _logger;
        public CustomExceptionMiddleware(ILogger<CustomExceptionMiddleware> logger)
        {            
            _logger = logger;
        }
        

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                context.Response.Redirect("/Home/Index");
            }
        }
    }

    public static class RegisterCustomExceptionMiddleware
    {
        public static IApplicationBuilder RegisterCustomException(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
