using Microsoft.Extensions.Configuration;
using Model.Entities;
using Model.Logs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controller
{
    public class MailController
    {
        protected SmtpClient smtpClient;
        protected string Email { get; set; }
        protected string Subject { get; set; }
        protected string Body { get; set; }
        protected string[] FileSend { get; set; }
        protected IConfigurationRoot config;


        public MailController(string email, string subject, string body, string[] file)
        {
            Email = email;
            Subject = subject;
            FileSend = file;
            Body = body;
            Initialize();
        }
        public MailController(Mail mail)
        {
            Email = mail.Email;
            Subject = mail.Subject;
            Body = mail.Body;
            FileSend = mail.File;

            Initialize();
        }

        public MailController()
        {
            Initialize();
        }

        public void Initialize()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            config = builder.Build();

            smtpClient = new SmtpClient()
            {
                Port = int.Parse(config["Smtp:Port"]),
                Credentials = new NetworkCredential(config["Smtp:Username"], config["Smtp:Password"]),
                EnableSsl = true,
                Host = config["Smtp:Host"],
            };

        }

        public async Task<bool> SentEmail()
        {
            bool Comp = false;
            MailMessage mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(config["Smtp:Username"]);
                mailMessage.To.Add(Email);
                mailMessage.Subject = Subject;
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = Body;
                mailMessage.Priority = MailPriority.Normal;
                if (FileSend != null)
                {
                    for (int i = 0; i < FileSend.Length; i++)
                    {
                        mailMessage.Attachments.Add(new Attachment(FileSend[i]));
                    }
                   
                }
                var Status = Task.Run(() => smtpClient.Send(mailMessage));
                await Status;
                if (Status.IsCompleted)
                {
                    Comp = true;
                }
                             
            }
            catch (Exception ex)
            {
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex, MethodBase.GetCurrentMethod());
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();

            }
            return Comp;
        }

    }
}
