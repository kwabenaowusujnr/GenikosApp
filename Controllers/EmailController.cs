using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace GenikosApp.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult Compose()
        {
            return View();
        }

        public ActionResult Inbox()
        {
            return View();
        }

        public ActionResult Read()
        {
            return View();
        }
    }
}