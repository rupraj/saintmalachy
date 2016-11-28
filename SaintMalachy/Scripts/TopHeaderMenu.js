$("#TopHeaderLinks li").on("click", function (e) {
    $(e.currentTarget.parentNode.children).find("a").removeClass("breadcrumbclick");
    $(e.currentTarget).find("a").addClass("breadcrumbclick");
});