using Newtonsoft.Json.Linq;
using Shared;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;


/// <summary>
/// DO NOT USE THIS
/// NOT WORKING
/// </summary>
public class EmailSender
{
    private string smtpServer;
    private int smtpPort;
    private string emailUsername;
    private string emailPassword;

    public EmailSender(LocalFileReader localFileReader)
    {
        emailUsername = localFileReader.GetValue<string>("email-username");
        emailPassword = localFileReader.GetValue<string>("email-password");
    }

    //private void LoadConfiguration(LocalFileReader localFileReader)
    //{
    //    try
    //    {
    //        var json = File.ReadAllText(configFilePath);
    //        var config = JObject.Parse(json);

    //        smtpServer = "smtp.gmail.com"; // Gmail SMTP server
    //        smtpPort = 587; // Gmail SMTP port
    //        emailUsername = config["email-username"].ToString();
    //        emailPassword = config["email-password"].ToString();
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("Error loading configuration: " + ex.Message);
    //    }
    //}

    public void SendEmail(string toEmail, string subject, string body)
    {
        try
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(emailUsername);
            mail.To.Add(toEmail);
            mail.Subject = subject;
            mail.Body = body;

            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            smtpClient.Credentials = new NetworkCredential(emailUsername, emailPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
            Console.WriteLine("Email sent successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error sending email: " + ex.Message);
        }
    }
}