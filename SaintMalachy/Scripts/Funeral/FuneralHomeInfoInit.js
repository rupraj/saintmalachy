$(document).ready(function () {
    var vaslidator = $("#funeralhomeinfoform").validate({
        rules: {
            NameOfDeceased: { required: true, lettersonly: true },
            DateOfBirth: { required: true, date: true },
            DateOfDeath: { required: true, date: true },
            FuneralHome: { required: true },
            DateOfFuneral: { required: true, date:true },
            TimeOfFuneral: { required: true, time12h:true },
            DateOfWake: { required: true, date:true },
            TimeOfWake: { required: true }
        },
        messages: {
            NameOfDeceased: { required: "Name of deceased is required", lettersonly: "Numbers or special characters not allowed" },
            DateOfBirth: { required: "Date of birth is required", date: "Date of birth is not valid" },
            DateOfDeath: { required: "Date of death is required", date: "Date of death is not valid" },
            FuneralHome: { required: "Funeral home is required" },
            DateOfFuneral: { required: "Date of funeral is required", date: "Date of funeral is not valid" },
            TimeOfFuneral: { required: "Time of funeral is required", time12h:"Pleas enter time in hour:min am/pm format" },
            DateOfWake: { required: "Date of wake is required", date:"Date of wake is not valid" },
            TimeOfWake: { required: "Times of wake is required" }

        },
        submitHandler: function (form) {
            $("#loader").modal('show');
            var form = new FuneralRequestForm();
            var returnmessage = form.SendEmail("funeralhomeinfoform");

        }
    });
    $("#DateOfBirth").datepicker();
    $("#DateOfDeath").datepicker();
    $("#DateOfFuneral").datepicker();
    $("#DateOfWake").datepicker();
});