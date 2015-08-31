﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                            "Action",
                            "{action}",
                            new { controller = "Blog", action = "Posts" }
                          );

            routes.MapRoute(
                            "Category",
                            "category/{category}",
                            new { controller = "Blog", action = "Category" }
                          );

            routes.MapRoute(
                    "Tag",
                    "tag/{tag}",
                    new {controller="Blog", action="Tag" }
                );
        }
    }
}
