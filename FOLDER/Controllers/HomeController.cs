using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class HomeController : Controller
{
    // GET: /Home/Welcome
    public IActionResult Welcome()
    {
        // Check if user is already logged in
        if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
        {
            // Redirect to Movies page if session exists
            return RedirectToAction("Welcome" , "Home");
          
        }

        // Otherwise, show the Welcome page
        return View();
    }

    // Optional: fallback Index action
    public IActionResult Index()
    {
        return RedirectToAction("Welcome");
       
    }
}