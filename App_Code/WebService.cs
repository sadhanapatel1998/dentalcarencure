using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Mail;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    public string Body = string.Empty;
    public string result = string.Empty;
    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string BookAppontment(string name, string email, string phone, string bdate, string msg)
    {

        string mailid = "info@dentalcarencure.com,drmansiarora@gmail.com";
        string mailidbcc = "seo@macoinfotech.com";

        MailMessage mail = new MailMessage();
        mail.To.Add(mailid);
        mail.Bcc.Add(mailidbcc);

        mail.From = new MailAddress(email, name);
        mail.Subject = "Query Using wesite for an Appointment !";
        Body = "<table width=100% border=1 cellspacing=2 cellpadding=2>" +
          "<tr><td><font face=Verdana; size=2px><b>Name</b></font></td><td><font face=Verdana; size=2px>" + name + "</font></td></tr>" +
       "<tr><td><font face=Verdana; size=2px><b>Email</b></font></td><td><font face=Verdana; size=2px>" + email + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Contact No.</b></font></td><td><font face=Verdana; size=2px>" + phone + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Appointment Date</b></font></td><td><font face=Verdana; size=2px>" + bdate + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Message</b></font></td><td><font face=Verdana; size=2px>" + msg + "</font></td></tr></table>" +
        "<a href=mailto:" + email + "><font face=Verdana; size=2px><b>Send Reply</b></font></a>";
        mail.Body = Body;
        mail.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Port = 587;
        smtp.Host = "smtp.gmail.com";
        smtp.EnableSsl = true;
        smtp.Credentials = new System.Net.NetworkCredential("enquiry@macoinfotech.com", "maco@2020");
        smtp.Send(mail);
        mail.Dispose();
        MailMessage mail1 = new MailMessage();
        mail1.To.Add(email);
        mail1.From = new MailAddress("enquiry@macoinfotech.com", "Dental Care N Cure");
        mail1.Subject = "Acknowledgement to your enquiry on Dental Care N Cure";
        Body = "Thank you very much for your query will get back to you soon.";
        mail1.Body = Body;
        SmtpClient smtp1 = new SmtpClient();
        smtp1.Port = 587;
        mail1.IsBodyHtml = true;
        smtp1.Host = "smtp.gmail.com";
        smtp1.EnableSsl = true;
        smtp1.Credentials = new System.Net.NetworkCredential("enquiry@macoinfotech.com", "maco@2020");
        smtp1.Send(mail1);
        mail1.Dispose();
        result = "Mail Send Successfully !";
        return result;
    }
    [WebMethod]
    public string SendQuickContact(string name, string email, string phone, string query)
    {

        string mailid = "info@dentalcarencure.com,drmansiarora@gmail.com";
        string mailidbcc = "seo@macoinfotech.com";

        MailMessage mail = new MailMessage();
        mail.To.Add(mailid);
        mail.Bcc.Add(mailidbcc);

        mail.From = new MailAddress(email, name);
        mail.Subject = "Query Using wesite for Quick Contact !";
        Body = "<table width=100% border=1 cellspacing=2 cellpadding=2>" +
          "<tr><td><font face=Verdana; size=2px><b>Name</b></font></td><td><font face=Verdana; size=2px>" + name + "</font></td></tr>" +
       "<tr><td><font face=Verdana; size=2px><b>Email</b></font></td><td><font face=Verdana; size=2px>" + email + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Contact No.</b></font></td><td><font face=Verdana; size=2px>" + phone + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Message</b></font></td><td><font face=Verdana; size=2px>" + query + "</font></td></tr></table>" +
        "<a href=mailto:" + email + "><font face=Verdana; size=2px><b>Send Reply</b></font></a>";
        mail.Body = Body;
        mail.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Port = 587;
        smtp.Host = "smtp.gmail.com";
        smtp.Credentials = new System.Net.NetworkCredential("enquiry@macoinfotech.com", "maco@2020");
        smtp.Send(mail);
        mail.Dispose();
        MailMessage mail1 = new MailMessage();
        mail1.To.Add(email);
        mail1.From = new MailAddress("mail@dentalcarencure.com", "Dentalcarencure.com");
        mail1.Subject = "Acknowledgement to your enquiry on Dentalcarencure.com";
        Body = "Thank you very much for your query will get back to you soon.";
        mail1.Body = Body;
        SmtpClient smtp1 = new SmtpClient();
        smtp1.Port = 587;
        mail1.IsBodyHtml = true;
        smtp1.Host = "smtp.gmail.com";
        smtp1.Credentials = new System.Net.NetworkCredential("enquiry@macoinfotech.com", "maco@2020");
        smtp1.Send(mail1);
        mail1.Dispose();
        result = "Mail Send Successfully !";
        return result;
    }

    [WebMethod]
    public string SendLandingPageQuery(string name, string email, string phone, string apptDate, string adrs, string query)
    {

        string mailid = "info@dentalcarencure.com,drmansiarora@gmail.com";
        string mailidbcc = "seo@macoinfotech.com";

        MailMessage mail = new MailMessage();
        mail.To.Add(mailid);
        mail.Bcc.Add(mailidbcc);

        mail.From = new MailAddress(email, name);
        mail.Subject = "Query Using Dentalcarencure.com";
        Body = "<table width=100% border=1 cellspacing=2 cellpadding=2>" +
          "<tr><td><font face=Verdana; size=2px><b>Name</b></font></td><td><font face=Verdana; size=2px>" + name + "</font></td></tr>" +
       "<tr><td><font face=Verdana; size=2px><b>Email</b></font></td><td><font face=Verdana; size=2px>" + email + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Contact No.</b></font></td><td><font face=Verdana; size=2px>" + phone + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Appointment Date</b></font></td><td><font face=Verdana; size=2px>" + apptDate + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Address</b></font></td><td><font face=Verdana; size=2px>" + adrs + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Query</b></font></td><td><font face=Verdana; size=2px>" + query + "</font></td></tr></table>" +
        "<a href=mailto:" + email + "><font face=Verdana; size=2px><b>Send Reply</b></font></a>";
        mail.Body = Body;
        mail.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Port = 587;
        smtp.Host = "smtp.gmail.com";
        smtp.Credentials = new System.Net.NetworkCredential("enquiry@macoinfotech.com", "maco@2020");
        smtp.Send(mail);
        mail.Dispose();
        MailMessage mail1 = new MailMessage();
        mail1.To.Add(email);
        mail1.From = new MailAddress("info@dentalcarencure.com", "Dentalcarencure.com");
        mail1.Subject = "Acknowledgement to your enquiry on Dentalcarencure.com";
        Body = "Thank you very much for your query will get back to you soon.";
        mail1.Body = Body;
        SmtpClient smtp1 = new SmtpClient();
        smtp1.Port = 587;
        mail1.IsBodyHtml = true;
        smtp1.Host = "smtp.gmail.com";
        smtp1.Credentials = new System.Net.NetworkCredential("enquiry@macoinfotech.com", "maco@2020");
        smtp1.Send(mail1);
        mail1.Dispose();
        result = "Mail Send Successfully !";
        return result;
    }
}