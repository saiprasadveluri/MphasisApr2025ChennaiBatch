using Microsoft.AspNetCore.Mvc;
using RideAggrigateUI.DTO;
using System.Text.Json;

namespace RideAggrigateUI.Controllers
{
    public class UserDataController : Controller
    {
      public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://localhost:7165/API/");
            HttpResponseMessage msg = await client.GetAsync("User");
            msg.EnsureSuccessStatusCode();
            string RespString = await msg.Content.ReadAsStringAsync();
            var Lst = JsonSerializer.Deserialize<GetAllUserDataModel>(RespString);
            return View(Lst);
        }


    }
    }

