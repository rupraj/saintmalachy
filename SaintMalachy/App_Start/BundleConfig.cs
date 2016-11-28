using System.Web;
using System.Web.Optimization;

namespace SaintMalachy
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/navbar").Include(
                        "~/Scripts/navbar.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap-datepicker.js",
                "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/breadcrumb").Include(
                      "~/Scripts/TopHeaderMenu.js"));

            bundles.Add(new ScriptBundle("~/bundles/baptism").Include(
                      "~/Scripts/Baptism/BaptismForm.js", "~/Scripts/Baptism/BaptismFormInit.js"));

            bundles.Add(new ScriptBundle("~/bundles/funeral").Include(
                      "~/Scripts/Funeral/FuneralHomeInfoInit.js", "~/Scripts/Funeral/FuneralRequestForm.js", "~/Scripts/Funeral/FuneralFormInit.js", "~/Scripts/Funeral/FuneralReadingsInit.js"));

            bundles.Add(new ScriptBundle("~/bundles/religioused").Include(
                      "~/Scripts/ReligiousEd/ReligiousEd.js", "~/Scripts/ReligiousEd/ReligiousEdInit.js"));

            bundles.Add(new ScriptBundle("~/bundles/global").Include(
                      "~/Scripts/Global/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-overrides.css",
                      "~/Content/style.css",
                      //"~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/cssgreen").Include(
                "~/Content/bootstrap-datepicker.css",
                "~/Content/bootstrap-overridesGreen.css",
                      "~/Content/styleGreen.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css"));
        }
    }
}
