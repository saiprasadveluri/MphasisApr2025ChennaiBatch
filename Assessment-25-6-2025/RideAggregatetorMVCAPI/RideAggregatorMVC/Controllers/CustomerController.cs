using Microsoft.AspNetCore.Mvc;
using RideAggregatorMVC.MVCDTO;
using System.Text.Json;

namespace RideAggregatorMVC.Controllers
{
    public class CustomerController : Controller
    {
        public async Task<IActionResult> ViewCustomers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214/api/");
            HttpResponseMessage msg = await client.GetAsync("Customer");
            msg.EnsureSuccessStatusCode();//checking the success or not if i get 200 succes or else throw a exception
            string repstr = await msg.Content.ReadAsStringAsync();
            var l = JsonSerializer.Deserialize<GetCustomers>(repstr);
            return View(l);
        }
    }
}
