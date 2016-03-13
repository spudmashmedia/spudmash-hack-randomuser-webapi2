using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace RandomUserService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DIBootstrap.Register();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
