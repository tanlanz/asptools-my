<%@ WebHandler Language="C#" Class="report" %>

using System;
using System.Web;
using BLL;

public class report : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
            //消息，首页当中的建议等的保存（显示没有做）
        if (context.Request.Params.Count > 0)
        {                
            string ip = context.Request["ip2"];
            string email = context.Request["email"];
            string name = context.Request["name"];
            string message = context.Request["message"];
            if(email!="" && name != "" && message != "")
            {
                context.Response.Write(new adminBLL().save(email, name, message,ip));
            }
            else {
                context.Response.Redirect("../index.html");
            }
        }
        else
        {
            context.Response.Redirect("../index.html");
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}