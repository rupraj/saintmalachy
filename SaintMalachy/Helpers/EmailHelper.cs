using SaintMalachy.Models;
using SaintMalachy.Resources.EmailTemplates;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
 
namespace SaintMalachy.Helpers
{
    public static class EmailHelper<T>
    {
        public static string SendEmail(T data)
        {
            stmalachy malachyContext = new stmalachy();
            try {
                if (malachyContext.Database.Connection.State == System.Data.ConnectionState.Closed)
                {
                    malachyContext.Database.Connection.Open();
                }
                string emailType = data.GetType().Name;
                switch (emailType)
                {
                    case "RaceForGrace":
                        try
                        {
                            malachyContext.RaceForGrace.Add(data as RaceForGrace);
                            malachyContext.SaveChanges();
                            GoogleSpreadSheetHelper.InsertSpreadSheet<RaceForGrace>(data as RaceForGrace);
                            return GlobalConstants.registSuccess;
                        }
                        catch (Exception ex)
                        {
                            return GlobalConstants.registFailure;
                        }


                        break;
                    case "BaptismRequestModel":
                        malachyContext.BaptismRequest.Add(data as BaptismRequestModel);
                        malachyContext.SaveChanges();
                        GoogleSpreadSheetHelper.InsertSpreadSheet<BaptismRequestModel>(data as BaptismRequestModel);
                        return SendEmail(ProcessBaptismEmailBody(data as BaptismRequestModel), GlobalConstants.baptismEmailSubject, GlobalConstants.reledemailaddress);
                    case "FuneralRequestModel":
                        malachyContext.FuneralRequest.Add(data as FuneralRequestModel);
                        malachyContext.SaveChanges();
                        return SendEmail(ProcessFuneralRequestEmailBody(data as FuneralRequestModel), GlobalConstants.funeralEmailSubject, GlobalConstants.funeralemailaddress);
                    case "FuneralHomeInfoModel":
                        malachyContext.FuneralHomeInfo.Add(data as FuneralHomeInfoModel);
                        malachyContext.SaveChanges();
                        return SendEmail(ProcessFuneralHomeInfoEmailBody(data as FuneralHomeInfoModel), GlobalConstants.funeralHomeInfoSubject, GlobalConstants.funeralemailaddress);
                    case "ReligiousEdModel":
                        ReligiousEdModel model = data as ReligiousEdModel;
                        model.sacrecords1 = GetSacramentRecords(model.sacrecords1);
                        model.reledchoice1 = GetRelEdChoice(model.reledchoice1);
                        model.sacrecords2 = GetSacramentRecords(model.sacrecords2);
                        model.reledchoice2 = GetRelEdChoice(model.reledchoice2);
                        model.sacrecords3 = GetSacramentRecords(model.sacrecords3);
                        model.reledchoice3 = GetRelEdChoice(model.reledchoice3);
                        model.sacrecords4 = GetSacramentRecords(model.sacrecords4);
                        model.reledchoice4 = GetRelEdChoice(model.reledchoice4);
                        model.sacrecords5 = GetSacramentRecords(model.sacrecords5);
                        model.reledchoice5 = GetRelEdChoice(model.reledchoice5);
                        model.sacrecords6 = GetSacramentRecords(model.sacrecords6);
                        model.reledchoice6 = GetRelEdChoice(model.reledchoice6);
                        malachyContext.ReligiousEd.Add(model);
                        malachyContext.SaveChanges();
                        GoogleSpreadSheetHelper.InsertSpreadSheet<ReligiousEdModel>(model);
                        return SendEmail(ProcessReligiousEdEmailBody(model), GlobalConstants.religiousEdSubject, GlobalConstants.reledemailaddress);
                    default:
                        return string.Empty;

                }
            }
            catch(Exception ex)
            {
                var test = ex;
                return string.Empty;
            }
            finally
            {
                if (malachyContext.Database.Connection.State == System.Data.ConnectionState.Open)
                {
                    malachyContext.Database.Connection.Close();
                }
            }
            
        }

        private static string SendEmail(string data,string subject, string toaddress)
        {
            
            try
            {
                MailMessage mm = new MailMessage("webmaster@saint-malachy.org", toaddress, subject, data);
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
                return GlobalConstants.emailSuccess;
            }
            catch(Exception ex)
            {
                var test = ex;
                return GlobalConstants.emailFailure;
            }
            
            
        }

