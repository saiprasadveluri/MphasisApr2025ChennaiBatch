using Microsoft.AspNetCore.Mvc;
using RideAggregateMVCAPI.DTO;
using System.Text.Json;

namespace RideAggregateMVCAPI.Controllers
{
    public class CustomerController : Controller
    {
        public async Task<IActionResult> ViewCustomers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            HttpResponseMessage msg = await client.GetAsync("Customer");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetAllCustomers>(respstring);
            return View(list);

        }
    }
}
