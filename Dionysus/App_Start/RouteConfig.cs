using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dionysus
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //想忽略的副檔名
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ico/{*pathInfo}");

            //加上這行可以強制 url 小寫
            routes.LowercaseUrls = true;

            routes.MapRoute(
                name: "Cocktail",
                url: "Cocktail",
                defaults: new { controller = "Cocktail", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Beer",
                url: "Beer",
                defaults: new { controller = "Beer", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "About",
                url: "About",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contact",
                url: "Contact",
                defaults: new { Controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
