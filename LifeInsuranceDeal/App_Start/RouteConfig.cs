using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LifeInsuranceDeal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "CoverLife",
              url: "coverlife",
              defaults: new { controller = "Home", action = "coverlife", id = UrlParameter.Optional }
          );

            routes.MapRoute(
             name: "Assurance",
             url: "assurance",
             defaults: new { controller = "Home", action = "assurance", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                        name: "LifeForFamily",
                        url: "lifeforfamily",
                        defaults: new { controller = "Home", action = "lifeforfamily", id = UrlParameter.Optional }
                    );

            routes.MapRoute(
                        name: "insurancecalculator",
                        url: "insurancecalculator",
                        defaults: new { controller = "Home", action = "insurancecalculator", id = UrlParameter.Optional }
                    ); routes.MapRoute(
                         name: "wholelife",
                         url: "wholelife",
                         defaults: new { controller = "Home", action = "wholelife", id = UrlParameter.Optional }
                     ); routes.MapRoute(
                         name: "termlife",
                         url: "termlife",
                         defaults: new { controller = "Home", action = "termlife", id = UrlParameter.Optional }
                     );
            routes.MapRoute(
                        name: "lifeover50",
                        url: "lifeover50",
                        defaults: new { controller = "Home", action = "lifeover50", id = UrlParameter.Optional }
                    ); routes.MapRoute(
                         name: "criticalillness",
                         url: "criticalillness",
                         defaults: new { controller = "Home", action = "criticalillness", id = UrlParameter.Optional }
                     );
            routes.MapRoute(
                        name: "mortgagelife",
                        url: "mortgagelife",
                        defaults: new { controller = "Home", action = "mortgagelife", id = UrlParameter.Optional }
                    );
            routes.MapRoute(
                        name: "applicationform",
                        url: "application-form",
                        defaults: new { controller = "form", action = "index", id = UrlParameter.Optional }
                    );
            routes.MapRoute(
                         name: "Home",
                         url: "home",
                         defaults: new { controller = "Home", action = "index", id = UrlParameter.Optional }
                     );
            routes.MapRoute(
                        name: "contactus",
                        url: "contact-us",
                        defaults: new { controller = "Home", action = "contactus", id = UrlParameter.Optional }
                    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
