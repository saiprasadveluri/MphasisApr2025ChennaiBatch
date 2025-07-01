using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineQuizWebAPI.ServiceAPI;
using static OnlineQuizWebAPI.ServiceAPI.ServiceApi;

namespace OnlineQuizWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public ServiceApi services;
        public AccountController(ServiceApi srv)
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

