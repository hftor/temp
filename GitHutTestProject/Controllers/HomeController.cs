﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHutTestProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var i = 29;
            string sja = "sja allir thetta";
            string branch = "ekki breita";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}