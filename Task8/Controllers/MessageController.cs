using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task8.Models;

namespace Task8.Controllers
{
    public class MessageController : Controller
    {
        Message[] messages =
        {
            new Message { Id = 1, Type = Message.MessageType.Error, Description = "Some error occured", Date = DateTime.Now },
            new Message { Id = 2, Type = Message.MessageType.Info, Description = "This is an info message", Date = DateTime.Now },
            new Message { Id = 3, Type = Message.MessageType.Warning, Description = "Warning!!! Warning!!!", Date = DateTime.Now }
        };

        public ActionResult Index()
        {
            Random random = new Random();

            ViewBag.Message = "Это вызов частичного представления из обычного";
            return View("Message", messages[random.Next(0,2)]);
        }

        public ActionResult Partial()
        {
            ViewBag.Message = "Это частичное представление.";
            return PartialView();
        }
    }
}