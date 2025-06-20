using Microsoft.AspNetCore.Mvc;
using VisitorManagement.Data;
using VisitorManagement.DTO;

namespace VisitorManagement.Controllers
{
    public class UserInfoController : Controller
    {
        private VisitorManagementContext context;
        public UserInfoController(VisitorManagementContext con)
        {
            context = con;
        }
        public IActionResult AddUser()
        {
            UserAddRoleDTO model = new UserAddRoleDTO();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddUSer(UserAddRoleDTO model)
        {
            if (ModelState.IsValid)
            {
                UserRole newobj = new UserRole()
                {
                    UserId = Guid.NewGuid(),
                    Email = model.Email,
                   
                    Password = model.Password,
                    Role = model.Role
                };
                context.userRoles.Add(newobj);
                int Rows = context.SaveChanges();
                if (Rows > 0)
                {
                    return RedirectToAction("UserView");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult UserView()
        {
            List<UserRoleDTO> Result = (context.userRoles.Select(u => new UserRoleDTO()
            {
                UserId = u.UserId,
                Email = u.Email,
                Role = u.Role,
               
            })).ToList();
            return View(Result);
            
        }
    }
}
