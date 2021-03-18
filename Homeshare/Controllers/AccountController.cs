using Homeshare.Infra;
using Homeshare.Models;
using Homeshare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homeshare.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {

            RegisterViewModel rvm = new RegisterViewModel();
            return View(rvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel rm, PaysListModel pm)
        {
            if (ModelState.IsValid)
                
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (ctx.SaveSignUp(rm, pm))
                {
                    SessionUtils.IsLogged = true;
                    return RedirectToAction("Index", "Home", new { area = "Member" });
                }
                else
                {
                    ViewBag.ErrorMessage = "Try once again!";
                    return View();
                }
                 
            }
            else
                {
                    ViewBag.ErrorMessage = "Sign Up error";
                    RegisterViewModel rvm = new RegisterViewModel();
                    return View(rvm);
            }
                
           
        }
    }
}