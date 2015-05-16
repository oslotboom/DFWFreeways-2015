using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DFWFreeways_2015
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Sample test",
            //    url: "{id}",
            //    defaults: new { controller = "Default", action = "Index", id = "sample-1" }
            //);

            routes.MapRoute(
                name: "Freeway Page",
                url: "{id}/{detail}",
                defaults: new { controller = "Default", action = "Freeway", detail = UrlParameter.Optional },
                constraints: new { id = @"(?i)^i\d\d\d?(e|w)?(-(north|south|east|west|dallas|landry))?|us\d\d\d?|sh\d\d\d?(-(north|south|east|west|dallas|irving))?|loop\d\d\|dallas-north-tollway|bush|chisholm-trail-parkway$" }
            );


            //routes.MapRoute(
            //    name: "Aerial",
            //    url: "aerial",
            //    defaults: new { controller = "Default", action = "Aerial" }
            //);
            routes.MapRoute(
                name: "Aerial location",
                url: "aerial/{id}/{detail}",
                defaults: new { controller = "Default", action = "Aerial"  }
            );

            routes.MapRoute(
                name: "Book",
                url: "book/{id}",
                defaults: new { controller = "Default", action = "Book" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Default", action = "Index" }
            );

            routes.MapRoute(
                "NotFound",
                "{*url}",
                new { controller = "Default", action = "PageNotFound" }
            );


        }
    }
}
