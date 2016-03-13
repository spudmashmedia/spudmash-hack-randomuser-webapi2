﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Autofac;
using IO.Swagger.Api;

namespace RandomUserService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services


            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
