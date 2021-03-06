﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Zoopla.SendEmails
{
   public static class SendMail
    {
        public static void Send_Report_In_Mail()
        {// sending mail
            MailMessage mail = new MailMessage();//creating object for mail message
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");//smtp protocol
            mail.From = new MailAddress("pallavidubey6232@gmail.com");//sendder mail id
            mail.To.Add("rebelpallavi786@gmail.com");//reciver mail id

            StringBuilder TimeAndDate = new StringBuilder(DateTime.Now.ToString());//to fetch the date for adding the date and time to add the mail
            TimeAndDate.Replace("/", "_");
            TimeAndDate.Replace(":", "_");

            mail.Subject = "Automation Test Report_" + TimeAndDate;

            mail.Body = "Please find the attached report to get details.”";

            var mostRecentlyModified = Directory.GetFiles(@"C:\Users\rebel\source\repos\Zoopla\Zoopla\ ExtentReport", "*.html")
            .Select(f => new FileInfo(f))
            .OrderByDescending(fi => fi.LastWriteTime)
            .First()
            .FullName;

            Attachment attachment;
            attachment = new Attachment(mostRecentlyModified);
            mail.Attachments.Add(attachment);
            //credential details
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("pallavidubey6232@gmail.com", "12respect34");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);

        }
    }
}
