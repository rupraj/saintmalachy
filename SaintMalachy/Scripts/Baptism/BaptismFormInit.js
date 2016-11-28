$(document).ready(function () {

    var validator = $("#baptismform").validate({
        rules: {
            BaptismDate: { required: true },
            ChildLastName: { required: true, lettersonly:true },
            ChildName: { required: true, lettersonly: true },
            ChildDateOfBirth: { required: true, date: true },
            ChildPlaceOfBirth: { required: true, lettersonly: true },
            FatherFullName: { required: true, lettersonly: true },
            MotherFirstName: { required: true, lettersonly: true },
            MotherMaidenName: { required: true, lettersonly: true },
            Address: { required: true },
            CityState: { required: true, lettersonly: true },
            Phone: { required: true, phoneUS: true },
            Email: { required: true, email: true },
            GodfatherName: { lettersonly: true },
            GodfatherReligion: { lettersonly: true },
            GodmotherName: { lettersonly: true },
            GodmotherReligion: { lettersonly: true }
        },
        messages: {
            BaptismDate: { BaptismDate: "Baptism Date is required" },
            ChildLastName: { required: "Child last name is required", lettersonly:"Numbers or special characters not allowed" },
            ChildName: { required: "Child name is required", lettersonly: "Numbers or special characters not allowed" },
            ChildDateOfBirth: { required: "Child DOB is required", date: "Date of birth is not valid" },
            ChildPlaceOfBirth: { required: "Place of birth is required", lettersonly: "Numbers or special characters not allowed" },
            FatherFullName: { required: "Father's full name is required", lettersonly: "Numbers or special characters not allowed" },
            MotherFirstName: { required: "Mother's first name is required", lettersonly: "Numbers or special characters not allowed" },
            MotherMaidenName: { required: "Mother's maiden name is required", lettersonly: "Numbers or special characters not allowed" },
            Address: { required: "Address is required" },
            CityState: { required: "City and State is required" },
            Phone: { required: "Phone number is required", phoneUS: "Phone number is not valid" },
            Email: { required: "Email address is required", email: "Email address is not valid" },
            GodfatherName: { lettersonly: "Numbers or special characters not allowed" },
            GodfatherReligion: { lettersonly: "Numbers or special characters not allowed" },
            GodmotherName: { lettersonly: "Numbers or special characters not allowed" },
            GodmotherReligion: { lettersonly: "Numbers or special characters not allowed" }

        },
        submitHandler: function (form) {
            $("#loader").modal('show');
            var form = new BaptismForm();
            var returnmessage = form.SendEmail();
            
        }
    });
    $("#ChildDateOfBirth").datepicker();

    $("#BaptismDate").click(function () {
        $("#baptismdateModal").modal();
    });

    $("#baptismdateModal").on("click", "a", function () {
        $("#BaptismDate").val($(this).text());
        var baptismDinner = $("#baptismdateModal p[data-target='" + $(this).attr('id') + "']").text();
        $("#DinnerDate").val(baptismDinner);
        $("#baptismdateModal").modal("hide");
    });

    $("input:radio[name='parMarried']").on("change", function (item) {
        if($(item.currentTarget).val() == "No")
        {
            $("#parChurchMarriage").hide();
        }
        else
        {
            $("#parChurchMarriage").show();
        }
    })

});