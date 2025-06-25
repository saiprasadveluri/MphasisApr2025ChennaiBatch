using Microsoft.AspNetCore.Mvc;

namespace RideAggregatorMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Admin") return Unauthorized();
            return View();
        }
    }
}