using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly HttpClient _client;

        public UserController(IHttpClientFactory factory, IConfiguration config)
        {
            _client = factory.CreateClient();
            _client.BaseAddress = new Uri(config["ApiBaseUrl"]);
        }

        public IActionResult Index() => View(); // User Dashboard

        public async Task<IActionResult> MyBookings()
        {
            var userId = TempData["UserId"]; // Replace with session or actual ID
            var result = await _client.GetFromJsonAsync<List<BookingDTO>>($"api/Booking/user/{userId}");
            return View(result);
        }
    }
}
