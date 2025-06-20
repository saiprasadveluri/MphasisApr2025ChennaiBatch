using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VisitorManagement.Data;
using VisitorManagement.DTO;

namespace VisitorManagement.Controllers
{
    [Authorize]
    public class HostManagerController : Controller
    {
        private VisitorManagementContext context;
        public HostManagerController(VisitorManagementContext _context)
        {
            context = _context;
        }
        [HttpGet]
        //[Authorize(Policy = "OnlyAdmin")]
        public IActionResult AddHost()
        {
            HostDTO model = new HostDTO();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddHost(HostDTO model)
        {
            HostInfo h = new HostInfo()
            {
                HostId = Guid.NewGuid(),
                HostName = model.HostName,
                Location = model.Location,


            };
            context.hostInfos.Add(h);
            context.SaveChanges();
            return View(model);
        }
        [HttpGet]
        public IActionResult HostView()
        {
            HostViewDTO model = new HostViewDTO();
            List<HostInfo> h = context.hostInfos.ToList();
            foreach (HostInfo host in h)
            {
                HostEntry hostE = new HostEntry()
                {
                    HostId=Guid.NewGuid(),
                    HostName=host.HostName,
                    Location=host.Location,
                };
                model.hosts.Add(hostE);
            }

            return View(model);
            return View();
        }
    }
}
