using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
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

        public ActionResult History()
        {
            return View();
        }

        public ActionResult Malachy()
        {
            return View();
        }

        public ActionResult Baptism()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View("_ComingSoon");
        }
    }
}