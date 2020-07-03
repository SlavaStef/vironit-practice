using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using Task4_1.ErrorHandling;

namespace Task4_1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Error(object sender, EventArgs e)
        {            
            Exception exception = Server.GetLastError();

            Task4_1.ErrorHandling.ErrorHandling.SendEmail(exception);
            Response.Redirect("ErrorPage.html");
        }
    }
}