        private static string SendEmail(string data, string subject, string[] toaddress)
        {

            try
            {
                //MailMessage mm = new MailMessage("webmaster@saint-malachy.org", toaddress, subject, data);
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress(GlobalConstants.webmasteremailaddress);
                foreach(string addr in toaddress)
                {
                    mm.To.Add(addr);
                }
                mm.Subject = subject;
                mm.Body = data;
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
                return GlobalConstants.emailSuccess;
            }
            catch (Exception ex)
            {
                var test = ex;
                return GlobalConstants.emailFailure;
            }


        }

        private static string ProcessBaptismEmailBody(BaptismRequestModel data)
        {
            string htmlBody = EmailResources.BaptismOnlineForm;
            htmlBody = htmlBody.Replace("[[BaptismDate]]", data.BaptismDate);
            htmlBody = htmlBody.Replace("[[DinnerDate]]", data.DinnerDate);
            htmlBody = htmlBody.Replace("[[ChildLastName]]", data.ChildLastName);
            htmlBody = htmlBody.Replace("[[ChildName]]", data.ChildName);
            htmlBody = htmlBody.Replace("[[ChildDOB]]", data.ChildDateOfBirth);
            htmlBody = htmlBody.Replace("[[ChildPlaceOfBirth]]", data.ChildPlaceOfBirth);
            htmlBody = htmlBody.Replace("[[FatherFullName]]", data.FatherFullName);
            htmlBody = htmlBody.Replace("[[MotherFirstName]]", data.MotherFirstName);
            htmlBody = htmlBody.Replace("[[MotherMaidenName]]", data.MotherMaidenName);
            htmlBody = htmlBody.Replace("[[ParentsMarried]]", data.ParentsMarried);
            htmlBody = htmlBody.Replace("[[ChurchMarriage]]", data.ChurchMarriage);
            htmlBody = htmlBody.Replace("[[ParentsConfirmed]]", data.ParentsConfirmed);
            htmlBody = htmlBody.Replace("[[Address]]", data.Address);
            htmlBody = htmlBody.Replace("[[CityState]]", data.CityState);
            htmlBody = htmlBody.Replace("[[Phone]]", data.Phone);
            htmlBody = htmlBody.Replace("[[Email]]", data.Email);
            htmlBody = htmlBody.Replace("[[GodfatherName]]", data.GodfatherName);
            htmlBody = htmlBody.Replace("[[GodfatherReligion]]", data.GodfatherReligion);
            htmlBody = htmlBody.Replace("[[GodfatherConfirmed]]", data.GodfatherConfirmed);
            htmlBody = htmlBody.Replace("[[GodmotherName]]", data.GodmotherName);
            htmlBody = htmlBody.Replace("[[GodmotherReligion]]", data.GodmotherReligion);
            htmlBody = htmlBody.Replace("[[GodmotherConfirmed]]", data.GodmotherConfirmed);
            htmlBody = htmlBody.Replace("[[CommentsQuestions]]", data.CommentsQuestions);
            return htmlBody;
        }

        private static string ProcessFuneralRequestEmailBody(FuneralRequestModel data)
        {
            string htmlBody = EmailResources.FuneralRequestForm;
            htmlBody = htmlBody.Replace("[[NameOfDeceased]]", data.NameOfDeceased);
            htmlBody = htmlBody.Replace("[[Address]]", data.Address);
            htmlBody = htmlBody.Replace("[[Age]]", data.Age.ToString());
            htmlBody = htmlBody.Replace("[[DateOfBirth]]", data.DateOfBirth);
            htmlBody = htmlBody.Replace("[[DateOfDeath]]", data.DateOfDeath);
            htmlBody = htmlBody.Replace("[[KinRelationship]]", data.KinRelationship);
            htmlBody = htmlBody.Replace("[[KinAddress]]", data.KinAddress);
            htmlBody = htmlBody.Replace("[[KinPhoneNumber]]", data.KinPhoneNumber);
            htmlBody = htmlBody.Replace("[[FuneralHome]]", data.FuneralHome);
            htmlBody = htmlBody.Replace("[[FuneralHomeAddress]]", data.FuneralHomeAddress);
            htmlBody = htmlBody.Replace("[[FuneralHomeUrl]]", data.FuneralHomeUrl);
            htmlBody = htmlBody.Replace("[[DateOfFuneral]]", data.DateOfFuneral);
            htmlBody = htmlBody.Replace("[[TimeOfFuneral]]", data.TimeOfFuneral);
            htmlBody = htmlBody.Replace("[[DateOfWake]]", data.DateOfWake);
            htmlBody = htmlBody.Replace("[[TimeOfWake]]", data.TimeOfWake);
            htmlBody = htmlBody.Replace("[[Cemetry]]", data.Cemetry);
            htmlBody = htmlBody.Replace("[[Comments]]", data.Comments);
            return htmlBody;
        }

