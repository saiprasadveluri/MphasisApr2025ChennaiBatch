using Microsoft.AspNetCore.Mvc;
using MVC.DTO;
using System.Text.Json;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        public async Task<IActionResult> ViewUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(" https://localhost:7213/api/");
            HttpResponseMessage msg = await client.GetAsync("Account");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetUsers>(RespString);
            return View(list);  
        }
        
    }
}
