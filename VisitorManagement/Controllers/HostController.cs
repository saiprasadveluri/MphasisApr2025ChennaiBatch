using Microsoft.AspNetCore.Mvc;

namespace VisitorManagement.Controllers
{
    public class HostController : Controller
    {
        private readonly VisitorManagementDbContext _context;
        public HostController(VisitorManagementDbContext context)
        {
            _context = context;
        }
        public IActionResult AddHost()
        {
            ViewBag.Locations = _context.Locations.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddHost(Host host)
        {
            _context.Add(host);
            _context.SaveChanges();
            ViewBag.Locations = _context.Locations.ToList();
            return RedirectToAction("Host");
        }
        public IActionResult Host()
        {
            var hosts = _context.Hosts.ToList();
            return View(hosts);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
