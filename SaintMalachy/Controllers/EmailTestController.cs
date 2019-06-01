using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
{
    public class EmailTestController : Controller
    {
        // GET: EmailTest
        public ActionResult Index()
        {
            try
            {
                MailMessage mm = new MailMessage("rupesh.rajagopalan@gmail.com", "office@saint-malachy.org", "test email", "TEsting");
                SmtpClient client = new SmtpClient();
                client.Port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("EmailPort"));
                client.Host = ConfigurationManager.AppSettings.Get("EmailHost");
                client.EnableSsl = false;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings.Get("EmailUsername"), ConfigurationManager.AppSettings.Get("EmailPassword"));
                mm.IsBodyHtml = true;
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);
                //return GlobalConstants.emailSuccess;
            }
            catch (Exception ex)
            {
                var test = ex;
                //return GlobalConstants.emailFailure;
            }
            return View();
        }
    }
}