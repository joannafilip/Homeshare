using Homeshare.Infra;
using Homeshare.Models;
using Homeshare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homeshare.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        private string[] validImageType = { ".png", ".jpg", ".jpeg" };
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

        [HttpGet]
        public ActionResult EditPhoto()
        {
            return View(SessionUtils.ConnectedUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPhoto(RegisterModel rm, HttpPostedFileBase FilePhoto)
        {
            DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
            if (FilePhoto.ContentLength > 0 && FilePhoto.ContentLength < 20000)
            {
                string extension = Path.GetExtension(FilePhoto.FileName);
                if (validImageType.Contains(extension))
                {
                    string destFolder = Path.Combine(Server.MapPath("~/images/Users"), SessionUtils.ConnectedUser.IdMembre.ToString());
                    if (!Directory.Exists(destFolder))
                    {
                        Directory.CreateDirectory(destFolder);
                    }
                    FilePhoto.SaveAs(Path.Combine(destFolder, FilePhoto.FileName));
                    SessionUtils.ConnectedUser.Photo = FilePhoto.FileName;
                    ctx.EditMemberPhoto(SessionUtils.ConnectedUser);
                    return RedirectToAction("Index", "Home");
                }
            }


            return View(SessionUtils.ConnectedUser);
        }

        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }
    }
}