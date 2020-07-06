using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task5.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult List()
        {
            ViewBag.Message = "List of products";
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Product Details";
            return View();
        }
    }
}