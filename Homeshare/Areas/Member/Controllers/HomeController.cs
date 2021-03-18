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
            ctx.GetBiensMembre(SessionUtils.ConnectedUser);
            return View(SessionUtils.ConnectedUser);
        }
    }
}