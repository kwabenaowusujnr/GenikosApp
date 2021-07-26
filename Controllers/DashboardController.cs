using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace GenikosApp.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reports()
        {
            return View();
        }
        public ActionResult UserManager()
        {
            return View();
        }
        
        public ActionResult SettingsPage()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult RangeSlider()
        {
            return View();
        }

        public ActionResult SessionTimeout()
        {
            return View();
        }
    }
}