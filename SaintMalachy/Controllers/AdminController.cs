using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SaintMalachy;
using SaintMalachy.Models;

namespace SaintMalachy.Controllers
{
    public class AdminController : Controller
    {
        private stmalachy db = new stmalachy();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.BaptismRequest.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BaptismRequestModel baptismRequestModel = db.BaptismRequest.Find(id);
            if (baptismRequestModel == null)
            {
                return HttpNotFound();
            }
            return View(baptismRequestModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
