
using SaintMalachy.Helpers;
using SaintMalachy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
{
    public class MiscController : Controller
    {
        // GET: Misc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RaceForGrace()
        {
            return View();
        }

        [HttpGet]
        public JsonResult SendRaceForGraceEmail(RaceForGrace modelData)
        {
            //EmailHelper<BaptismRequestModel>.SendEmail(modelData);
            return Json(EmailHelper<RaceForGrace>.SendEmail(modelData), JsonRequestBehavior.AllowGet);
            //return View();
        }
    }
}