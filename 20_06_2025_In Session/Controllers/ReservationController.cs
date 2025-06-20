using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoomManagerMVCApp.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        [HttpGet]
        public IActionResult ReserveRoom()
        {
            return View();
        }
    }
}
