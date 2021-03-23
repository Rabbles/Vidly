using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //order of routes is important
            routes.MapRoute("FilmsByReleaseDate", "films/released/{month}/{year}",
                new { controller = "Films", action = "ByReleaseDate" },
                new {month = @"\d{2}", year = @"\d{4}" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
