using SaintMalachy.Helpers;
using SaintMalachy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
{
    public class FuneralController : Controller
    {
        // GET: Funeral
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OnlineForm()
        {
            return View("FuneralRequestForm");
        }

        public ActionResult FuneralHomeInfo()
        {
            return View();
        }

        public ActionResult FuneralReadings()
        {
            return View();
        }

        [HttpGet]
        public JsonResult SendRequestEmail(FuneralRequestModel modelData)
        {
            //EmailHelper<BaptismRequestModel>.SendEmail(modelData);
            return Json(EmailHelper<FuneralRequestModel>.SendEmail(modelData), JsonRequestBehavior.AllowGet);
            //return View();
        }

        [HttpGet]
        public JsonResult SendFuneralHomeInfoEmail(FuneralHomeInfoModel modelData)
        {
            //EmailHelper<BaptismRequestModel>.SendEmail(modelData);
            return Json(EmailHelper<FuneralHomeInfoModel>.SendEmail(modelData), JsonRequestBehavior.AllowGet);
            //return View();
        }

    }
}