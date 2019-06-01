using SaintMalachy.Helpers;
using SaintMalachy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
{
    public class BaptismController : Controller
    {
        // GET: Baptism
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BaptismAtMalachy()
        {
            return View();
        }

        public ActionResult BaptismDates()
        {
            return View();
        }
        [HttpGet]
        public JsonResult SendEmail(BaptismRequestModel modelData)
        {
            //EmailHelper<BaptismRequestModel>.SendEmail(modelData);
               return Json(EmailHelper<BaptismRequestModel>.SendEmail(modelData), JsonRequestBehavior.AllowGet);
            //return View();
        }
    }
}