        private static string ProcessFuneralHomeInfoEmailBody(FuneralHomeInfoModel data)
        {
            string htmlBody = EmailResources.FuneralHomeInfo;
            htmlBody = htmlBody.Replace("[[NameOfDeceased]]", data.NameOfDeceased);
            htmlBody = htmlBody.Replace("[[DateOfBirth]]", data.DateOfBirth);
            htmlBody = htmlBody.Replace("[[DateOfDeath]]", data.DateOfDeath);
            htmlBody = htmlBody.Replace("[[FuneralHome]]", data.FuneralHome);
            htmlBody = htmlBody.Replace("[[DateOfFuneral]]", data.DateOfFuneral);
            htmlBody = htmlBody.Replace("[[TimeOfFuneral]]", data.TimeOfFuneral);
            htmlBody = htmlBody.Replace("[[DateOfWake]]", data.DateOfWake);
            htmlBody = htmlBody.Replace("[[TimeOfWake]]", data.TimeOfWake);
            htmlBody = htmlBody.Replace("[[ProcessionalSong]]", data.ProcessionalSong);
            htmlBody = htmlBody.Replace("[[ResponsorialPsalm]]", data.ResponsorialPsalm);
            htmlBody = htmlBody.Replace("[[OffertorySong]]", data.OffertorySong);
            htmlBody = htmlBody.Replace("[[CommunionSong]]", data.CommunionSong);
            htmlBody = htmlBody.Replace("[[RecessionalSong]]", data.RecessionalSong);
            htmlBody = htmlBody.Replace("[[OtherHymns]]", data.OtherHymns);
            htmlBody = htmlBody.Replace("[[ReaderOneReading]]", data.ReaderOneReading);
            htmlBody = htmlBody.Replace("[[ReaderTwoReading]]", data.ReaderTwoReading);
            htmlBody = htmlBody.Replace("[[PresentationOfGifts]]", data.PresentationOfGifts);
            htmlBody = htmlBody.Replace("[[Eulogy]]", data.Eulogy);
            htmlBody = htmlBody.Replace("[[Comments]]", data.Comments);
            return htmlBody;
        }

