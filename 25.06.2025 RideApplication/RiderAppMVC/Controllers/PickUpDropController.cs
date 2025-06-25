using Microsoft.AspNetCore.Mvc;
using RideAPPMVC.Models;
using System.Text.Json;

namespace RideAPPMVC.Controllers
{
    public class PickUpDropController : Controller
    {
        private readonly HttpClient _client;

        public PickUpDropController(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("https://localhost:7153/API/");
        }

        public async Task<IActionResult> PickUpDropView()
        {
            var msg = await _client.GetAsync("PickUpDrop");
            msg.EnsureSuccessStatusCode();

            var respString = await msg.Content.ReadAsStringAsync();
            Console.WriteLine(respString);
            var lst = JsonSerializer.Deserialize<GetAllPick>(respString);

            return View(lst?.data ?? new List<PickUpDropDTO>());
        }
        [HttpPost]
        public async Task<IActionResult> BookRide(PickUpDropDTO pick)
        {
            var response = await _client.PostAsJsonAsync("PickUpDrop", pick);
            if (response.IsSuccessStatusCode)
            {
                var created = await response.Content.ReadFromJsonAsync<PickUpDropDTO>();
                return RedirectToAction("PickUpDropView",new {id = created.pId});
            }
            ModelState.AddModelError(" ", "Failed to Book!!");
            return View(pick);
        }
        [HttpGet]
        public IActionResult BookRide() { return View(new PickUpDropDTO()); }

    } 
}
    

