$(document).ready(function () {
    var vaslidator = $("#funeralform").validate({
        rules: {
            NameOfDeceased: { required: true, lettersonly: true },
            Address: { required: true },
            Age: { required: true, digits: true },
            DateOfBirth: { required: true, date: true },
            DateOfDeath: { required: true, date: true },
            KinRelationship: { required: true, letterswithbasicpunc: true },
            KinAddress: { required: true},
            KinPhoneNumber: { required: true, phoneUS: true },
            FuneralHome: { required: true },
            FuneralHomeAddress: { required: true },
            FuneralHomeUrl: { required: true, url2: true },
            DateOfFuneral: { required: true, date:true },
            TimeOfFuneral: { required: true, time12h:true },
            DateOfWake: { required: true, date:true },
            TimeOfWake: { required: true },
            Cemetry: { required: true, letterswithbasicpunc: true }
        },
        messages: {
            NameOfDeceased: { required: "Name of deceased is required", lettersonly: "Numbers or special characters not allowed" },
            Address: { required: "Address is required" },
            Age: { required: "Age is required", digits: "Age is not valid" },
            DateOfBirth: { required: "Date of birth is required", date: "Date of birth is not valid" },
            DateOfDeath: { required: "Date of death is required", date: "Date of death is not valid" },
            KinRelationship: { required: "Next of kin relationship is required", lettersonly: "Numbers are not allowed" },
            KinAddress: { required: "Address is required" },
            KinPhoneNumber: { required: "Phone number is required", phoneUS:"Phone number is not valid" },
            FuneralHome: { required: "Funeral home is required" },
            FuneralHomeAddress: { required: "Funeral home address is required" },
            FuneralHomeUrl: { required: "Funeral home website is required", url2: "Website address is not valid" },
            DateOfFuneral: { required: "Date of funeral is required", date: "Date of funeral is not valid" },
            TimeOfFuneral: { required: "Time of funeral is required", time12h:"Pleas enter time in hour:min am/pm format" },
            DateOfWake: { required: "Date of wake is required", date:"Date of wake is not valid" },
            TimeOfWake: { required: "Times of wake is required" },
            Cemetry: { required: "Please enter name and town of cemetry", letterswithbasicpunc: "Numbers are not allowed" }

        },
        submitHandler: function (form) {
            $("#loader").modal('show');
            var form = new FuneralRequestForm();
            var returnmessage = form.SendEmail("funeralform");

        }
    });
    $("#DateOfBirth").datepicker();
    $("#DateOfDeath").datepicker();
    $("#DateOfFuneral").datepicker();
    $("#DateOfWake").datepicker();
});