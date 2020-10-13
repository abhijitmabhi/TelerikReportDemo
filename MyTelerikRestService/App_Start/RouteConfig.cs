using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
//using Microsoft.AspNet.FriendlyUrls;

namespace MyTelerikRestService
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
