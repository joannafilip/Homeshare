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
                    ViewBag.ErrorMessage = "You can log in now!";
                    RegisterViewModel rvm = new RegisterViewModel();
                    return View(rvm);
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

        [HttpGet]
        public ActionResult Login()
        {

            HomeViewModel hvm = new HomeViewModel();
            return View(hvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel lm)
        {
           DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (ModelState.IsValid)
                {
                    RegisterModel rm = ctx.UserAuth(lm);
                    if (rm == null)
                    {
                        ViewBag.Error = "Erreur Login/Password";
                        return View();
                    }
                    else
                    {
                        SessionUtils.IsLogged = true;
                        SessionUtils.ConnectedUser = rm;
                        return RedirectToAction("Index", "Home", new { area = "Member" });
                    }
                }
                else
                {
                    return View();
                }
            }


       
    }
}