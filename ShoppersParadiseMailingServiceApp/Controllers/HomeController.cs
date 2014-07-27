using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppersParadiseMailingServiceApp.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Services()
        {
            ViewBag.Message = "Your services page.";

            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Message = "Your blog page.";

            return View();
        }


        public ActionResult Subscribe()
        {
            ViewBag.Message = "Your subscription page.";

            return View();
        }
        public ActionResult UnSubscribe()
        {
            ViewBag.Message = "Your unsubscribe page.";

            return View();
        }
    }
}