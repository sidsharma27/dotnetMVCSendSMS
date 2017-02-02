using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nexmo.Api;

namespace dotnetMVCSendSMSExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Send SMS
            var results = SMS.Send(new SMS.SMSRequest
            {
                from = "FROM_NUMBER",
                to = "TO_NUMBER",
                text = "Welcome to the Index Page."
            });
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