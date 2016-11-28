$(document).ready(function () {
    $("#familyNext").on("click",function (e) {
        $("#ChildInfoContainer").toggle();
        $("#familyInfoContainer").toggle();
        e.stopImmediatePropagation();
    });

    $("#childBack").click(function (e) {
        $("#ChildInfoContainer").toggle();
        $("#familyInfoContainer").toggle();
        e.stopImmediatePropagation();
    });

    $("#childNext").click(function (e) {
        $("#ChildInfoContainer").toggle();
        $("#PaymentsContainer").toggle();
        e.stopImmediatePropagation();
    });

    $("#PaymentBack").click(function (e) {
        $("#ChildInfoContainer").toggle();
        $("#PaymentsContainer").toggle();
        e.stopImmediatePropagation();
    });

    $("#TodayDate").datepicker();
    $("#Child1DOB").datepicker();
    $("#Child2DOB").datepicker();
    $("#Child3DOB").datepicker();
    $("#Child4DOB").datepicker();
    $("#Child5DOB").datepicker();
    $("#Child6DOB").datepicker();
    $("#Child1BaptismDate").datepicker();
    $("#Child2BaptismDate").datepicker();
    $("#Child3BaptismDate").datepicker();
    $("#Child4BaptismDate").datepicker();
    $("#Child5BaptismDate").datepicker();
    $("#Child6BaptismDate").datepicker();
    $("#Child1EucharistDate").datepicker();
    $("#Child2EucharistDate").datepicker();
    $("#Child3EucharistDate").datepicker();
    $("#Child4EucharistDate").datepicker();
    $("#Child5EucharistDate").datepicker();
    $("#Child6EucharistDate").datepicker();



    var validator = $("#ReligiousEd").validate({
        rules: {
            TodayDate: { date: true },
            FamilyName: { lettersonly: true },
            City: { lettersonly: true },
            State: { lettersonly: true },
            ZipCode: { zipcodeUS: true },
            Phone: { phoneUS: true },
            FamilyEmail: { email: true },
            FatherFirstName: { lettersonly: true },
            FatherLastName: { lettersonly: true },
            FatherEmail: { email: true },
            MotherFirstName: { lettersonly: true },
            MotherLastName: { lettersonly: true },
            MotherMaiden: { lettersonly: true },
            MotherEmail: { email: true },

            Child1FirstName: { lettersonly: true },
            Child1MiddleInitial: { lettersonly: true },
            Child1LastName: { lettersonly: true },
            Child1DOB: { date: true },
            Child1Email: { email: true },
            Child1BaptismPlace: { letterswithbasicpunc: true },
            Child1BaptismDate: { date: true },
            Child1EucharistPlace: { letterswithbasicpunc: true },
            Child1EucharistDate: { date: true },

            Child2FirstName: { lettersonly: true },
            Child2MiddleInitial: { lettersonly: true },
            Child2LastName: { lettersonly: true },
            Child2DOB: { date: true },
            Child2Email: { email: true },
            Child2BaptismPlace: { letterswithbasicpunc: true },
            Child2BaptismDate: { date: true },
            Child2EucharistPlace: { letterswithbasicpunc: true },
            Child2EucharistDate: { date: true },

            Child3FirstName: { lettersonly: true },
            Child3MiddleInitial: { lettersonly: true },
            Child3LastName: { lettersonly: true },
            Child3DOB: { date: true },
            Child3Email: { email: true },
            Child3BaptismPlace: { letterswithbasicpunc: true },
            Child3BaptismDate: { date: true },
            Child3EucharistPlace: { letterswithbasicpunc: true },
            Child3EucharistDate: { date: true },

            Child4FirstName: { lettersonly: true },
            Child4MiddleInitial: { lettersonly: true },
            Child4LastName: { lettersonly: true },
            Child4DOB: { date: true },
            Child4Email: { email: true },
            Child4BaptismPlace: { letterswithbasicpunc: true },
            Child4BaptismDate: { date: true },
            Child4EucharistPlace: { letterswithbasicpunc: true },
            Child4EucharistDate: { date: true },

            Child5FirstName: { lettersonly: true },
            Child5MiddleInitial: { lettersonly: true },
            Child5LastName: { lettersonly: true },
            Child5DOB: { date: true },
            Child5Email: { email: true },
            Child5BaptismPlace: { letterswithbasicpunc: true },
            Child5BaptismDate: { date: true },
            Child5EucharistPlace: { letterswithbasicpunc: true },
            Child5EucharistDate: { date: true },

            Child6FirstName: { lettersonly: true },
            Child6MiddleInitial: { lettersonly: true },
            Child6LastName: { lettersonly: true },
            Child6DOB: { date: true },
            Child6Email: { email: true },
            Child6BaptismPlace: { letterswithbasicpunc: true },
            Child6BaptismDate: { date: true },
            Child6EucharistPlace: { letterswithbasicpunc: true },
            Child6EucharistDate: { date: true }
        },
        messages: {
            TodayDate: { date: "Today's date is not valid" },
            FamilyName: { lettersonly: "Numbers or special characters not allowed" },
            City: { lettersonly: "Numbers or special characters not allowed" },
            State: { lettersonly: "Numbers or special characters not allowed" },
            ZipCode: { zipcodeUS: "Zip code is not valid" },
            Phone: { phoneUS: "Phone number is not valid" },
            FamilyEmail: { email: "Email address is not valid" },
            FatherFirstName: { lettersonly: "Numbers or special characters not allowed" },
            FatherLastName: { lettersonly: "Numbers or special characters not allowed" },
            FatherEmail: { email: "Email address is not valid" },
            MotherFirstName: { lettersonly: "Numbers or special characters not allowed" },
            MotherLastName: { lettersonly: "Numbers or special characters not allowed" },
            MotherMaiden: { lettersonly: "Numbers or special characters not allowed" },
            MotherEmail: { email: "Email address is not valid" },
            Child1FirstName: { lettersonly: "Numbers or special characters not allowed" },
            Child1MiddleInitial: { lettersonly: "Numbers or special characters not allowed" },
            Child1LastName: { lettersonly: "Numbers or special characters not allowed" },
            Child1DOB: { date: "Child's date of birth is not valid" },
            Child1Email: { email: "Email address is not valid" },
            Child1BaptismPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child1EucharistPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child1BaptismDate: { date: "Baptism date of birth is not valid" },
            Child1EucharistDate: { date: "Baptism date of birth is not valid" },

            Child2FirstName: { lettersonly: "Numbers or special characters not allowed" },
            Child2MiddleInitial: { lettersonly: "Numbers or special characters not allowed" },
            Child2LastName: { lettersonly: "Numbers or special characters not allowed" },
            Child2DOB: { date: "Child's date of birth is not valid" },
            Child2Email: { email: "Email address is not valid" },
            Child2BaptismPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child2EucharistPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child2BaptismDate: { date: "Baptism date of birth is not valid" },
            Child2EucharistDate: { date: "Baptism date of birth is not valid" },

            Child3FirstName: { lettersonly: "Numbers or special characters not allowed" },
            Child3MiddleInitial: { lettersonly: "Numbers or special characters not allowed" },
            Child3LastName: { lettersonly: "Numbers or special characters not allowed" },
            Child3DOB: { date: "Child's date of birth is not valid" },
            Child3Email: { email: "Email address is not valid" },
            Child3BaptismPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child3EucharistPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child3BaptismDate: { date: "Baptism date of birth is not valid" },
            Child3EucharistDate: { date: "Baptism date of birth is not valid" },

            Child4FirstName: { lettersonly: "Numbers or special characters not allowed" },
            Child4MiddleInitial: { lettersonly: "Numbers or special characters not allowed" },
            Child4LastName: { lettersonly: "Numbers or special characters not allowed" },
            Child4DOB: { date: "Child's date of birth is not valid" },
            Child4Email: { email: "Email address is not valid" },
            Child4BaptismPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child4EucharistPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child4BaptismDate: { date: "Baptism date of birth is not valid" },
            Child4EucharistDate: { date: "Baptism date of birth is not valid" },

            Child5FirstName: { lettersonly: "Numbers or special characters not allowed" },
            Child5MiddleInitial: { lettersonly: "Numbers or special characters not allowed" },
            Child5LastName: { lettersonly: "Numbers or special characters not allowed" },
            Child5DOB: { date: "Child's date of birth is not valid" },
            Child5Email: { email: "Email address is not valid" },
            Child5BaptismPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child5EucharistPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child5BaptismDate: { date: "Baptism date of birth is not valid" },
            Child5EucharistDate: { date: "Baptism date of birth is not valid" },

            Child6FirstName: { lettersonly: "Numbers or special characters not allowed" },
            Child6MiddleInitial: { lettersonly: "Numbers or special characters not allowed" },
            Child6LastName: { lettersonly: "Numbers or special characters not allowed" },
            Child6DOB: { date: "Child's date of birth is not valid" },
            Child6Email: { email: "Email address is not valid" },
            Child6BaptismPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child6EucharistPlace: { lettersonly: "Numbers or special characters not allowed" },
            Child6BaptismDate: { date: "Baptism date of birth is not valid" },
            Child6EucharistDate: { date: "Baptism date of birth is not valid" },

        },
        submitHandler: function (form) {
            $("#loader").modal('show');
            var form = new ReligiousEdForm();
            var returnmessage = form.SendEmail();

        }
    });
});