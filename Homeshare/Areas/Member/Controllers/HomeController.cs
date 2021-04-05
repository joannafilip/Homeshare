using Homeshare.Infra;
using Homeshare.Models;
using Homeshare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homeshare.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        // GET: Member/Home
        public ActionResult Index()
        {
            return View(SessionUtils.ConnectedUser);
        }

        public ActionResult MyProperties(RegisterModel rm)
        {

            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

            rm = SessionUtils.ConnectedUser;
            return View(ctx.GetBiensMembre(rm));
        }
        [HttpGet]
        public ActionResult AddAProperty()
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            BienEchangeModel bem = new BienEchangeModel();
            bem.PaysListModel = ctx.SelectPays(); 
            return View(bem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddAProperty(BienEchangeModel bm)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            bm.IdMembre = SessionUtils.ConnectedUser.IdMembre;
            ctx.InsertBien(bm);

            return RedirectToAction("Index", "Home", new { area = "" });

        }
        //[HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }
    }
}