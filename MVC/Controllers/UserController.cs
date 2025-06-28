using Microsoft.AspNetCore.Mvc;
using OnlinePharmacyAppMVC.DTO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

public class UserController : Controller
{
    private readonly HttpClient _client;

    public UserController()
    {
        _client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7269/api/")
        };
    }

    // GET: /User/AddUser
    [HttpGet]
    public IActionResult AddUser()
    {
        return View();
    }

    // POST: /User/AddUser
    [HttpPost]
    public async Task<IActionResult> AddUser(UserDTO user)
    {
        try
        {
            var response = await _client.PostAsJsonAsync("User", user);
            if (response.IsSuccessStatusCode)
            {
                TempData["Success"] = "User added successfully!";
                return RedirectToAction("ViewUser");
            }
            else
            {
                TempData["Error"] = $"API Error: {response.StatusCode}";
                return View(user);
            }
        }
        catch (Exception ex)
        {
            TempData["Error"] = $"Exception: {ex.Message}";
            return View(user);
        }
    }

    // GET: /User/ViewUser
    [HttpGet]
    public async Task<IActionResult> ViewUser()
    {
        try
        {
            var response = await _client.GetAsync("User");
            if (!response.IsSuccessStatusCode)
            {
                TempData["Error"] = "Failed to load user list.";
                return View(new GetUsers { data = new List<UserDTO>() });
            }

            var result = await response.Content.ReadFromJsonAsync<GetUsers>();
            return View(result);
        }
        catch (Exception ex)
        {
            TempData["Error"] = $"Error: {ex.Message}";
            return View(new GetUsers { data = new List<UserDTO>() });
        }
    }

    // GET: /User/EditUser/5
    [HttpGet]
    public async Task<IActionResult> EditUser(int id)
    {
        var response = await _client.GetAsync($"User/{id}");
        if (!response.IsSuccessStatusCode)
        {
            TempData["Error"] = "Could not load user data.";
            return RedirectToAction("ViewUser");
        }

        var content = await response.Content.ReadAsStringAsync();
        var user = JsonSerializer.Deserialize<UserDTO>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        return View(user);
    }

    // POST: /User/EditUser
    [HttpPost]
    public async Task<IActionResult> EditUser(UserDTO user)
    {
        var response = await _client.PutAsJsonAsync($"User/{user.userId}", user);
        if (response.IsSuccessStatusCode)
        {
            TempData["Success"] = "User updated successfully!";
            return RedirectToAction("ViewUser");
        }

        TempData["Error"] = "Update failed.";
        return View(user);
    }


    // GET: /User/DeleteUser/5
    public async Task<IActionResult> DeleteUser(int id)
    {
        var response = await _client.DeleteAsync($"User/{id}");
        if (response.IsSuccessStatusCode)
        {
            TempData["Success"] = "User deleted successfully!";
        }
        else
        {
            TempData["Error"] = "Delete failed.";
        }

        return RedirectToAction("ViewUser");
    }
}

