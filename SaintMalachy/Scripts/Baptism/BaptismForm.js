///<reference path="../Global/GlobalConstants.ts" />
///<reference path="../Global/EmailHelper.ts" />
var BaptismForm = (function () {
    function BaptismForm() {
        this.baptismSendEmailUrl = "/Baptism/SendEmail";
    }
    BaptismForm.prototype.SetBaptismFormFields = function () {
        var formFields = new BaptismFormFields();
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
    };
    BaptismForm.prototype.SendEmail = function () {
        var baptismData = $.param(this.SetBaptismFormFields());
        var url = UrlConstants.URL + this.baptismSendEmailUrl;
        var returnMessage = EmailHelper.SendEmail(url, baptismData, 'baptism');
        return returnMessage;
    };
    return BaptismForm;
}());
var BaptismFormFields = (function () {
    function BaptismFormFields() {
    }
    return BaptismFormFields;
}());
//# sourceMappingURL=BaptismForm.js.map