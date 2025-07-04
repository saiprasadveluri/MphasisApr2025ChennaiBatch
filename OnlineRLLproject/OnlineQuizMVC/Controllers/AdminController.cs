using Microsoft.AspNetCore.Mvc;
using OnlineQuizMVC.ClientServices;
using OnlineQuizMVC.DTO;
using System.Text.Json;

namespace OnlineQuizMVC.Controllers
{
    public class AdminController : Controller
    {
       
            ServicesMVC clientServices;
       
        public AdminController(ServicesMVC services)
        {
            clientServices = services;
        }
        [HttpGet]
        public async Task<IActionResult> AdminDashboard()
        {
            var users = await clientServices.GetAllUsers(); // Calling your API
            ViewBag.UserCount = users.Count;           // 
                                                       // 1. Get session object
            var sessionData = HttpContext.Session.GetString("AccountData");

            if (string.IsNullOrEmpty(sessionData))
                return RedirectToAction("AccountLogin", "Account");

            var accountInfo = JsonSerializer.Deserialize<AccountInfoDTO>(sessionData);

            // 2. Get admin full profile
            var admin = await clientServices.GetAdminById(accountInfo.accountId);

            ViewBag.AdminName = admin.adminName;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Getusers()
        {
            var usersList = await clientServices.GetAllUsers();

            return View(usersList);
        }
        [HttpPost]

        public async Task<IActionResult> DeleteUser(Guid id)

        {
            bool status = await clientServices.DeleteUser(id);

            return RedirectToAction("GetUsers");

        }


        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            // Retrieve the stored object from session
            var sessionData = HttpContext.Session.GetString("AccountData");

            var accountInfo = JsonSerializer.Deserialize<AccountInfoDTO>(sessionData);

            var admin = await clientServices.GetAdminById(accountInfo.accountId);

            if (admin == null)
            {
                return NotFound();
            }

            return View("Profile", admin);
        }
        [HttpGet]
        public IActionResult CreateQuiz()
        {
            QuizQuestionsDTO quiz = new QuizQuestionsDTO();
            return View(quiz);
        }
        [HttpPost]
        public async Task<IActionResult> CreateQuizAsync(QuizQuestionsDTO model)
        {
            bool status = await clientServices.AddQuiz(model);
            return View(model);
        }
        [HttpGet]
        public IActionResult AddNewAdmin()
        {
            AccountAdminDTO model = new AccountAdminDTO();
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> AddNewAdmin(AccountAdminDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            bool success = await clientServices.AddAdmin(dto);
            if (!success)
            {
                ViewBag.Error = "Profile update failed.";
                return View(dto); // Return existing data with error message
            }
            TempData["SuccessMessage"] = "Admin successfully created!";
            return RedirectToAction("Profile", "Admin");
        }
        [HttpGet]
        public async Task<IActionResult> EditProfile(Guid id)
        {
            var profile = await clientServices.GetAdminById(id); // your service method to get data
            if (profile == null)
                return NotFound();

            return View(profile); // This populates the form
        }
        [HttpPost]
        public async Task<IActionResult> EditProfile(GetAccountAdminDTO dto)
        {
            // Map GetAccountAdminDTO to UpdateAdminDTO
            var updateData = new UpdateAdminDTO
            {
                adminName = dto.adminName,
                password = dto.password,
                contactNo = dto.contactNo
            };

            // Use AccountId from the DTO
            bool success = await clientServices.EditAdmin(dto.accountId, updateData);

            if (!success)
            {
                ViewBag.Error = "Profile update failed.";
                return View(dto); // Return existing data with error message
            }

            // Optionally retrieve latest profile data after update
            var updatedProfile = await clientServices.GetAdminById(dto.accountId);
            return View(updatedProfile);
        }
    }
    
}
