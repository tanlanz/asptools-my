<%@ WebHandler Language="C#" Class="login" %>

using System;
using System.Web;
using BLL;

public class login : IHttpHandler,System.Web.SessionState.IRequiresSessionState {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
            //登陆
        if (context.Request["type1"] == "1")
        {
            string username = context.Request["uname"];
            string pwd = context.Request["pwd"];
            string ret = new LoginBLL().Login(username, pwd);
            if (ret == "succ1" || ret == "succ2")
            {
                context.Session["ACCOUNT"]= username;
            }
            context.Response.Write(ret);
        }
        else if(context.Request["type1"] == "0")
        {
                context.Session.Remove("ACCOUNT");
                context.Response.Write("signout");
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}