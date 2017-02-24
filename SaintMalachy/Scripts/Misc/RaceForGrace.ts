///<reference path="../Global/GlobalConstants.ts" />
///<reference path="../Global/EmailHelper.ts" />
class RaceForGraceForm {
    private raceforgraceSendEmailUrl = "/Misc/SendRaceForGraceEmail";
    SetRaceForGraceFields(): RaceForGraceFields {
        let formFields = new RaceForGraceFields();
        formFields.FirstName = $("#FirstName").val();
        formFields.LastName = $("#LastName").val();
        formFields.DateOfBirth = $("#DateOfBirth").val();
        formFields.EmailAddress = $("#EmailAddress").val();
        $("input:checkbox[name='interest']:checked").each(function () {
            if (formFields.Interest != undefined)
            { formFields.Interest = formFields.Interest + ',' + $(this).val(); }
            else {
                formFields.Interest = $(this).val();
            }
            
        });
        return formFields;
    }
    SendEmail(): string {
        let raceforgraceData: string = $.param(this.SetRaceForGraceFields());
        let url = UrlConstants.URL + this.raceforgraceSendEmailUrl;
        let returnMessage = EmailHelper.SendEmail(url, raceforgraceData, 'raceforgrace');
        return returnMessage;
    }

}

class RaceForGraceFields {
    FirstName: string
    LastName: string
    DateOfBirth: string
    EmailAddress: string
    Interest: string
}

