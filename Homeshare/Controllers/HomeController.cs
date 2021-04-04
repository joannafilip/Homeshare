﻿using Homeshare.Infra;
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
        [HttpGet]
        public ActionResult Index()
        {
            HomeViewModel hm = new HomeViewModel();
            return View(hm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel lm)
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

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Agents()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Properties(int page = 1, string searchString = null)
        {
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