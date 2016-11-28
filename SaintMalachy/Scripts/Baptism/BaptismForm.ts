///<reference path="../Global/GlobalConstants.ts" />
///<reference path="../Global/EmailHelper.ts" />
class BaptismForm
{
    private baptismSendEmailUrl = "/Baptism/SendEmail";
    SetBaptismFormFields(): BaptismFormFields {
        let formFields = new BaptismFormFields();
        formFields.BaptismDate = $("#BaptismDate").val();
        formFields.DinnerDate = $("#DinnerDate").val();
        formFields.ChildLastName = $("#ChildLastName").val();
        formFields.ChildName = $("#ChildName").val();
        formFields.ChildDateOfBirth = $("#ChildDateOfBirth").val();
        formFields.ChildPlaceOfBirth = $("#ChildPlaceOfBirth").val();
        formFields.FatherFullName = $("#FatherFullName").val();
        formFields.MotherFirstName = $("#MotherFirstName").val();
        formFields.MotherMaidenName = $("#MotherMaidenName").val();
        formFields.ParentsMarried = $("input:radio[name='parMarried']:checked").val();
        formFields.ChurchMarriage = (formFields.ParentsMarried == "Yes") ? $("input:radio[name='parChurchMarriage']:checked").val() : "";
        formFields.ParentsConfirmed = $("input:radio[name='parConfirmed']:checked").val();
        formFields.Address = $("#Address").val();
        formFields.CityState = $("#CityState").val();
        formFields.Phone = $("#Phone").val();
        formFields.Email = $("#Email").val();
        formFields.GodfatherName = $("#GodfatherName").val();
        formFields.GodfatherReligion = $("#GodfatherReligion").val();
        formFields.GodfatherConfirmed = $("input:radio[name='gfConfirmed']:checked").val();
        formFields.GodmotherName = $("#GodmotherName").val();
        formFields.GodmotherReligion = $("#GodmotherReligion").val();
        formFields.GodmotherConfirmed = $("input:radio[name='gmConfirmed']:checked").val();
        formFields.CommentsQuestions = $("#CommentsQuestions").val();
        return formFields;
    }
    SendEmail(): string {
        let baptismData: string = $.param(this.SetBaptismFormFields());
        let url = UrlConstants.URL + this.baptismSendEmailUrl;
        let returnMessage = EmailHelper.SendEmail(url, baptismData,'baptism');
        return returnMessage;
    }
    
}

class BaptismFormFields {
    BaptismDate: string
    DinnerDate:string
    ChildLastName: string
    ChildName:string
    ChildDateOfBirth:string
    ChildPlaceOfBirth:string
    FatherFullName:string
    MotherFirstName:string
    MotherMaidenName: string
    ParentsMarried: string
    ChurchMarriage: string
    ParentsConfirmed: string
    Address:string
    CityState:string
    Phone:string
    Email:string
    GodfatherName:string
    GodfatherReligion:string
    GodfatherConfirmed:string
    GodmotherName:string
    GodmotherReligion:string
    GodmotherConfirmed:string
    CommentsQuestions:string
}

