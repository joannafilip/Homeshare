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
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Index = "active";
            HomeViewModel hm = new HomeViewModel();
            return View(hm);
        }

        public ActionResult About()
        {
            ViewBag.About = "active";
            return View();
        }
        public ActionResult Agents()
        {
            ViewBag.Agents = "active";
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Blog= "active";
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Contact = "active";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

                if (ctx.SaveContact(contact))
                {
                    ViewBag.SuccessMessage = "Message a été bien envoyé";
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Message n'a pas été envoyé";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Form error";
                return View();
            }
        }
        public ActionResult Properties(int page = 1, string searchString = null)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            //ViewBag.DateSort = String.IsNullOrEmpty(sortOrder) ? "date_asc" : "date_desc";
            //ViewBag.NameSort = sortOrder == "name_asc" ? "" : "name_asc";
            HomeViewModel hvm = new HomeViewModel();
            hvm.PaginateProperty(page, searchString);
            return View(hvm);
        }
        public ActionResult Property(int id)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            ViewBag.IndexBien = id;
            HomeViewModel hvm = new HomeViewModel();
            hvm.TargetBien = ctx.GetOneBienByPage(id);
            return View(hvm);
        }
    }
}