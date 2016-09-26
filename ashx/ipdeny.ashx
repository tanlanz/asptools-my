<%@ WebHandler Language="C#" Class="ipdeny" %>

using System;
using System.Web;
using BLL;

public class ipdeny : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
            //显示ip的访问限制情况
        if(context.Request.Params.Count > 0) {
            string ip = context.Request["ip"];
            int state = Convert.ToInt32(context.Request["stype"]);
                LoginBLL lb = new LoginBLL();
            if (state == 0)
            {
                context.Response.Write(lb.ipdeny(ip));
            }
            else if(state == 1)
            {
                context.Response.Write(lb.ipcheck(ip));
            }
            else if(state == 2)
            {
                context.Response.Write(lb.ipmanage(ip));
            }
            else if(state == 3)
            {
                int id = Convert.ToInt32(context.Request["ipid"]);
                int st =Convert.ToInt32(context.Request["ipstate"]);
                context.Response.Write(lb.ipmanage(id,st));
            }
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}