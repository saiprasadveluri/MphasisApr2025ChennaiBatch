using BlogWebMVCApp.Data;
using BlogWebMVCApp.Infra;
using BlogWebMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWebMVCApp.Controllers
{
    [Authorize]
    public class BlogPostController : Controller
    {
        // GET: BlogPost
        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        [MyAuth("OWNER")]
        public ActionResult AddBlogPost()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            CustomerModel model = new CustomerModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddCustomer(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                //DB Update...
                return RedirectToAction("ViewAll");
                ViewBag.Msg = "Success Adding data";
            }
            else
            {
                ViewBag.Msg = "Error In Data";
            }
            return View(model);
        }
    }
}