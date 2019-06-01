var EmailHelper = /** @class */ (function () {
    function EmailHelper() {
    }
    EmailHelper.SendEmail = function (uri, data, formtype) {
        $.getJSON(uri, data)
            .done(function (data) {
            $("#loader").modal('hide');
            var formId = "";
            var resetform;
            var $modal = $("#emailModal");
            var $modalcontent = $modal.find(".modal-content");
            $modalcontent.html(data);
            $modal.modal("show");
            setTimeout(function () {
                $modal.modal('hide');
            }, 2500);
            switch (formtype) {
                case "baptism":
                    formId = "baptismform";
                    resetform = $("#baptismform")[0];
                    resetform.reset();
                    break;
                case "funeralrequest":
                    formId = "funeralform";
                    resetform = $("#funeralform")[0];
                    resetform.reset();
                    break;
                case "funeralhomeinfo":
                    formId = "funeralhomeinfoform";
                    resetform = $("#funeralhomeinfoform")[0];
                    resetform.reset();
                    break;
                case "religioused":
                    formId = "ReligiousEd";
                    resetform = $("#ReligiousEd")[0];
                    resetform.reset();
                    break;
                case "raceforgrace":
                    formId = "raceForGrace";
                    resetform = $("#raceForGrace")[0];
                    resetform.reset();
                    break;
                default:
                    break;
            }
            return data;
        })
            .fail(function (data) {
            return data;
        });
        return "";
    };
    return EmailHelper;
}());
//# sourceMappingURL=EmailHelper.js.map