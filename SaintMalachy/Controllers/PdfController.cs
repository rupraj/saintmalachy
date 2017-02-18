using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
{
    public class PdfController : Controller
    {
        // GET: Pdf
        public void Index()
        {
            string filePath = Server.MapPath("~/Content/pdf/Race for Grace Flyer.pdf");
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-disposition", "attachment; filename=Race for Grace Flyer.pdf"); // open in a new window
            Response.WriteFile(filePath);
            //Response.OutputStream.Write()
            Response.Flush();
        }
    }
}