using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly HttpClient _client;

        public AdminController(IHttpClientFactory factory, IConfiguration config)
        {
            _client = factory.CreateClient();
            _client.BaseAddress = new Uri(config["ApiBaseUrl"]);
        }

        public IActionResult Index() => View(); // Admin Dashboard

        [HttpGet]
        public IActionResult AddTheatre() => View();

        [HttpPost]
        public async Task<IActionResult> AddTheatre(TheatreModel model)
        {
            await _client.PostAsJsonAsync("api/Theatre", model);
            TempData["Message"] = "Theatre added successfully.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveTheatre(int id)
        {
            await _client.DeleteAsync($"api/Theatre/{id}");
            return RedirectToAction("Index");
        }
    }
}
