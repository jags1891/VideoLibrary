﻿using System.Web.Mvc;
using System.Web.Routing;

namespace VideoLibrary
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

       

            routes.MapRoute(
                "MovieByReleaseDate",
                "movies/released/{year}/{month}",
                new {Controller = "Movies", action  ="ByReleaseDate"},
                new { year = @"\d{4}", month = @"\d{2}" }
                //new { year = @"2015|2016", month = @"\d{2}" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
