using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace BusinessRulesEngine
{
    public class NotificationManager : INotifier
    {
        //SMTP: Send email 
        public void SendEmail(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("noreply@gmail.com");
                message.To.Add(new MailAddress("noreply@gmail.com"));
                message.Subject = "Membership:: Alert!";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("FromAddress", "Password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex) 
            {
                //Console.WriteLine(ex.Message);
            } 
        }
    }
}
