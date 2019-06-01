using SaintMalachy.Helpers;
using SaintMalachy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
{
    public class ReligiousEdController : Controller
    {
        // GET: ReligiousEd
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult RCIA()
        {
            return View();
        }

        public ActionResult SummerProg()
        {
            return View();
        }

        public ActionResult Confirmation()
        {
            return View();
        }

        [HttpGet]
        public JsonResult SendEmail(ReligiousEdModel modelData)
        {
            //EmailHelper<BaptismRequestModel>.SendEmail(modelData);
            return Json(EmailHelper<ReligiousEdModel>.SendEmail(modelData), JsonRequestBehavior.AllowGet);
            //return View();
        }
    }
}