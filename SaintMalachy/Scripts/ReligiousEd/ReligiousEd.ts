///<reference path="../Global/GlobalConstants.ts" />
///<reference path="../Global/EmailHelper.ts" />
class ReligiousEdForm {
    private religiousEdSendEmailUrl = "/ReligiousEd/SendEmail";
    SetReligiousEdFormFields(): ReligiousFormFields {
        let formFields = new ReligiousFormFields();
        formFields.TodayDate = $("#TodayDate").val();
        formFields.FamilyName = $("#FamilyName").val();
        formFields.Address = $("#Address").val();
        formFields.City = $("#City").val();
        formFields.State = $("#State").val();
        formFields.ZipCode = $("#ZipCode").val();
        formFields.Phone = $("#Phone").val();
        formFields.FamilyEmail = $("#FamilyEmail").val();
        formFields.FatherFirstName = $("#FatherFirstName").val();
        formFields.FatherLastName = $("#FatherLastName").val();
        formFields.FatherEmail = $("#FatherEmail").val();
        formFields.MotherFirstName = $("#MotherFirstName").val();
        formFields.MotherLastName = $("#MotherLastName").val();
        formFields.MotherMaiden = $("#MotherMaiden").val();
        formFields.MotherEmail = $("#MotherEmail").val();
        switch ($('input:checkbox[name=checkhelp]:checked').val())
        {
            case "teaching":
                formFields.HelpTeaching = true;
                break;
            case "helping":
                formFields.HelpHelping = true;
                break;
            case "kidhelping":
                formFields.HelpKidhelping = true;
                break;
            default:
                break;
        }
        formFields.WantToHelp = $('input:checkbox[name=checkhelp]:checked').data("text");
        formFields.HelpInterest = $("#HelpInterest").val();
        formFields.Child1FirstName = $("#Child1FirstName").val();
        formFields.Child1MiddleInitial = $("#Child1MiddleInitial").val();
        formFields.Child1LastName = $("#Child1LastName").val();
        formFields.Child1Grade = $("#Child1Grade").val();
        formFields.Child1DOB = $("#Child1DOB").val();
        formFields.Child1Email = $("#Child1Email").val();
        formFields.Child1BaptismPlace = $("#Child1BaptismPlace").val();
        formFields.Child1BaptismDate = $("#Child1BaptismDate").val();
        formFields.Child1EucharistPlace = $("#Child1EucharistPlace").val();
        formFields.Child1EucharistDate = $("#Child1EucharistDate").val();
        formFields.sacrecords1 = $("input:radio[name='sacrecords1']:checked").val();
        formFields.reledchoice1 = $("input:radio[name='reledchoice1']:checked").val();

        formFields.Child2FirstName = $("#Child2FirstName").val();
        formFields.Child2MiddleInitial = $("#Child2MiddleInitial").val();
        formFields.Child2LastName = $("#Child2LastName").val();
        formFields.Child2Grade = $("#Child2Grade").val();
        formFields.Child2DOB = $("#Child2DOB").val();
        formFields.Child2Email = $("#Child2Email").val();
        formFields.Child2BaptismPlace = $("#Child2BaptismPlace").val();
        formFields.Child2BaptismDate = $("#Child2BaptismDate").val();
        formFields.Child2EucharistPlace = $("#Child2EucharistPlace").val();
        formFields.Child2EucharistDate = $("#Child2EucharistDate").val();
        formFields.sacrecords2 = $("input:radio[name='sacrecords2']:checked").val();
        formFields.reledchoice2 = $("input:radio[name='reledchoice2']:checked").val();

        formFields.Child3FirstName = $("#Child3FirstName").val();
        formFields.Child3MiddleInitial = $("#Child3MiddleInitial").val();
        formFields.Child3LastName = $("#Child3LastName").val();
        formFields.Child3Grade = $("#Child3Grade").val();
        formFields.Child3DOB = $("#Child3DOB").val();
        formFields.Child3Email = $("#Child3Email").val();
        formFields.Child3BaptismPlace = $("#Child3BaptismPlace").val();
        formFields.Child3BaptismDate = $("#Child3BaptismDate").val();
        formFields.Child3EucharistPlace = $("#Child3EucharistPlace").val();
        formFields.Child3EucharistDate = $("#Child3EucharistDate").val();
        formFields.sacrecords3 = $("input:radio[name='sacrecords3']:checked").val();
        formFields.reledchoice3 = $("input:radio[name='reledchoice3']:checked").val();

        formFields.Child4FirstName = $("#Child4FirstName").val();
        formFields.Child4MiddleInitial = $("#Child4MiddleInitial").val();
        formFields.Child4LastName = $("#Child4LastName").val();
        formFields.Child4Grade = $("#Child4Grade").val();
        formFields.Child4DOB = $("#Child4DOB").val();
        formFields.Child4Email = $("#Child4Email").val();
        formFields.Child4BaptismPlace = $("#Child4BaptismPlace").val();
        formFields.Child4BaptismDate = $("#Child4BaptismDate").val();
        formFields.Child4EucharistPlace = $("#Child4EucharistPlace").val();
        formFields.Child4EucharistDate = $("#Child4EucharistDate").val();
        formFields.sacrecords4 = $("input:radio[name='sacrecords4']:checked").val();
        formFields.reledchoice4 = $("input:radio[name='reledchoice4']:checked").val();

        formFields.Child5FirstName = $("#Child5FirstName").val();
        formFields.Child5MiddleInitial = $("#Child5MiddleInitial").val();
        formFields.Child5LastName = $("#Child5LastName").val();
        formFields.Child5Grade = $("#Child5Grade").val();
        formFields.Child5DOB = $("#Child5DOB").val();
        formFields.Child5Email = $("#Child5Email").val();
        formFields.Child5BaptismPlace = $("#Child5BaptismPlace").val();
        formFields.Child5BaptismDate = $("#Child5BaptismDate").val();
        formFields.Child5EucharistPlace = $("#Child5EucharistPlace").val();
        formFields.Child5EucharistDate = $("#Child5EucharistDate").val();
        formFields.sacrecords5 = $("input:radio[name='sacrecords5']:checked").val();
        formFields.reledchoice5 = $("input:radio[name='reledchoice5']:checked").val();

        formFields.Child6FirstName = $("#Child6FirstName").val();
        formFields.Child6MiddleInitial = $("#Child6MiddleInitial").val();
        formFields.Child6LastName = $("#Child6LastName").val();
        formFields.Child6Grade = $("#Child6Grade").val();
        formFields.Child6DOB = $("#Child6DOB").val();
        formFields.Child6Email = $("#Child6Email").val();
        formFields.Child6BaptismPlace = $("#Child6BaptismPlace").val();
        formFields.Child6BaptismDate = $("#Child6BaptismDate").val();
        formFields.Child6EucharistPlace = $("#Child6EucharistPlace").val();
        formFields.Child6EucharistDate = $("#Child6EucharistDate").val();
        formFields.sacrecords6 = $("input:radio[name='sacrecords6']:checked").val();
        formFields.reledchoice6 = $("input:radio[name='reledchoice6']:checked").val();
        
        formFields.amtdue = $("input:radio[name='amtdue']:checked").data("text");
        return formFields;
    }
    SendEmail(): string {
        let religiousEdData: string = $.param(this.SetReligiousEdFormFields());
        let url = UrlConstants.URL + this.religiousEdSendEmailUrl;
        let returnMessage = EmailHelper.SendEmail(url, religiousEdData, 'religioused');
        return returnMessage;
    }

}

