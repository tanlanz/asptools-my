<%@ WebHandler Language="C#" Class="pic_show" %>

using System;
using System.Web;
using BLL;

public class pic_show : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        PicDealBLL pic = new PicDealBLL();
        string type1 = context.Request["type1"];
        if (type1 == "0")//显示所有的图片
        {
            context.Response.Write(pic.pic_show());
        }
        else if (type1 == null || type1 == "")
        {
            context.Response.Write("error");
        }
        else if (type1 == "1")//删除图片
        {
            int picName =Int16.Parse(context.Request["pic_id"]);
            context.Response.Write(pic.pic_delete(picName));
        }
        else if (type1 == "2")//显示选定的图片
        {
            int picName =Int16.Parse(context.Request["pic_id"]);
            context.Response.Write(pic.pic_show(picName));
        }
        else if (type1 == "3")//显示选定的图片
        {
            context.Response.Write(pic.pic_show_head());
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}