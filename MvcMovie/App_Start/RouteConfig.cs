using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            // The URL is similar to a command line,
            // where controller is the command and action, name, id and so on are parameters.
            // The syntax of the command line is given by the routes.MapRoute
            routes.MapRoute(
                name: "Hello",
                url: "{controller}/{action}/{name}/{id}"
            );
        }
    }
}
