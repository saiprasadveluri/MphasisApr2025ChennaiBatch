using Book.DTO;
using Microsoft.AspNetCore.Mvc;
using Book.Services.Interfaces;


namespace Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _service;

        public CityController(ICityService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create(CityDTO dto)
            => Ok(await _service.CreateAsync(dto));
    }
}
