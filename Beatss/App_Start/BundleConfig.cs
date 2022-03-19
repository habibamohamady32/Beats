using System.Web;
using System.Web.Optimization;

namespace Beatss
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/SignJS").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/sign.js"));
            bundles.Add(new ScriptBundle("~/bundles/LogJS").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/log.js"));
            bundles.Add(new ScriptBundle("~/bundles/HomeJS").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/home.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/indexCss").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/index.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/AboutCss").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css",
                     "~/Content/about.css"
                     ));
            bundles.Add(new StyleBundle("~/Content/SignCss").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css",
                     "~/Content/sign.css"
                     ));
            bundles.Add(new StyleBundle("~/Content/LogCss").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/log.css"
                    ));
            bundles.Add(new StyleBundle("~/Content/HomeCss").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/home.css"
                    ));
            bundles.Add(new StyleBundle("~/Content/SongsCss").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/song.css"
                    ));

            bundles.Add(new StyleBundle("~/Content/ArtistsCss").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/site.css",
                        "~/Content/trend.css"
                        ));
            bundles.Add(new StyleBundle("~/Content/LikeCss").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/site.css",
                       "~/Content/like.css"
                       ));
            bundles.Add(new StyleBundle("~/Content/AlbumCss").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/album.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/ProfileCss").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Profile.css"
                      ));
        }
    }
}
