using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SaintMalachy.Models
{
    public class BulletinItemModel
    {
        public string bulletinTitle { get; set; }
        public string bulletinImage { get; set; }
        public string bulletinPdf { get; set; }
        public string bulletinImageUrl
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("BulletinUrl") + bulletinImage;
            }
        }
        public string bulletinPdfUrl
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("BulletinUrl") + bulletinPdf;
            }
        }
    }
}