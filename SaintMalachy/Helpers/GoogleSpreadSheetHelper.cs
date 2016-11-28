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
using System.Web.Hosting;

namespace SaintMalachy.Helpers
{
    public class GoogleSpreadSheetHelper
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "StMalachySpreadSheet";
        public static void InsertSpreadSheet<T> (T Data)
        {
            switch (Data.GetType().Name)
            {
                case "BaptismRequestModel":
                    InsertBaptismRecord(Data as BaptismRequestModel);
                    break;
                case "ReligiousEdModel":
                    InsertReligiousEdRecord(Data as ReligiousEdModel);
                    break;
                default:
                    break;
            }
            
        }

        private static void InsertReligiousEdRecord(ReligiousEdModel model)
        {
            try {
                
                    UserCredential credential;
                    using (var stream =
                        new FileStream(HostingEnvironment.MapPath("~\\SpreadSheet\\client_secret_saintmalachy.json"), FileMode.Open, FileAccess.Read))
                    {
                        string credPath = HostingEnvironment.MapPath("~\\SpreadSheet");

                        credPath = Path.Combine(credPath, ".credentials\\stmalachyspreadsheet.json");

                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            GoogleClientSecrets.Load(stream).Secrets,
                            Scopes,
                            "user",
                            CancellationToken.None,
                            new FileDataStore(credPath, true)).Result;
                        var service = new SheetsService(new BaseClientService.Initializer()
                        {
                            HttpClientInitializer = credential,
                            ApplicationName = ApplicationName,
                        });

                        //// Define request parameters.
                        String spreadsheetId = "1jziYTFiuQjM_5XqvaxdIyoB06A-e76Au8phFxm-uYYs";
                        String range = "Form Responses 1!A1:CQ";
                        ValueRange valrange = new ValueRange();
                        valrange.Range = range;
                        valrange.MajorDimension = "ROWS";

                        List<object> datalist = new List<object>();
                    var mylist = new List<object>() { model.CreatedOn, string.Empty, string.Empty, string.Empty, string.Empty, model.TodayDate,
                            model.FamilyName, model.Address, model.City, model.State, model.ZipCode, model.Phone, model.FamilyEmail, model.FatherFirstName, model.FatherLastName, model.FatherEmail,
                            model.MotherFirstName, model.MotherLastName, model.MotherMaiden, model.MotherEmail, model.WantToHelp,model.HelpInterest,model.Child1FirstName,model.Child1MiddleInitial,
                        model.Child1LastName,model.Child1Grade,model.Child1DOB,model.Child1Email,model.Child1BaptismPlace,model.Child1BaptismDate,model.Child1EucharistPlace,model.Child1EucharistDate,
                        model.sacrecords1,model.reledchoice1,
                        model.Child2FirstName,model.Child2MiddleInitial,
                        model.Child2LastName,model.Child2Grade,model.Child2DOB,model.Child2Email,model.Child2BaptismPlace,model.Child2BaptismDate,model.Child2EucharistPlace,model.Child2EucharistDate,
                        model.sacrecords2,model.reledchoice2,
                        model.Child3FirstName,model.Child3MiddleInitial,
                        model.Child3LastName,model.Child3Grade,model.Child3DOB,model.Child3Email,model.Child3BaptismPlace,model.Child3BaptismDate,model.Child3EucharistPlace,model.Child3EucharistDate,
                        model.sacrecords3,model.reledchoice3,
                        model.Child4FirstName,model.Child4MiddleInitial,
                        model.Child4LastName,model.Child4Grade,model.Child4DOB,model.Child4Email,model.Child4BaptismPlace,model.Child4BaptismDate,model.Child4EucharistPlace,model.Child4EucharistDate,
                        model.sacrecords4,model.reledchoice4,
                        model.Child5FirstName,model.Child5MiddleInitial,
                        model.Child5LastName,model.Child5Grade,model.Child5DOB,model.Child5Email,model.Child5BaptismPlace,model.Child5BaptismDate,model.Child5EucharistPlace,model.Child5EucharistDate,
                        model.sacrecords5,model.reledchoice5,
                        model.Child6FirstName,model.Child6MiddleInitial,
                        model.Child6LastName,model.Child6Grade,model.Child6DOB,model.Child6Email,model.Child6BaptismPlace,model.Child6BaptismDate,model.Child6EucharistPlace,model.Child6EucharistDate,
                        model.sacrecords6,model.reledchoice6,model.amtdue };
                    valrange.Values = new List<IList<object>> { mylist };
                    SpreadsheetsResource.ValuesResource.AppendRequest request =
                        service.Spreadsheets.Values.Append(valrange, spreadsheetId, range);
                    request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
                    AppendValuesResponse response = request.Execute();

                }
            }
            catch (Exception ex) {
                stmalachy malachyContext = new stmalachy();
                malachyContext.ErrorLogged.Add(new ErrorLog { createdon = DateTime.Now, model = Newtonsoft.Json.JsonConvert.SerializeObject(model), modulename = "GoogleSpreadSheetHelper - Religious Ed", stackTrace = ex.StackTrace });
                malachyContext.SaveChanges();
            }
        }

        private static void InsertBaptismRecord(BaptismRequestModel model)
        {
            try
            {
                UserCredential credential;
                using (var stream =
                    new FileStream(HostingEnvironment.MapPath("~\\SpreadSheet\\client_secret_saintmalachy.json"), FileMode.Open, FileAccess.Read))
                {
                    string credPath = HostingEnvironment.MapPath("~\\SpreadSheet");

                    credPath = Path.Combine(credPath, ".credentials\\stmalachyspreadsheet.json");

                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    var service = new SheetsService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = ApplicationName,
                    });

                    //// Define request parameters.
                    String spreadsheetId = "1NYVadZeOzD6Lf4MQ_aSxtiUhOT93cQcvkjtkJJCuc0o";
                    String range = "New Form Responses!A1:U";
                    ValueRange valrange = new ValueRange();
                    valrange.Range = range;
                    valrange.MajorDimension = "ROWS";
                                       
                    List<object> datalist = new List<object>();
                    var mylist = new List<object>() { model.CreatedOn, model.ChildLastName, model.ChildName, model.ChildDateOfBirth, model.ChildPlaceOfBirth, model.FatherFullName, model.MotherFirstName, model.MotherMaidenName, model.Address, model.CityState, model.Phone, model.Email, model.GodfatherName, model.GodfatherReligion, model.GodfatherConfirmed, model.GodmotherName, model.GodmotherReligion, model.GodmotherConfirmed, model.CommentsQuestions, model.BaptismDate, model.DinnerDate };
                    valrange.Values = new List<IList<object>> { mylist };
                    SpreadsheetsResource.ValuesResource.AppendRequest request =
                        service.Spreadsheets.Values.Append(valrange, spreadsheetId, range);
                    request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
                    AppendValuesResponse response = request.Execute();
                    
                }
            }
            catch (Exception ex)
            {
                stmalachy malachyContext = new stmalachy();
                malachyContext.ErrorLogged.Add(new ErrorLog { createdon = DateTime.Now, model = Newtonsoft.Json.JsonConvert.SerializeObject(model), modulename = "GoogleSpreadSheetHelper - Baptism", stackTrace = ex.StackTrace });
                malachyContext.SaveChanges();
            }
        }
    }
}