﻿using System;
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
                constraints: new { id = @"(?i)^i\d\d\d?(e|w)?(-(north|south|east|west|dallas|landry|fort-worth))?|us\d\d\d?(-(north|south))?|sh\d\d\d?(-(north|south|east|west|dallas|irving))?|loop\d\d|dnt|bush|chisholm-trail-parkway|spur\d\d\d$" }
            );

            routes.MapRoute(
                name: "Photo Page",
                url: "photos/{id}",
                defaults: new { controller = "Default", action = "Photos" }
            );
            
            //routes.MapRoute(
            //    name: "Aerial",
            //    url: "aerial",
            //    defaults: new { controller = "Default", action = "Aerial" }
            //);
            routes.MapRoute(
                name: "Aerial location",
                url: "aerial/{id}/{detail}",
                defaults: new { controller = "Default", action = "Aerial", id = UrlParameter.Optional,  detail = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Book",
                url: "book/{id}",
                defaults: new { controller = "Default", action = "Book" }
            );

            routes.MapRoute(
                name: "Maps",
                url: "old-highway-maps",
                defaults: new { controller = "Default", action = "Maps" }
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