class ReligiousFormFields {
    TodayDate: string
    FamilyName: string
    Address: string
    City: string
    State: string
    ZipCode: string
    Phone: string
    FamilyEmail: string
    FatherFirstName: string
    FatherLastName: string
    FatherEmail: string
    MotherFirstName: string
    MotherLastName: string
    MotherMaiden: string
    MotherEmail: string
    HelpTeaching: boolean
    HelpHelping: boolean
    HelpKidhelping: boolean
    WantToHelp:string
    HelpInterest:string
    Child1FirstName: string
    Child1MiddleInitial: string
    Child1LastName: string
    Child1Grade: string
    Child1DOB: string
    Child1Email: string
    Child1BaptismPlace: string
    Child1BaptismDate: string
    Child1EucharistPlace: string
    Child1EucharistDate: string
    sacrecords1: string
    reledchoice1: string

    Child2FirstName: string
    Child2MiddleInitial: string
    Child2LastName: string
    Child2Grade: string
    Child2DOB: string
    Child2Email: string
    Child2BaptismPlace: string
    Child2BaptismDate: string
    Child2EucharistPlace: string
    Child2EucharistDate: string
    sacrecords2: string
    reledchoice2: string

    Child3FirstName: string
    Child3MiddleInitial: string
    Child3LastName: string
    Child3Grade: string
    Child3DOB: string
    Child3Email: string
    Child3BaptismPlace: string
    Child3BaptismDate: string
    Child3EucharistPlace: string
    Child3EucharistDate: string
    sacrecords3: string
    reledchoice3: string

    Child4FirstName: string
    Child4MiddleInitial: string
    Child4LastName: string
    Child4Grade: string
    Child4DOB: string
    Child4Email: string
    Child4BaptismPlace: string
    Child4BaptismDate: string
    Child4EucharistPlace: string
    Child4EucharistDate: string
    sacrecords4: string
    reledchoice4: string

    Child5FirstName: string
    Child5MiddleInitial: string
    Child5LastName: string
    Child5Grade: string
    Child5DOB: string
    Child5Email: string
    Child5BaptismPlace: string
    Child5BaptismDate: string
    Child5EucharistPlace: string
    Child5EucharistDate: string
    sacrecords5: string
    reledchoice5: string

    Child6FirstName: string
    Child6MiddleInitial: string
    Child6LastName: string
    Child6Grade: string
    Child6DOB: string
    Child6Email: string
    Child6BaptismPlace: string
    Child6BaptismDate: string
    Child6EucharistPlace: string
    Child6EucharistDate: string
    sacrecords6: string
    reledchoice6: string
    amtdue: string
    
}

