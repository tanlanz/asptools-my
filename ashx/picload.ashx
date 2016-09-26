<%@ WebHandler Language="C#" Class="picload" %>

using System;
using System.Web;
using BLL;

public class picload : IHttpHandler {

    public void ProcessRequest(HttpContext context) {
        context.Response.ContentType = "text/plain";
        //图片上传，并且制作略缩图
        PicDealBLL pic = new PicDealBLL();
        //获得浏览器端 传过来 第一个文件选择框的数据  
        //string a=context.Request["all"];
        HttpPostedFile hpFile = context.Request.Files[0];

        //判断 上传文件数据的长度是否>0  
        if (hpFile.ContentLength > 0)
        {
            context.Response.Write(pic.pic_load(hpFile));
            //context.Response.Write("<img id=\"pic1\" src=\"../upload/theme/"+hpFile.FileName +" \" alt=\"图1\" />");
        }
        else
        {
            context.Response.Write("还没有选择要上传的文件！");
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}