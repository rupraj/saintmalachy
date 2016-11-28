using HtmlAgilityPack;
using SaintMalachy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
{
    public class TopHeaderController : Controller
    {
        // GET: MassTimes
        public ActionResult MassTimes()
        {
            return View();
        }

        public ActionResult Bulletin()
        {
            BulletinModel model = new BulletinModel();
            model.Bulletins = new List<BulletinItemModel>();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument(); 
            using (WebClient client = new WebClient())
            {
                string html = client.DownloadString("http://www.thebostonpilot.com/bcd/web_bulletin.asp?ektronid=4460");
                doc.LoadHtml(html);
                var nodes = doc.DocumentNode.SelectNodes("//div[@class='entry-content']//div");
                foreach(HtmlNode node in nodes)
                {
                    string _bulletinName = node.ChildNodes["center"].InnerText.Trim();
                    string _bulletinImage = node.ChildNodes["a"].ChildNodes["img"].GetAttributeValue("src", "").Trim();
                    string _bulletinPdf= node.ChildNodes["a"].GetAttributeValue("href", "").Trim();
                    model.Bulletins.Add(new BulletinItemModel { bulletinTitle = _bulletinName, bulletinImage = _bulletinImage, bulletinPdf = _bulletinPdf });
                }
            }
                return View(model);
        }

        public ActionResult Direction()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}