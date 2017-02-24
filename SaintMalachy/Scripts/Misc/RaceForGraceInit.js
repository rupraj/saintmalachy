$(document).ready(function () {

    var validator = $("#raceForGrace").validate({
        rules: {
            FirstName: { required: true, lettersonly: true },
            LastName: { required: true, lettersonly: true },
            DateOfBirth: { required: true, date: true },
            EmailAddress: { email: true }
        },
        messages: {
            FirstName: { required: "First name is required", lettersonly: "Numbers or special characters not allowed" },
            LastName: { required: "Last name is required", lettersonly: "Numbers or special characters not allowed" },
            DateOfBirth: { required: "Birth date is required", date: "Birth date is not valid" },
            EmailAddress: {email: "Email address is not valid" }
        },
        submitHandler: function (form) {
            $("#loader").modal('show');
            var form = new RaceForGraceForm();
            var returnmessage = form.SendEmail();

        }
    });
    $("#DateOfBirth").datepicker();
});