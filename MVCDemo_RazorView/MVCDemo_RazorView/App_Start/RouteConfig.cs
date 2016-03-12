using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDemo_RazorView
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // http://localhost/scriptresource.axd/foo
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Default",                                                                    // Route Name
            url: "{controller}/{action}/{id}",                                                  // URL With Parameters
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } //Parameter defaults
             );
            // http://localhost/Process/
            routes.MapRoute(
                name: "Process",                                                                    // Route Name
                url: "{controller}/{action}/{id}",                                                  // URL With Parameters
                defaults: new { controller = "Process", action = "List", id = "" } //Parameter defaults
                );


        }
    }
}
