$(document).ready(function () {
    //$('#funeralreading').on('hidden.bs.collapse', function () {
    //    alert('hidden.bs.collapse');
    //});
    $('#funeralreading').on('hide.bs.collapse', function (e) {
        $(e.target).parent().find(".fa").removeClass("fa-minus-circle").addClass("fa-plus-circle");
    });
    $('#funeralreading').on('show.bs.collapse', function (e) {
        $(e.target).parent().find(".fa").removeClass("fa-plus-circle").addClass("fa-minus-circle");
    });
});