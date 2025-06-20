using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VisitorManagement.Data;
using VisitorManagement.DTO;

namespace VisitorManagement.Controllers
{
    [Authorize]
    public class VisitorMangerController : Controller
    {
        private VisitorManagementContext context;
        public VisitorMangerController(VisitorManagementContext visit) {
            context = visit;
        }
        [HttpGet]
        //[Authorize(Policy = "OnlyHost")]
        public IActionResult AddVisitor()
        {
            VisitorDTO model = new VisitorDTO();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddVisitor(VisitorDTO model)
        {
            Visitor v = new Visitor()
            {
                VisitorId = Guid.NewGuid(),
                VisitorName = model.VisitorName,
                Location = model.Location,
                HostName = model.HostName,
                VisitDate = model.VisitDate,

            };
            context.Visitors.Add(v);
            context.SaveChanges();

            return View(model);
        }
        [HttpGet]
        public IActionResult VisitorView()
        {
            VistiorViewDTO model = new VistiorViewDTO();  
            List<Visitor> v = context.Visitors.ToList();
            foreach(Visitor visit in v )
            {
                VisitorEntry visitEntry = new VisitorEntry()
                {
                    VisitorId= visit.VisitorId,
                    VisitorName = visit.VisitorName,
                    Location = visit.Location,
                    HostName = visit.HostName,
                    VisitDate = visit.VisitDate,
                };
                model.visits.Add(visitEntry);
            }

            return View(model);
        }
    }
}
