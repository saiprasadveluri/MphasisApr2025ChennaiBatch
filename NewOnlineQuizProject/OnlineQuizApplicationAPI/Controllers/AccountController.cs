using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizApplicationAPI.Services;

namespace OnlineQuizApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public ServicesAPI services;
        public AccountController(ServicesAPI srv)
        {
            services = srv;
        }
        [HttpGet]

        public IActionResult GetAllAccounts()
        {
            var accountsList = services.GetAllAcountDetails();
            return Ok(new { data = accountsList });
        }
    }
}
