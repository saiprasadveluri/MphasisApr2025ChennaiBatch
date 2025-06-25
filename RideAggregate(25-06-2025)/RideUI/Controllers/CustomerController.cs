using Microsoft.AspNetCore.Mvc;
using RideUI.DTO;
using System.Text.Json;

namespace RideUI.Controllers
{
    public class CustomerController : Controller
    {
        public async Task<IActionResult> ViewCustomers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5067/api/");
            HttpResponseMessage msg = await client.GetAsync("Customer");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetCustomer>(RespString);
            return View(list);
        }
    }
}
