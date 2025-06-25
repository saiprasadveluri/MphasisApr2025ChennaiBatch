using Microsoft.AspNetCore.Mvc;
using RideAggregrator.DTO;
using System.Text.Json;

namespace RideAggregrator.Controllers
{
    public class AccountController : Controller
    {
        public  async Task<IActionResult> ViewUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7035/api/");
            HttpResponseMessage msg = await client.GetAsync("Account");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var List = JsonSerializer.Deserialize<GetUsers>(RespString);
            return View(List);



            
        }
    }
}
