using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineQuiZMVC.DTO;
using System.Text.Json;

namespace OnlineQuiZMVC.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Index()
        {
            var user = GetUserFromSession(); // Custom method to retrieve logged-in user
            return View(user);
        }

        // Edit Profile GET
        public ActionResult Edit()
        {
            var user = GetUserFromSession();
            return View(user);
        }

        // Edit Profile POST
        [HttpPost]
        public ActionResult Edit(UserDTO updatedProfile)
        {
            if (ModelState.IsValid)
            {
                SaveUserProfile(updatedProfile);
                TempData["SuccessMessage"] = "Profile updated successfully!";
                return RedirectToAction("Index");
            }
            return View(updatedProfile);
        }

        // Logout
        public ActionResult Logout()
        {
         HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }

        // Helpers
        private UserDTO GetUserFromSession()
        {
            var sessionData = HttpContext.Session.GetString("UserProfile");
            return string.IsNullOrEmpty(sessionData)
                ? null
                : JsonSerializer.Deserialize<UserDTO>(sessionData);
        }

        private void SaveUserProfile(UserDTO profile)
        {
            var jsonData = JsonSerializer.Serialize(profile);
            HttpContext.Session.SetString("UserProfile", jsonData);
        }
    }
}

