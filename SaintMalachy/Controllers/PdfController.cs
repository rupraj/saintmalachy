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


        public void TwentyFourHours()
        {
            string filePath = Server.MapPath("~/Content/pdf/24_Burlington_SM.pdf");
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-disposition", "attachment; filename=24HrsForTheLord.pdf"); // open in a new window
            Response.WriteFile(filePath);
            //Response.OutputStream.Write()
            Response.Flush();
        }

        public void RelEdOneToSix()
        {
            string filePath = Server.MapPath("~/Content/pdf/2019-2020_RE_Schedule_1-6.pdf");
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-disposition", "attachment; filename=ReligiousEd-Schedule-Grade-1-6.pdf"); // open in a new window
            Response.WriteFile(filePath);
            //Response.OutputStream.Write()
            Response.Flush();
        }

        public void RelEdSevenToEight()
        {
            string filePath = Server.MapPath("~/Content/pdf/2019-2020_RE_Schedule_7-8.pdf");
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-disposition", "attachment; filename=ReligiousEd-Schedule-Grade-7-8.pdf"); // open in a new window
            Response.WriteFile(filePath);
            //Response.OutputStream.Write()
            Response.Flush();
        }

        public void OnlineGiving()
        {
            string filePath = Server.MapPath("~/Content/pdf/OnlineGiving.pdf");
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-disposition", "attachment; filename=OnlineGiving-Setup.pdf"); // open in a new window
            Response.WriteFile(filePath);
            //Response.OutputStream.Write()
            Response.Flush();
        }

        public void ParishMission()
        {
            string filePath = Server.MapPath("~/Content/pdf/Parish_Mission.pdf");
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AppendHeader("Content-disposition", "attachment; filename=Lenten_ParishMission.pdf"); // open in a new window
            Response.WriteFile(filePath);
            //Response.OutputStream.Write()
            Response.Flush();
        }

        public FileResult RelEdFlyer()
        {
            return File(Server.MapPath("~/Content/pdf/Fall_Activities_Flyer_2019-2020.pdf"), "application/pdf");
        }
    }
}