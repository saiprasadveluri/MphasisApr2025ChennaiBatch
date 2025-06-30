using JobSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JobSearchDatabase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }



        public IActionResult Index()
        {

            ViewData["HideNavbar"] = true;

            var cards = new List<(string Title, string Controller)>
    {
        ("User", "User"),
        ("Candidate", "Candidate"),
        ("Candidate Skills", "CandidateSkills"),
        ("Education", "Education"),
        ("Employer", "Employer"),
        ("Job Application", "JobApplication"),
        ("Job Category", "JobCategory"),
        ("Job Posting", "JobPosting"),
        ("Skill", "Skill"),
        ("Work Experience", "WorkExperience")
    };

            return View(cards);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
