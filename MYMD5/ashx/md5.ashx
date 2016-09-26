<%@ WebHandler Language="C#" Class="md5" %>

using System;
using System.Web;
using BLL;

public class md5 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        if (context.Request.Params.Count > 0) 
        {
            string text = context.Request.Params["text1"].ToString().Replace("\n", "").Replace(" ","").Replace("\t","").Replace("\r","");
            string codetext = new MD5BLL().md5Code(text);
            if (codetext != null)
            {
                context.Response.Write(codetext);
            }
            else
            {
                context.Response.Write("ERROR2");
            }
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}