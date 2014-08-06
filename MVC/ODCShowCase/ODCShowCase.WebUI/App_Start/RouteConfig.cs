using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ODCShowCase.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: null,
               url: "{controller}/Page{page}",
               defaults: new { controller = "Home", action = "Index"}
           );

            routes.MapRoute(
               name: null,
               url: "{controller}", ///{currentController}
               defaults: new { controller = "Home", action = "Index" } //, currentController = UrlParameter.Optional
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}