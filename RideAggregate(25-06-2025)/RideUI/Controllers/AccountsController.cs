using Microsoft.AspNetCore.Mvc;
using RideUI.DTO;
using System.Text.Json;

namespace RideUI.Controllers
{
    public class AccountsController : Controller
    {
        private readonly HttpClient _client;

        public AccountsController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("http://localhost:5067/api/");
        }

        public async Task<IActionResult> ViewUsers()
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:5067/api/");
            HttpResponseMessage msg = await _client.GetAsync("Account");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list=JsonSerializer.Deserialize<GetUserData>(RespString);
            return View(list);
        }

        public async Task<GetUserData> GetUsers()
        {
            try
            {
                HttpResponseMessage msg = await _client.GetAsync("Account");
                msg.EnsureSuccessStatusCode();
                string RespString = await msg.Content.ReadAsStringAsync();
                var list = JsonSerializer.Deserialize<GetUserData>(RespString);
                return list;
            }
            catch (HttpRequestException e)
            {
                // Handle error (e.g., log it, return null, etc.)
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
            GetUserData user = await GetUsers();
            var list =user.data.FirstOrDefault(u => u.email == data.email && u.password == data.password);
            if (list.userRole == "customer")
            {
                return RedirectToAction("ViewCustomers", "Customer");
            }
            else if (list.userRole == "driver")
            {
                return RedirectToAction("ViewDriver", "Driver");
            }
            return View();
        }
    }
}
