﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DataNervesUI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}/{p}",
                defaults: new { id = RouteParameter.Optional, p=RouteParameter.Optional }
            );
        }
    }
}
