using Microsoft.AspNetCore.Mvc;
using RideAggregatetorMVCAPI.DTO;
using RideAggregatorMVC.MVCDTO;
using System.Text.Json;

namespace RideAggregatorMVC.Controllers
{
    public class DriverController : Controller
    {
        public async Task<IActionResult> ViewDrivers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214/api/");
            HttpResponseMessage msg = await client.GetAsync("Driver"); 
            msg.EnsureSuccessStatusCode();//checking the success or not if i get 200 succes or else throw a exception
            string repstr = await msg.Content.ReadAsStringAsync();
            var l = JsonSerializer.Deserialize<GetDrivers>(repstr);
            return View(l);
        }
    }
}
