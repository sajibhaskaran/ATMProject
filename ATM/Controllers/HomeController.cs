﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Having Trouble?, Send us a message..."; 

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = "Thanks we got your message"; 

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC6ATM1";

            if (letterCase == "lower")
            {
                return Content(serial.ToLower());

            }
            return Content(serial);
        }
    }
}