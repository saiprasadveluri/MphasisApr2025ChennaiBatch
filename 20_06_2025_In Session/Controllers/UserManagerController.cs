using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomManagerMVCApp.Data;
using RoomManagerMVCApp.DTO;
using System.Linq;
namespace RoomManagerMVCApp.Controllers
{
    [Authorize]
    public class UserManagerController : Controller
    {
        RoomManagerDbContext context;
        public UserManagerController(RoomManagerDbContext ctx) 
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {//Model List of UserInfoDTO objects.

           List<UserInfoDTO> Result= (context.UserInfos.Select(u => new UserInfoDTO()
            {
                DisplayName=u.DisplayName,
                Email=u.Email,
                UserRole=u.UserRole,
                UserId=u.UserId,
            })).ToList();
            
            return View(Result);
        }

        [HttpGet]
        [Authorize(Policy = "OnlyAdmin")]
        public ActionResult AddUser()
        {
            UserAddInfoDTO model= new UserAddInfoDTO();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddUser(UserAddInfoDTO model)
        {
            if (ModelState.IsValid)
            {
                UserInfo newObj = new UserInfo()
                {
                    DisplayName = model.DisplayName,
                    Email = model.Email,
                    UserId = Guid.NewGuid(),
                    Password = model.Password,
                    UserRole = model.UserRole,
                };
                context.UserInfos.Add(newObj);
                int RowsAdded=context.SaveChanges();
                if(RowsAdded>0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}
