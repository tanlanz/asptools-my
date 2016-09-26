<%@ WebHandler Language="C#" Class="loginCheck" %>

using System;
using System.Web;
using BLL;

public class loginCheck : IHttpHandler, System.Web.SessionState.IRequiresSessionState {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
            //检查登陆情况

        if (context.Session["ACCOUNT"] != null)
        {
            context.Response.Write(new LoginBLL().Check_Login(context.Session["ACCOUNT"].ToString()));
        }
        else context.Response.Write("nologi");
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}