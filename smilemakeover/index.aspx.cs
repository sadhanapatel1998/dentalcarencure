using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class index : System.Web.UI.Page
{
    private string Body = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_send_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtname.Text.Trim();
            string email = txtmail.Text.Trim();
            string phone = txtphone.Text.Trim();
            string msg = txtmsg.Text.Trim();
            string sub = "Enquiry";
            sendcontactmail(name, email, phone, sub, msg);

            clr();
            divsuccess.Attributes.Add("style", "display:block");
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "", "<script type='text/javascript'>setTimeout(function () {document.getElementById('divsuccess').style.display = 'none';}, 3000);</script>", false);
        }
        catch (Exception ex)
        {
            string abc = ex.Message;
            string st = abc.Replace(",", "").ToString();
            st = "Error : " + st.Replace("'", "").ToString();
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "", "<script type='text/javascript'>alert('" + st + "'+'\\nPlease contact to Website Administrator. !');</script>", false);
        }

    }
    private void clr()
    {
        txtname.Text = string.Empty;
        txtmail.Text = string.Empty;
        txtphone.Text = string.Empty;
        txtmsg.Text = string.Empty;

    }
    public void sendcontactmail(string name, string email, string phone, string sub, string enqr)
    {
        string mailid = "drmansiarora@gmail.com";
        string mailidbcc = "seo@macoinfotech.com";

        MailMessage mail = new MailMessage();
        mail.To.Add(mailid);
        mail.Bcc.Add(mailidbcc);

        mail.From = new MailAddress(email, name);
        mail.Subject = sub;
        Body = "<table width=100% border=1 cellspacing=2 cellpadding=2>" +
          "<tr><td><font face=Verdana; size=2px><b>Name</b></font></td><td><font face=Verdana; size=2px>" + name + "</font></td></tr>" +
       "<tr><td><font face=Verdana; size=2px><b>Email</b></font></td><td><font face=Verdana; size=2px>" + email + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Contact No</b></font></td><td><font face=Verdana; size=2px>" + phone + "</font></td></tr>" +
         "<tr><td><font face=Verdana; size=2px><b>Message</b></font></td><td><font face=Verdana; size=2px>" + enqr + "</font></td></tr></table>" +
        "<a href=mailto:" + email + "><font face=Verdana; size=2px><b>Send Reply</b></font></a>";
        mail.Body = Body;
        mail.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Port = 587;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.EnableSsl = true;
        smtp.Host = "smtp.gmail.com";
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
        smtp1.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp1.EnableSsl = true;
        smtp1.Host = "smtp.gmail.com";
        smtp1.Credentials = new System.Net.NetworkCredential("enquiry@macoinfotech.com", "maco@2020");
        smtp1.Send(mail1);
        mail1.Dispose();


        HttpContext.Current.Response.Redirect("thanks.html", false);

    }
}