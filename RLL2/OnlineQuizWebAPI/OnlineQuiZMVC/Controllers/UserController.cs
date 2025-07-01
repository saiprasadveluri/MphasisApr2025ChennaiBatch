using Microsoft.AspNetCore.Mvc;
using OnlineQuiZMVC.DTO;
using OnlineQuiZMVC.Helpers;

namespace OnlineQuiZMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Dashboard()
        {
            AccountUserDTO accountUserDTO = new AccountUserDTO();
            // var user = HttpContext.Session.GetObject<AccountUserDTO>("User");
            return View(accountUserDTO);
        }
        

        //public IActionResult Edit()
        //{
        //    var user = HttpContext.Session.GetObject<AccountUserDTO>("User");
        //    return View(user);
        //}

        //[HttpPost]
        //public IActionResult Edit(AccountUserDTO updatedUser)
        //{
        //    if (!ModelState.IsValid)
        //        return View(updatedUser);

        //    HttpContext.Session.SetObject("User", updatedUser); // Save updated info
        //    return RedirectToAction("Dashboard", "User");
        //}
    }
}
