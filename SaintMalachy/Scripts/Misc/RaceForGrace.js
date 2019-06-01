///<reference path="../Global/GlobalConstants.ts" />
///<reference path="../Global/EmailHelper.ts" />
var RaceForGraceForm = /** @class */ (function () {
    function RaceForGraceForm() {
        this.raceforgraceSendEmailUrl = "/Misc/SendRaceForGraceEmail";
    }
    RaceForGraceForm.prototype.SetRaceForGraceFields = function () {
        var formFields = new RaceForGraceFields();
        formFields.FirstName = $("#FirstName").val();
        formFields.LastName = $("#LastName").val();
        formFields.DateOfBirth = $("#DateOfBirth").val();
        formFields.EmailAddress = $("#EmailAddress").val();
        $("input:checkbox[name='interest']:checked").each(function () {
            if (formFields.Interest != undefined) {
                formFields.Interest = formFields.Interest + ',' + $(this).val();
            }
            else {
                formFields.Interest = $(this).val();
            }
        });
        return formFields;
    };
    RaceForGraceForm.prototype.SendEmail = function () {
        var raceforgraceData = $.param(this.SetRaceForGraceFields());
        var url = UrlConstants.URL + this.raceforgraceSendEmailUrl;
        var returnMessage = EmailHelper.SendEmail(url, raceforgraceData, 'raceforgrace');
        return returnMessage;
    };
    return RaceForGraceForm;
}());
var RaceForGraceFields = /** @class */ (function () {
    function RaceForGraceFields() {
    }
    return RaceForGraceFields;
}());
//# sourceMappingURL=RaceForGrace.js.map