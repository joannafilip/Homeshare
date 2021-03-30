using System.Web;
using System.Web.Optimization;

namespace Homeshare
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/owl-carousel/js").Include(
                     "~/owl-carousel/owl.carousel.js"));

            bundles.Add(new ScriptBundle("~/slitslider/js").Include(
                "~/slitslider/js/modernizr.custom.79639.js",
                "~/slitslider/js/jquery.ba-cond.min.js",
                "~/slitslider/js/jquery.slitslider.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/css/style.css"));

            bundles.Add(new StyleBundle("~/owl-carousel").Include(
                    "~/owl-carousel/owl.carousel.css",
                    "~/owl-carousel/owl.theme.css"));

            bundles.Add(new StyleBundle("~/slitslider/css").Include(
                    "~/slitslider/css/style.css",
                    "~/slitslider/css/custom.css"));
            bundles.Add(new StyleBundle("~/Content/profil").Include(
                    "~/css/styleProfil.css"));

        }
    }
}
