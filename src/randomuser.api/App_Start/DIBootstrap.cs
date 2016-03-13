using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.WebApi;
using IO.Swagger.Api;
using System.Web.Http;
using RandomUserService.Controllers;

namespace RandomUserService
{
    public class DIBootstrap
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();

            //register randomuserclient
            builder.RegisterType<DefaultApi>().As<IDefaultApi>();
            builder.RegisterApiControllers(typeof(RandomUserController).Assembly);

            IContainer container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            return container;
        }
    }
}