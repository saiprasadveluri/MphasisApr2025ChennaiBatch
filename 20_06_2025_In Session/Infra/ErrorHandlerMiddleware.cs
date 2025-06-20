
namespace RoomManagerMVCApp.Infra
{
    public class ErrorHandlerMiddleware : IMiddleware
    {
        ILogger<ErrorHandlerMiddleware> _logger;
        public ErrorHandlerMiddleware(ILogger<ErrorHandlerMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {            
            try
            {
                await next(context);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                context.Response.Redirect("/Error/PipeError");
            }
        }
    }
}
