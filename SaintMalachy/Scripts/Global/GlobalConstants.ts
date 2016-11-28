class UrlConstants {
    private static _url: string = ""
    public static get URL(): string {
        return this._url
    }
    public static set URL(uri: string) {
        this._url = uri
    }
}