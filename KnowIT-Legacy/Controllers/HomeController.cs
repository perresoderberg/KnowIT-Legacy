using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace knowit_legacy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "peso - about page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "peso - contact page.";

            return View();
        }
    }
}