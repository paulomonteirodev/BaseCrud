using System.Web;
using System.Web.Optimization;

namespace WebApiAngular
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/angularControllers").Include(
                        "~/App/controllers/*.js"));

            bundles.Add(new ScriptBundle("~/angularServices").Include(
                        "~/App/services/*.js"));

            bundles.Add(new ScriptBundle("~/angularDirectives").Include(
                        "~/App/directives/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/js/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/style.css"));
        }
    }
}
