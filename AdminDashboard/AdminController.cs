using Microsoft.AspNetCore.Mvc;
using OnlineQuizApp.DTO;

namespace OnlineQuizApp.Controllers
{
    public class AdminController : Controller
    {
        AccountAdminDTO currentadmin = new AccountAdminDTO
        {
            Email = "admin@example.com",
            Password = "admin123",
            AdminName = "Super Admin",
            ContactNo = "9876543210"
        };
        public IActionResult Profile()
        {
            return View(currentadmin);
        }
        public IActionResult EditProfile()
        {
            return View(currentadmin);
        }
    }
}
