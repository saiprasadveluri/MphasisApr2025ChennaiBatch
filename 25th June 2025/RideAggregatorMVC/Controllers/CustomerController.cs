using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.DTO;
using System.Text.Json;


namespace RideAggregatorMVC.Controllers
{
    public class CustomerController : Controller
    {
        public async Task<IActionResult> CustomerView()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/api/");
            HttpResponseMessage msg = await client.GetAsync("Customer");
            msg.EnsureSuccessStatusCode();
            string responseStr = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetAllCustomers>(responseStr);
            return View(list);
        }
    }
}
