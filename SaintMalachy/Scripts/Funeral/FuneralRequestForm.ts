///<reference path="../Global/GlobalConstants.ts" />
///<reference path="../Global/EmailHelper.ts" />
class FuneralRequestForm
{
    private funeralrequestEmailUrl = "/Funeral/SendRequestEmail";
    private funeralhomeEmailUrl = "/Funeral/SendFuneralHomeInfoEmail";
    SetFuneralRequestFormFields(): FuneralRequestFormFields {
        let formFields = new FuneralRequestFormFields();
        formFields.NameOfDeceased = $("#NameOfDeceased").val();
        formFields.Address = $("#Address").val();
        formFields.Age = $("#Age").val();
        formFields.DateOfBirth = $("#DateOfBirth").val();
        formFields.DateOfDeath = $("#DateOfDeath").val();
        formFields.KinRelationship = $("#KinRelationship").val();
        formFields.KinAddress = $("#KinAddress").val();
        formFields.KinPhoneNumber = $("#KinPhoneNumber").val();
        formFields.FuneralHome = $("#FuneralHome").val();
        formFields.FuneralHomeAddress = $("#FuneralHomeAddress").val();
        formFields.FuneralHomeUrl = $("#FuneralHomeUrl").val();
        formFields.DateOfFuneral = $("#DateOfFuneral").val();
        formFields.TimeOfFuneral = $("#TimeOfFuneral").val();
        formFields.DateOfWake = $("#DateOfWake").val();
        formFields.TimeOfWake = $("#TimeOfWake").val();
        formFields.Cemetry = $("#Cemetry").val();
        formFields.Comments = $("#Comments").val();
        return formFields;
    }
    SetFuneralHomeInfoSheet(): FuneralHomeInfoSheetFields {
        let formFields = new FuneralHomeInfoSheetFields();
        formFields.NameOfDeceased = $("#NameOfDeceased").val();
        formFields.DateOfBirth = $("#DateOfBirth").val();
        formFields.DateOfDeath = $("#DateOfDeath").val();
        formFields.FuneralHome = $("#FuneralHome").val();
        formFields.DateOfFuneral = $("#DateOfFuneral").val();
        formFields.TimeOfFuneral = $("#TimeOfFuneral").val();
        formFields.DateOfWake = $("#DateOfWake").val();
        formFields.TimeOfWake = $("#TimeOfWake").val();
        formFields.ProcessionalSong = $("#ProcessionalSong").val();
        formFields.OtherHymns = $("#OtherHymns").val();
        formFields.ResponsorialPsalm = $("#ResponsorialPsalm").val();
        formFields.OffertorySong = $("#OffertorySong").val();
        formFields.CommunionSong = $("#CommunionSong").val();
        formFields.RecessionalSong = $("#RecessionalSong").val();
        formFields.ReaderOneReading = $("#ReaderOneReading").val();
        formFields.ReaderTwoReading = $("#ReaderTwoReading").val();
        formFields.PresentationOfGifts = $("#PresentationOfGifts").val();
        formFields.Eulogy = $("#Eulogy").val();
        formFields.Comments = $("#Comments").val();
        return formFields;
    }
    SendEmail(formtype: string): string {
        let funeralrequestData: string
        let url:string
        let returnMessage:string
        switch (formtype) {
            case "funeralform":
                funeralrequestData = $.param(this.SetFuneralRequestFormFields());
                url = UrlConstants.URL + this.funeralrequestEmailUrl;
                returnMessage = EmailHelper.SendEmail(url, funeralrequestData, 'funeralrequest');
                break;
            case "funeralhomeinfoform":
                funeralrequestData = $.param(this.SetFuneralHomeInfoSheet());
                url = UrlConstants.URL + this.funeralhomeEmailUrl;
                returnMessage = EmailHelper.SendEmail(url, funeralrequestData, 'funeralhomeinfo');
                break;
            default:
                break;
        }
        return returnMessage;
    }
    
}

class FuneralRequestFormFields {
    NameOfDeceased: string
    Address:string
    Age:string
    DateOfBirth:string
    DateOfDeath:string
    KinRelationship:string
    KinAddress:string
    KinPhoneNumber:string
    FuneralHome:string
    FuneralHomeAddress:string
    FuneralHomeUrl:string
    DateOfFuneral:string
    TimeOfFuneral:string
    DateOfWake:string
    TimeOfWake:string
    Cemetry:string
    Comments:string
}

class FuneralHomeInfoSheetFields {
    NameOfDeceased: string
    DateOfBirth: string
    DateOfDeath: string
    FuneralHome: string
    DateOfFuneral: string
    TimeOfFuneral: string
    DateOfWake: string
    TimeOfWake: string
    ProcessionalSong: string
    OtherHymns: string
    ResponsorialPsalm: string
    OffertorySong: string 
    CommunionSong: string
    RecessionalSong: string
    ReaderOneReading: string
    ReaderTwoReading: string
    PresentationOfGifts: string
    Eulogy: string
    Comments: string

}

