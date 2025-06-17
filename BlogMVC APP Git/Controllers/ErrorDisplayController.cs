using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWebMVCApp.Controllers
{
    public class ErrorDisplayController : Controller
    {
        // GET: ErrorDisplay
        public ActionResult Index()
        {
            return View();
        }
    }
}