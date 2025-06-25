using Microsoft.AspNetCore.Mvc;
using RideAggregatorUI.DTO;
using System.Text.Json;

namespace RideAggregatorUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpClient _client;

        public AccountController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7058/api/");
        }

        public async Task<IActionResult> ViewUsers()
        {
            
            HttpResponseMessage msg = await _client.GetAsync("Account");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetUser>(RespString);
            return View(list);
        }

        public async Task<GetUser> GetUsers()
        {
            try
            {
                HttpResponseMessage msg = await _client.GetAsync("Account");
                msg.EnsureSuccessStatusCode();
                string RespString = await msg.Content.ReadAsStringAsync();
                var list = JsonSerializer.Deserialize<GetUser>(RespString);
                return list;
            }
            catch (HttpRequestException e)
            {
               
                return null;
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUser data)
        {
           GetUser user = await GetUsers();
            var list = user.data.FirstOrDefault(u => u.Email == data.Email && u.Password == data.Password);
            if (list.UserRole == "customer")
            {
                return RedirectToAction("ViewCustomers", "Customer");
            }
            else if (list.UserRole == "driver")
            {
                return RedirectToAction("ViewDriver", "Driver");
            }
            return View();
        }
    }
}
