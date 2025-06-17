using BlogWebMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogWebMVCApp;
using System.Web.Security;
using System.Security.Cryptography;
namespace BlogWebMVCApp.Controllers
{
    [Route("Account/{action}")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        //[ActionName("Signin")]
        public ActionResult LoginUser()
        {
            return View();
        }
        [HttpPost]
        [HandleError]
        public ActionResult LoginUser(string uemail,string upassword)
        {
            long userId = 0;            
            using (DatabaseAccess databaseAccess = new DatabaseAccess())
            {
                (long uid,string UserRole) res= databaseAccess.ValidateUser(uemail, upassword);
                if (res.uid != 0)
                {
                    FormsAuthentication.SetAuthCookie(uemail, false);
                    Session["Email"] = uemail;
                    Session["UserRole"] = res.UserRole;
                    return RedirectToAction("ViewAll", "BlogPost");
                }
                else
                {
                    ViewBag.Msg = "Error In login";
                    return View();
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult ViewUsers()
        {
            List<NewUserModel> users = new List<NewUserModel>();
            using(DatabaseAccess dbAccess= new DatabaseAccess())
            {
                users = dbAccess.GetAllUsers();
            }
            return View(users);
        }
        [HttpGet]
        [HandleError]
        public ActionResult AddUser()
        {
            NewUserModel model= new NewUserModel();
            
            model.AvailableUserRoles = GetAvailableRoles();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddUser(NewUserModel inp) 
        {
            if (ModelState.IsValid)
            {
                using(DatabaseAccess dbAccess = new DatabaseAccess())
                {
                   bool Success= dbAccess.AddUser(inp.Email, inp.Password, inp.UserRole);
                    if (Success)
                    {
                        ViewBag.Msg = "Success in Adding User";
                        return RedirectToAction("ViewUsers");
                    }
                    else
                    {
                        ViewBag.Msg = "DB Error... in Adding User";
                    }
                }
            }
            else
            {
                ViewBag.Msg = "Input data Error";
            }
            inp.AvailableUserRoles= GetAvailableRoles();
            return View(inp);
        }

        public ActionResult DeleteUser(long Id)
        {
            using (DatabaseAccess dbAccess = new DatabaseAccess())
            {
                bool Result = dbAccess.DeleteUser(Id);                
            }
            return RedirectToAction("ViewUsers");               
        }

        private List<SelectListItem> GetAvailableRoles()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem(){Text="USER",Value="USER"},
                new SelectListItem(){Text="OWNER",Value="OWNER"},
            };

        }
    }
}