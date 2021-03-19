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

        public ActionResult MyProperties()
        {

            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

            //BienEchangeModel rm = new BienEchangeModel();
            //rm.IdMembre = SessionUtils.ConnectedUser.IdMembre;
            //RegisterModel rm = ctx.GetBiensMembre(IdMembre);
            return View(SessionUtils.ConnectedUser);
        }
        public ActionResult AddAProperty()
        {
            return View(new BienEchangeModel());
        }
    }
}