using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace LifeInsuranceDeal.App_Start
{
    public class BundelConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.ResetAll();
            // create an object of ScriptBundle and 
            // specify bundle name (as virtual path) as constructor parameter 
            ScriptBundle scriptJs = new ScriptBundle("~/bundles/js");
            StyleBundle styleCss = new StyleBundle("~/content/css/bundles");

            //use Include() method to add all the script files with their paths 
            scriptJs.Include(
                                "~/content/js/jquery-1.11.1.min.js",
                                "~/content/js/bootstrap.min.js",
                                "~/content/js/jquery.validate.min.js",
                                "~/content/js/myscript.js"
                              );

            styleCss.Include(
                "~/content/css/bootstrap.min.css",
                "~/content/css/bootstrap-theme.min.css",
                 "~/content/css/style_sheet.css",
                 "~/content/css/responsive.css",
                 "~/content/css/font-awesome.min.css"
                 );

            ////Add the bundle into BundleCollection

            bundles.Add(styleCss);
            bundles.Add(scriptJs);


            BundleTable.EnableOptimizations = true;
        }
    }
}
