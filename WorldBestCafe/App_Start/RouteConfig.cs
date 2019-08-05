using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WorldBestCafe
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Secret",
                url: "secret/menu",
                defaults: new { controller = "Home", action = "Secret" }
            );

            routes.MapRoute(
                name: "Order",
                url: "manager/order/history",
                defaults: new { controller = "Home", action = "History" }
            );

            routes.MapRoute(
                 name: "About",
                 url: "About",
                 defaults: new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
