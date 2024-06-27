using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

public partial class root_canals_index : System.Web.UI.Page
{
    private string Body = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string name = Request.Form["txtname"].ToString();
        string email = Request.Form["txtmail"].ToString();
        string phone = Request.Form["txtphone"].ToString();
        string counrty = Request.Form["txtaddress"].ToString();
        string tourdate = Request.Form["inquiry-date-check-out"].ToString();


        string mailid = "info@dentalcarencure.com,drmansiarora@gmail.com";
        string mailidcc = "arvind@macoinfotech.com";
        //string mailidbcc = "";

        MailMessage mail = new MailMessage();
        mail.To.Add(mailid);
        mail.CC.Add(mailidcc);
        //mail.Bcc.Add(mailidbcc);

        mail.From = new MailAddress(email, name);
        mail.Subject = "Query Using Dentalcarencure.com";
        Body = "<table width=100% border=1 cellspacing=2 cellpadding=2>" +
          "<tr><td><font face=Verdana; size=2px><b>Name</b></font></td><td><font face=Verdana; size=2px>" + name + "</font></td></tr>" +
       "<tr><td><font face=Verdana; size=2px><b>Email</b></font></td><td><font face=Verdana; size=2px>" + email + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Contact No</b></font></td><td><font face=Verdana; size=2px>" + phone + "</font></td></tr>" +
          "<tr><td><font face=Verdana; size=2px><b>Address</b></font></td><td><font face=Verdana; size=2px>" + counrty + "</font></td></tr>" +
            "<tr><td><font face=Verdana; size=2px><b>Appointment Date(M/D/Y)</b></font></td><td><font face=Verdana; size=2px>" + tourdate + "</font></td></tr></table>" +

        "<a href=mailto:" + email + "><font face=Verdana; size=2px><b>Send Reply</b></font></a>";
        mail.Body = Body;
        mail.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Port = 587;
        smtp.Host = "mail.dentalcarencure.com";
        smtp.Credentials = new System.Net.NetworkCredential("mail@dentalcarencure.com", "mail@#1234");
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
        smtp1.Host = "mail.dentalcarencure.com";
        smtp1.Credentials = new System.Net.NetworkCredential("mail@dentalcarencure.com", "mail@#1234");
        smtp1.Send(mail1);
        mail1.Dispose();
        Response.Redirect("thanks.html", false);
    }



    protected void btnSubmit1_Click(object sender, EventArgs e)
    {
        string name = Request.Form["txtname1"].ToString();
        string email = Request.Form["txtmail1"].ToString();
        string phone = Request.Form["txtphone1"].ToString();
        string counrty = Request.Form["txtaddress1"].ToString();
        string msg = Request.Form["txtmsg1"].ToString();


        string mailid = "info@dentalcarencure.com,drmansiarora@gmail.com";
        string mailidcc = "arvind@macoinfotech.com";
        //string mailidbcc = "";

        MailMessage mail = new MailMessage();
        mail.To.Add(mailid);
        mail.CC.Add(mailidcc);
        //mail.Bcc.Add(mailidbcc);

        mail.From = new MailAddress(email, name);
        mail.Subject = "Query Using Dentalcarencure.com";
        Body = "<table width=100% border=1 cellspacing=2 cellpadding=2>" +
          "<tr><td><font face=Verdana; size=2px><b>Name</b></font></td><td><font face=Verdana; size=2px>" + name + "</font></td></tr>" +
       "<tr><td><font face=Verdana; size=2px><b>Email</b></font></td><td><font face=Verdana; size=2px>" + email + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Contact No</b></font></td><td><font face=Verdana; size=2px>" + phone + "</font></td></tr>" +
          "<tr><td><font face=Verdana; size=2px><b>Address</b></font></td><td><font face=Verdana; size=2px>" + counrty + "</font></td></tr>" +
            "<tr><td><font face=Verdana; size=2px><b>Message</b></font></td><td><font face=Verdana; size=2px>" + msg + "</font></td></tr></table>" +

        "<a href=mailto:" + email + "><font face=Verdana; size=2px><b>Send Reply</b></font></a>";
        mail.Body = Body;
        mail.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Port = 587;
        smtp.Host = "mail.dentalcarencure.com";
        smtp.Credentials = new System.Net.NetworkCredential("mail@dentalcarencure.com", "mail@#1234");
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
        smtp1.Host = "mail.dentalcarencure.com";
        smtp1.Credentials = new System.Net.NetworkCredential("mail@dentalcarencure.com", "mail@#1234");
        smtp1.Send(mail1);
        mail1.Dispose();
        Response.Redirect("thanks.html", false);
    }
}