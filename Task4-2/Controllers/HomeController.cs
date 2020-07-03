using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task4_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Page1()
        {
            ViewBag.Counter = Global.requestCounter;
            return View();
        }

        public ActionResult Page2()
        {
            ViewBag.Counter = Global.requestCounter;
            return View();
        }

        public ActionResult Page3()
        {
            ViewBag.Counter = Global.requestCounter;
            return View();
        }
    }
}