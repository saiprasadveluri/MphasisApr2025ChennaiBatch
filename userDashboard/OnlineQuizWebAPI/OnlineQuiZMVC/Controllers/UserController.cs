using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineQuiZMVC.DATA;
using OnlineQuiZMVC.DTO;
using OnlineQuiZMVC.Helpers;

namespace OnlineQuiZMVC.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Dashboard()
        {
            AccountUserDTO accountUserDTO = new AccountUserDTO(); // var user = HttpContext.Session.GetObject<AccountUserDTO>("User");
            return View(accountUserDTO);
        }
        public IActionResult TrackProgress()
        {
            //var model = new ProgressViewModel
            //{
            //    CompletedCount = 12,
            //    AverageScore = 88,
            //    HighestScore = 96
            //};
            return View();
        }
        public IActionResult TakeQuiz()
        {
            var model = new QuizSelectionViewDTO
            {
                CategoryOptions = new List<SelectListItem>
        {
            new() { Value = "Frontend", Text = "Frontend" },
            new() { Value = "Backend", Text = "Backend" },
            new() { Value = "DataBase", Text = "DataBase" }
        },
                TopicOptions = new List<SelectListItem>
        {
            new() { Value = "C#", Text = "C#" },
            new() { Value = "HTML", Text = "HTML" },
            new() { Value = "CSS", Text = "CSS" }
        },
                ScheduleTime = DateTime.Today
            };

            return PartialView("_TakeQuizPartial", model);
        }

        //public IActionResult Profile()
        //{
        //    return View(User);
        //}
        //public IActionResult EditProfile()
        //{
        //    return View(User);
        //}


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

