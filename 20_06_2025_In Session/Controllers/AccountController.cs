using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoomManagerMVCApp.Data;
using RoomManagerMVCApp.DTO;
using System.Security.Claims;//Key-Value pair.
using System.Text.Json;

namespace RoomManagerMVCApp.Controllers
{
    public class AccountController : Controller
    {
        RoomManagerDbContext context;
        public AccountController(RoomManagerDbContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginInfoDTO model)
        {
            if (ModelState.IsValid)
            {
               UserInfo uinfo= context.UserInfos.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
                if(uinfo!=null)//Login Success
                {
                    //Step 1: 
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, uinfo.Email));
                    claims.Add(new Claim(ClaimTypes.Role, uinfo.UserRole));
                    //Step 2:
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    //Step 3:
                    ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(principal);
                    //Store the UserInfo to Session...
                    string sreUserInfo=JsonSerializer.Serialize(uinfo);
                    HttpContext.Session.SetString("UserInfo", sreUserInfo);
                    return RedirectToAction("Index", "UserManager");
                }
            }
            return View();
        }
    }
}
