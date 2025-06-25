using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using RideAggregateMVCAPI.DTO;

namespace RideAggregateMVCAPI.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> ViewUser()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            HttpResponseMessage msg = await client.GetAsync("User");
            msg.EnsureSuccessStatusCode();
            string respstring=await msg.Content.ReadAsStringAsync();
            var list=JsonSerializer.Deserialize<GetAllUsers>(respstring);
            return View(list);

        }
        public async Task<GetAllUsers> GetUsers()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7170/api/");
            HttpResponseMessage msg = await client.GetAsync("User");
            msg.EnsureSuccessStatusCode();
            string respstring = await msg.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<GetAllUsers>(respstring);
            return list;

        }
        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginUser data)
        {
            GetAllUsers user = await GetUsers();
            var list = user.data.FirstOrDefault(u => u.userEmail == data.email && u.password == data.password);
            if (list.userRole == "customer")
            {
                return RedirectToAction("ViewCustomers", "Customer");
            }
            else if (list.userRole == "driver")
            {
                return RedirectToAction("ViewDrivers", "Driver");
            }
            return View();
        }
    }
}

    //    private readonly HttpClient _httpClient;

    //    public UserController(IHttpClientFactory httpClientFactory)
    //    {
    //        _httpClient = httpClientFactory.CreateClient();
    //        _httpClient.BaseAddress = new Uri("https://localhost:7170/"); 
    //    }

    //    // GET: User
    //    public async Task<IActionResult> Index()
    //    {
    //        var response = await _httpClient.GetAsync("api/user");
    //        if (response.IsSuccessStatusCode)
    //        {
    //            var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<List<UserDTO>>>();
    //            return View(apiResponse.Data);
    //        }
    //        else
    //        {
    //            return View(new List<UserDTO>());
    //        }
    //    }

    //    // GET: Create User
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Create User
    //    [HttpPost]
    //    public async Task<IActionResult> Create(UserDTO model)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var response = await _httpClient.PostAsJsonAsync("api/user", model);
    //            if (response.IsSuccessStatusCode)
    //            {
    //                return RedirectToAction(nameof(Index));
    //            }
    //            else
    //            {
    //                ModelState.AddModelError("", "Error adding user");
    //            }
    //        }
    //        return View(model);
    //    }
    //}
    //public class ApiResponse<T>
    //{
    //    public T Data { get; set; }
    //}
    //public class UserDTO
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string UserRole  { get; set; }
       
    //}