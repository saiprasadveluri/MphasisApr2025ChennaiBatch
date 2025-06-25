using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideAggregatetorMVCAPI.DataDTO;
using RideAggregatetorMVCAPI.DTO;
using RideAggregatorMVC.MVCDTO;
using System.Text.Json;

namespace RideAggregatorMVC.Controllers
{
    public class AccountController : Controller
    {
       private readonly RideContext context;
        public AccountController(RideContext con)
        {
            context=con;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ViewUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7214/api/");
            HttpResponseMessage msg = await client.GetAsync("User");
            msg.EnsureSuccessStatusCode();//checking the success or not if i get 200 succes or else throw a exception
            string repstr = await msg.Content.ReadAsStringAsync();
            var l = JsonSerializer.Deserialize<UserLogin>(repstr);
            return View(l);
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email,string password,string role)
        {
            if (ModelState.IsValid)
            {
                var user = await context.UserInfos
                 .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
                if (user == null)
                {
                    if (role == "Customer")
                    {

                        return RedirectToAction("ViewCustomers", "Customer");
                    }
                }
            }
            return View();
        }



    }
}
