using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace GenikosApp.Controllers
{
    public class MapsController : Controller
    {
        public ActionResult Google()
        {
            return View();
        }

        public ActionResult Vector()
        {
            return View();
        }
    }
}