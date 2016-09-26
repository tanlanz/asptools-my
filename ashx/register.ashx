<%@ WebHandler Language="C#" Class="register" %>

using System;
using System.Web;
using BLL;

public class register : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
            //简单的注册
        if (context.Request["type1"] == "1")
        {
            string name = context.Request["uname"];
            string username = context.Request["username"];
            string pwd = context.Request["pwd"];
            string ip = context.Request["ip2"];
            string ret = new LoginBLL().Register(name,username, pwd,ip);
            context.Response.Write(ret);
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}