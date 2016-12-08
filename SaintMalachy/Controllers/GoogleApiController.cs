using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using SaintMalachy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SaintMalachy.Controllers
{
    public class GoogleApiController : Controller
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        // GET: GoogleApi
        public ActionResult Index()
        {

            try { 
            UserCredential credential;
            using (var stream =
                new FileStream(Server.MapPath("~\\SpreadSheet\\client_secret_saintmalachy.json"), FileMode.Open, FileAccess.Read))
            {
                string credPath = Server.MapPath("~\\SpreadSheet\\");

                credPath = Path.Combine(credPath, ".credentials\\stmalachyspreadsheet.json");
                Response.Write("Certificate write begins");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Response.Write(credPath+" -- Certificate write ends");
                //Console.WriteLine("Credential file saved to: " + credPath);
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                //// Define request parameters.
                //String spreadsheetId = "1jziYTFiuQjM_5XqvaxdIyoB06A-e76Au8phFxm-uYYs";
                //    String range = "Form Responses 1!A1:CQ";
                //    ValueRange valrange = new ValueRange();
                //valrange.Range = range;
                //valrange.MajorDimension = "ROWS";
                //    stmalachy malachyContext = new stmalachy();
                //    //BaptismRequestModel brm = malachyContext.BaptismRequest.Select(bp => bp).OrderBy(bp=>bp.CreatedOn).FirstOrDefault();
                //    List<ReligiousEdModel> model = malachyContext.ReligiousEd.Select(re => re).ToList();
                //    List<object> datalist = new List<object>();
                //    foreach (ReligiousEdModel brm in model)
                //    {

                //        var mylist = new List<object>() { DateTime.Now.ToString(), string.Empty, string.Empty, string.Empty, string.Empty, brm.TodayDate,
                //            brm.FamilyName, brm.Address, brm.City, brm.State, brm.ZipCode, brm.Phone, brm.FamilyEmail, brm.FatherFirstName, brm.FatherLastName, brm.FatherEmail,
                //            brm.MotherFirstName, brm.MotherLastName, brm.MotherMaiden, brm.MotherEmail, brm.WantToHelp,brm.HelpInterest,brm.Child1FirstName,brm.Child1MiddleInitial,
                //        brm.Child1LastName,brm.Child1Grade,brm.Child1DOB,brm.Child1Email,brm.Child1BaptismPlace,brm.Child1BaptismDate,brm.Child1EucharistPlace,brm.Child1EucharistDate,
                //        brm.sacrecords1,brm.reledchoice1,
                //        brm.Child2FirstName,brm.Child2MiddleInitial,
                //        brm.Child2LastName,brm.Child2Grade,brm.Child2DOB,brm.Child2Email,brm.Child2BaptismPlace,brm.Child2BaptismDate,brm.Child2EucharistPlace,brm.Child2EucharistDate,
                //        brm.sacrecords2,brm.reledchoice2,
                //        brm.Child3FirstName,brm.Child3MiddleInitial,
                //        brm.Child3LastName,brm.Child3Grade,brm.Child3DOB,brm.Child3Email,brm.Child3BaptismPlace,brm.Child3BaptismDate,brm.Child3EucharistPlace,brm.Child3EucharistDate,
                //        brm.sacrecords3,brm.reledchoice3,
                //        brm.Child4FirstName,brm.Child4MiddleInitial,
                //        brm.Child4LastName,brm.Child4Grade,brm.Child4DOB,brm.Child4Email,brm.Child4BaptismPlace,brm.Child4BaptismDate,brm.Child4EucharistPlace,brm.Child4EucharistDate,
                //        brm.sacrecords4,brm.reledchoice4,
                //        brm.Child5FirstName,brm.Child5MiddleInitial,
                //        brm.Child5LastName,brm.Child5Grade,brm.Child5DOB,brm.Child5Email,brm.Child5BaptismPlace,brm.Child5BaptismDate,brm.Child5EucharistPlace,brm.Child5EucharistDate,
                //        brm.sacrecords5,brm.reledchoice5,
                //        brm.Child6FirstName,brm.Child6MiddleInitial,
                //        brm.Child6LastName,brm.Child6Grade,brm.Child6DOB,brm.Child6Email,brm.Child6BaptismPlace,brm.Child6BaptismDate,brm.Child6EucharistPlace,brm.Child6EucharistDate,
                //        brm.sacrecords6,brm.reledchoice6,brm.amtdue};
                //        valrange.Values = new List<IList<object>> { mylist };
                //        SpreadsheetsResource.ValuesResource.AppendRequest request =
                //           service.Spreadsheets.Values.Append(valrange, spreadsheetId, range);

                //        request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
                //        AppendValuesResponse response = request.Execute();
                //    }




                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            return View();
        }
    }
}