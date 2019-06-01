///<reference path="../Global/GlobalConstants.ts" />
///<reference path="../Global/EmailHelper.ts" />
var FuneralRequestForm = /** @class */ (function () {
    function FuneralRequestForm() {
        this.funeralrequestEmailUrl = "/Funeral/SendRequestEmail";
        this.funeralhomeEmailUrl = "/Funeral/SendFuneralHomeInfoEmail";
    }
    FuneralRequestForm.prototype.SetFuneralRequestFormFields = function () {
        var formFields = new FuneralRequestFormFields();
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
    };
    FuneralRequestForm.prototype.SetFuneralHomeInfoSheet = function () {
        var formFields = new FuneralHomeInfoSheetFields();
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
    };
    FuneralRequestForm.prototype.SendEmail = function (formtype) {
        var funeralrequestData;
        var url;
        var returnMessage;
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
    };
    return FuneralRequestForm;
}());
var FuneralRequestFormFields = /** @class */ (function () {
    function FuneralRequestFormFields() {
    }
    return FuneralRequestFormFields;
}());
var FuneralHomeInfoSheetFields = /** @class */ (function () {
    function FuneralHomeInfoSheetFields() {
    }
    return FuneralHomeInfoSheetFields;
}());
//# sourceMappingURL=FuneralRequestForm.js.map