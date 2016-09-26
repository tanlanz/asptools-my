<%@ WebHandler Language="C#" Class="load" %>

using System;
using System.Web;
using BLL;

public class load : IHttpHandler, System.Web.SessionState.IRequiresSessionState {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        if (context.Request.Params.Count > 0)
        {
            int typ = Convert.ToInt32(context.Request.Params["type"]);
            if (typ == 1)
            {
                context.Response.Write(new ShowBLL().load());
            }else
            if (context.Session["ACCOUNT"] != null)
            {
                if (typ == 0)
                {
                    context.Response.Write(new ShowBLL().adminload());
                }
                else if (typ == 2)
                {
                    string s2 = context.Request.Params["s2"];
                    string t2 = context.Request.Params["t2"];
                    string id = context.Request.Params["id"];
                    context.Response.Write(new ShowBLL().saveload(s2, t2, id));
                }
                else if (typ == 3)
                {
                    int id = Convert.ToInt32(context.Request.Params["id"]);
                    context.Response.Write(new ShowBLL().deleteload(id));
                }
                else if (typ == 4)
                {
                    context.Response.Write(new ShowBLL().addload());
                }
                else if (typ == 5)
                {
                    int id = Convert.ToInt32(context.Request.Params["id_p"]);
                    context.Response.Write(new ShowBLL().permitShow(id));
                }
                else if (typ == 6)
                {
                    int id = Convert.ToInt32(context.Request.Params["id_d"]);
                    context.Response.Write(new ShowBLL().denyShow(id));
                }
            }
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}