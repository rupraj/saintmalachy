var UrlConstants = (function () {
    function UrlConstants() {
    }
    Object.defineProperty(UrlConstants, "URL", {
        get: function () {
            return this._url;
        },
        set: function (uri) {
            this._url = uri;
        },
        enumerable: true,
        configurable: true
    });
    UrlConstants._url = "";
    return UrlConstants;
}());
//# sourceMappingURL=GlobalConstants.js.map