        private static string ProcessReligiousEdEmailBody(ReligiousEdModel data)
        {
            string htmlBody = EmailResources.ReligiousEdForm;
            htmlBody = htmlBody.Replace("[[TodayDate]]", data.TodayDate);
            htmlBody = htmlBody.Replace("[[FamilyName]]", data.FamilyName);
            htmlBody = htmlBody.Replace("[[Address]]", data.Address);
            htmlBody = htmlBody.Replace("[[City]]", data.City);
            htmlBody = htmlBody.Replace("[[State]]", data.State);
            htmlBody = htmlBody.Replace("[[ZipCode]]", data.ZipCode);
            htmlBody = htmlBody.Replace("[[Phone]]", data.Phone);
            htmlBody = htmlBody.Replace("[[FamilyEmail]]", data.FamilyEmail);
            htmlBody = htmlBody.Replace("[[FatherFirstName]]", data.FatherFirstName);
            htmlBody = htmlBody.Replace("[[FatherLastName]]", data.FatherLastName);
            htmlBody = htmlBody.Replace("[[FatherEmail]]", data.FatherEmail);
            htmlBody = htmlBody.Replace("[[MotherFirstName]]", data.MotherFirstName);
            htmlBody = htmlBody.Replace("[[MotherLastName]]", data.MotherLastName);
            htmlBody = htmlBody.Replace("[[MotherMaiden]]", data.MotherMaiden);
            htmlBody = htmlBody.Replace("[[MotherEmail]]", data.MotherEmail);
            htmlBody = htmlBody.Replace("[[Teaching]]", (data.HelpTeaching) ? "Yes" : "No");
            htmlBody = htmlBody.Replace("[[Helping]]", (data.HelpHelping) ? "Yes" : "No");
            htmlBody = htmlBody.Replace("[[KidHelping]]", (data.HelpKidhelping) ? "Yes" : "No");
            htmlBody = htmlBody.Replace("[[HelpInterest]]", data.HelpInterest);
            htmlBody = htmlBody.Replace("[[Child1FirstName]]", data.Child1FirstName);
            htmlBody = htmlBody.Replace("[[Child1MiddleInitial]]", data.Child1MiddleInitial);
            htmlBody = htmlBody.Replace("[[Child1LastName]]", data.Child1LastName);
            htmlBody = htmlBody.Replace("[[Child1Grade]]", data.Child1Grade);
            htmlBody = htmlBody.Replace("[[Child1DOB]]", data.Child1DOB);
            htmlBody = htmlBody.Replace("[[Child1Email]]", data.Child1Email);
            htmlBody = htmlBody.Replace("[[Child1BaptismPlace]]", data.Child1BaptismPlace);
            htmlBody = htmlBody.Replace("[[Child1BaptismDate]]", data.Child1BaptismDate);
            htmlBody = htmlBody.Replace("[[Child1EucharistPlace]]", data.Child1EucharistPlace);
            htmlBody = htmlBody.Replace("[[Child1EucharistDate]]", data.Child1EucharistDate);
            htmlBody = htmlBody.Replace("[[sacrecords1]]", data.sacrecords1);
            htmlBody = htmlBody.Replace("[[reledchoice1]]", data.reledchoice1);

            htmlBody = htmlBody.Replace("[[Child2FirstName]]", data.Child2FirstName);
            htmlBody = htmlBody.Replace("[[Child2MiddleInitial]]", data.Child2MiddleInitial);
            htmlBody = htmlBody.Replace("[[Child2LastName]]", data.Child2LastName);
            htmlBody = htmlBody.Replace("[[Child2Grade]]", data.Child2Grade);
            htmlBody = htmlBody.Replace("[[Child2DOB]]", data.Child2DOB);
            htmlBody = htmlBody.Replace("[[Child2Email]]", data.Child2Email);
            htmlBody = htmlBody.Replace("[[Child2BaptismPlace]]", data.Child2BaptismPlace);
            htmlBody = htmlBody.Replace("[[Child2BaptismDate]]", data.Child2BaptismDate);
            htmlBody = htmlBody.Replace("[[Child2EucharistPlace]]", data.Child2EucharistPlace);
            htmlBody = htmlBody.Replace("[[Child2EucharistDate]]", data.Child2EucharistDate);
            htmlBody = htmlBody.Replace("[[sacrecords2]]", data.sacrecords2);
            htmlBody = htmlBody.Replace("[[reledchoice2]]", data.reledchoice2);

            htmlBody = htmlBody.Replace("[[Child3FirstName]]", data.Child3FirstName);
            htmlBody = htmlBody.Replace("[[Child3MiddleInitial]]", data.Child3MiddleInitial);
            htmlBody = htmlBody.Replace("[[Child3LastName]]", data.Child3LastName);
            htmlBody = htmlBody.Replace("[[Child3Grade]]", data.Child3Grade);
            htmlBody = htmlBody.Replace("[[Child3DOB]]", data.Child3DOB);
            htmlBody = htmlBody.Replace("[[Child3Email]]", data.Child3Email);
            htmlBody = htmlBody.Replace("[[Child3BaptismPlace]]", data.Child3BaptismPlace);
            htmlBody = htmlBody.Replace("[[Child3BaptismDate]]", data.Child3BaptismDate);
            htmlBody = htmlBody.Replace("[[Child3EucharistPlace]]", data.Child3EucharistPlace);
            htmlBody = htmlBody.Replace("[[Child3EucharistDate]]", data.Child3EucharistDate);
            htmlBody = htmlBody.Replace("[[sacrecords3]]", data.sacrecords3);
            htmlBody = htmlBody.Replace("[[reledchoice3]]", data.reledchoice3);

            htmlBody = htmlBody.Replace("[[Child4FirstName]]", data.Child4FirstName);
            htmlBody = htmlBody.Replace("[[Child4MiddleInitial]]", data.Child4MiddleInitial);
            htmlBody = htmlBody.Replace("[[Child4LastName]]", data.Child4LastName);
            htmlBody = htmlBody.Replace("[[Child4Grade]]", data.Child4Grade);
            htmlBody = htmlBody.Replace("[[Child4DOB]]", data.Child4DOB);
            htmlBody = htmlBody.Replace("[[Child4Email]]", data.Child4Email);
            htmlBody = htmlBody.Replace("[[Child4BaptismPlace]]", data.Child4BaptismPlace);
            htmlBody = htmlBody.Replace("[[Child4BaptismDate]]", data.Child4BaptismDate);
            htmlBody = htmlBody.Replace("[[Child4EucharistPlace]]", data.Child4EucharistPlace);
            htmlBody = htmlBody.Replace("[[Child4EucharistDate]]", data.Child4EucharistDate);
            htmlBody = htmlBody.Replace("[[sacrecords4]]", data.sacrecords4);
            htmlBody = htmlBody.Replace("[[reledchoice4]]", data.reledchoice4);

            htmlBody = htmlBody.Replace("[[Child5FirstName]]", data.Child5FirstName);
            htmlBody = htmlBody.Replace("[[Child5MiddleInitial]]", data.Child5MiddleInitial);
            htmlBody = htmlBody.Replace("[[Child5LastName]]", data.Child5LastName);
            htmlBody = htmlBody.Replace("[[Child5Grade]]", data.Child5Grade);
            htmlBody = htmlBody.Replace("[[Child5DOB]]", data.Child5DOB);
            htmlBody = htmlBody.Replace("[[Child5Email]]", data.Child5Email);
            htmlBody = htmlBody.Replace("[[Child5BaptismPlace]]", data.Child5BaptismPlace);
            htmlBody = htmlBody.Replace("[[Child5BaptismDate]]", data.Child5BaptismDate);
            htmlBody = htmlBody.Replace("[[Child5EucharistPlace]]", data.Child5EucharistPlace);
            htmlBody = htmlBody.Replace("[[Child5EucharistDate]]", data.Child5EucharistDate);
            htmlBody = htmlBody.Replace("[[sacrecords5]]", data.sacrecords5);
            htmlBody = htmlBody.Replace("[[reledchoice5]]", data.reledchoice5);

            htmlBody = htmlBody.Replace("[[Child6FirstName]]", data.Child6FirstName);
            htmlBody = htmlBody.Replace("[[Child6MiddleInitial]]", data.Child6MiddleInitial);
            htmlBody = htmlBody.Replace("[[Child6LastName]]", data.Child6LastName);
            htmlBody = htmlBody.Replace("[[Child6Grade]]", data.Child6Grade);
            htmlBody = htmlBody.Replace("[[Child6DOB]]", data.Child6DOB);
            htmlBody = htmlBody.Replace("[[Child6Email]]", data.Child6Email);
            htmlBody = htmlBody.Replace("[[Child6BaptismPlace]]", data.Child6BaptismPlace);
            htmlBody = htmlBody.Replace("[[Child6BaptismDate]]", data.Child6BaptismDate);
            htmlBody = htmlBody.Replace("[[Child6EucharistPlace]]", data.Child6EucharistPlace);
            htmlBody = htmlBody.Replace("[[Child6EucharistDate]]", data.Child6EucharistDate);
            htmlBody = htmlBody.Replace("[[sacrecords6]]", data.sacrecords6);
            htmlBody = htmlBody.Replace("[[reledchoice6]]", data.reledchoice6);
            htmlBody = htmlBody.Replace("[[amtdue]]", data.amtdue);
            return htmlBody;
        }

        private static string GetSacramentRecords(string val)
        {
            
            switch (val)
            {
                case "WillSend":
                    return GlobalConstants.willSend;
                case "PreviouslySend":
                    return GlobalConstants.previouslySend;
                case "StMalachySacrament":
                    return GlobalConstants.StMalachySacrament;
                default:
                    break;
            }
            return string.Empty;
        }

        private static string GetRelEdChoice(string val)
        {
            switch (val)
            {
                case "SummerSession1":
                    return GlobalConstants.summerSession1;
                
                case "SundayProgram":
                    return GlobalConstants.sundayProgram;
                case "MondayNight":
                    return GlobalConstants.mondayNight;
                case "Confirmation1":
                    return GlobalConstants.confirmation1;
                case "Confirmation2":
                    return GlobalConstants.confirmation2;
                default:
                    break;
            }
            return string.Empty;

        }
    }
}