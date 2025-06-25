using Microsoft.AspNetCore.Mvc;
using RideAPPMVC.Models;
using System.Text.Json;
using static RideAPPMVC.Models.GetAllCustomer;

namespace RideAPPMVC.Controllers
{
    public class CustomerController : Controller
    {
            private readonly HttpClient _client;

            public CustomerController(HttpClient client)
            {
                _client = client;
                _client.BaseAddress = new Uri("https://localhost:7153/API/");
            }
            public async Task<IActionResult> CustomerView()
            {
                var msg = await _client.GetAsync("Customer");
                msg.EnsureSuccessStatusCode();

                var respString = await msg.Content.ReadAsStringAsync();
                Console.WriteLine(respString);
                var lst = JsonSerializer.Deserialize<GetAllCustomer>(respString);

                return View(lst?.data ?? new List<CustomerDTO>());
            }

    }
}
