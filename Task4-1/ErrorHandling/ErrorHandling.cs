using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Task4_1.ErrorHandling
{
    public static class ErrorHandling
    {
        public static void SendEmail(Exception exception)
        {
            MailAddress senderEmail = new MailAddress("EMAILNAME@gmail.com", "Tech Support");
            MailAddress receiverEmail = new MailAddress("EMAILNAME@gmail.com", "Receiver");
            string password = "PASSWORD";
            string sub = "Error";
            string body = exception.ToString();
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };
            MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = sub,
                Body = body
            };

            smtp.Send(message);
        }
    }
}