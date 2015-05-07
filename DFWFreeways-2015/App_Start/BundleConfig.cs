using System.Web;
using System.Web.Optimization;

namespace DFWFreeways_2015
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-tiles").Include(
            "~/Scripts/jquery-{version}.js",
            "~/Script/tiled.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/scss/home.css",
                      "~/scss/tile.css"
                      //,"~/Content/bootstrap.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/css-home").Include(
          "~/scss/home.css"
          //,
          //"~/scss/tile.css"
                //,"~/Content/bootstrap.css"
          ));
            bundles.Add(new StyleBundle("~/Content/css-gallery").Include(
                "~/scss/tile.css"
                //,
                //"~/scss/tile.css"
                //,"~/Content/bootstrap.css"
          ));
            bundles.Add(new StyleBundle("~/Content/css-freeway").Include(
                "~/Content/bootstrap.css",
                "~/scss/freeway.css"
                ));

            bundles.Add(new StyleBundle("~/Content/css_imageDisplay").Include(
            "~/scss/imageDisplay.css"
            ));

            bundles.Add(new StyleBundle("~/Content/css-book").Include(
            "~/scss/book.css"
            ));
        }
    }
}
