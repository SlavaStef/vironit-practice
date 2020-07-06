using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task5.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Add()
        {
            ViewBag.Message = "Add a new customer";
            return View();
        }
    }
}