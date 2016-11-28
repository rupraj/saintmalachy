class EmailHelper {
    public static SendEmail(uri: string, data: string, formtype: string): string {
        $.getJSON(uri, data)
            .done(function (data) {
                $("#loader").modal('hide');
                let formId = ""
                let resetform: HTMLFormElement
                let $modal = $("#emailModal")
                let $modalcontent = $modal.find(".modal-content")
                $modalcontent.html(data);
                $modal.modal("show");
                setTimeout(function () {
                   $modal.modal('hide')
                }, 2500);
                switch (formtype)
                {
                    case "baptism":
                        formId = "baptismform";
                        resetform = <HTMLFormElement>$("#baptismform")[0];
                        resetform.reset();
                        break;
                    case "funeralrequest":
                        formId = "funeralform";
                        resetform = <HTMLFormElement>$("#funeralform")[0];
                        resetform.reset();
                        break;
                    case "funeralhomeinfo":
                        formId = "funeralhomeinfoform";
                        resetform = <HTMLFormElement>$("#funeralhomeinfoform")[0];
                        resetform.reset();
                        break;
                    case "religioused":
                        formId = "ReligiousEd";
                        resetform = <HTMLFormElement>$("#ReligiousEd")[0];
                        resetform.reset();
                        break;
                    default:
                        break;
                }
                
                return data;
            })
            .fail(function (data) {
                return data;
            })
        return "";
    }
}
