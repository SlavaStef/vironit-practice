using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Task4_2
{
    public class Global : System.Web.HttpApplication
    {
        public static int requestCounter;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
                
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            requestCounter++;
        }
    }
}