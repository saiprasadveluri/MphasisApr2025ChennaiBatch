using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace RoomManagerMVCApp.Infra
{
    public class CustomAutzFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(!IsAuthorized(context.HttpContext.User))
            {
                context.Result = new RedirectToActionResult("Login", "Account",null);
            }
        }

        private bool IsAuthorized(ClaimsPrincipal user)
        {
            // Check if the user is authenticated
            // Implement your custom authorization logic here
            // Check roles, claims, policies, or any other criteria
            // Return true if authorized, false if not
            return true; // For demonstration purposes
        }
    }
}
