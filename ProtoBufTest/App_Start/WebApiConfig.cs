﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiContrib.Formatting;

namespace ProtoBufTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            config.Formatters.Add(new ProtoBufFormatter());
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
