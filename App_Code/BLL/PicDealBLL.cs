using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.IO;
using System.Drawing;

/// <summary>
/// PicDealBLL 的摘要说明
/// </summary>
/// 
namespace BLL
{
    public class PicDealBLL
    {
        public PicDealBLL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        //本次修改均没有连接数据库需要设计数据库
        
        DirectoryInfo TheFolder = new DirectoryInfo(@"F:\DownloadSave\OthersCode\CodeWeb\MyselfSite\asptools-my\upload");

        //检索文件夹中所有的图片，返回地址
        /*
         * 创建日期：2016年9月26日10：37
         * 对应pic_show.ashx 需要连接数据库，以便后续的图片选择的操作
         * 
         */
        public string pic_show()
        {
            string pic_text = "";

            try
            {
                //遍历文件夹
                //foreach(DirectoryInfo NextFolder in TheFolder.GetDirectories())
                //   this.listBox1.Items.Add(NextFolder.Name);
                //显示文件夹所拥有的图片
                string name = "";
                int pic_number = 0;
                int width = 200;
                pic_text = "$(\"#pic_upload\").html('";
                //遍历文件
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                {
                    name = NextFile.Name;
                    pic_text += "<a href=\"#myModal\" role=\"button\" data-toggle=\"modal\" onclick=\"pic_upload(" + pic_number + ")\" >";
                    pic_text += "<img src=\"../upload/" + name + "\" class=\"img-polaroid\" style=\"max-width:" + width + "px;myimg:expression_r(onload=function(){this.style.width=(this.offsetWidth > " + width + ")?\"" + width + "px\":\"auto\"});\" alt=\"null\"></a>&nbsp;&nbsp;";//宽度可调
                    pic_number++;
                }
                pic_text += "');$(\"#images_number\").html('" + pic_number + "');";
                if (pic_text.Length < 1)
                {
                    pic_text = "null";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return pic_text;
        }

        //删除文件夹中的图片，返回操作
        /*
         * 创建日期：2016年9月26日10：53
         * 对应pic_show.ashx 需要连接数据库，以便后续的图片选择的操作
         * 
         */
        public string pic_delete(int pic_id)
        {
            string pic_text = "";

            try
            {
                //判断文件是不是存在
                //if (File.Exists(@"F:\DownloadSave\OthersCode\CodeWeb\MyselfSite\asptools-my\upload\" + picName + ""))
                if (File.Exists(@"F:\DownloadSave\OthersCode\CodeWeb\MyselfSite\asptools-my\upload\" + TheFolder.GetFiles()[pic_id] + ""))
                {
                    //如果存在则删除
                    File.Delete(@"F:\DownloadSave\OthersCode\CodeWeb\MyselfSite\asptools-my\upload\" + TheFolder.GetFiles()[pic_id] + "");
                    pic_text = "删除成功";
                }
                else pic_text = TheFolder.GetFiles()[pic_id].ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return pic_text;
        }

        //上传图片，返回成功信息
        /*
         * 创建日期：2016年9月26日10：37
         * 对应picload.ashx
         */
        public string pic_load(HttpPostedFile hpFile)
        {
            string pic_text = "";

            try
            {
                //要保存的目录路径  
                string filePath = "../upload";

                    //获得上传上来的文件名称  
                    string fileName = Path.GetFileName(hpFile.FileName);
                    //获得 要保存的物理路径  
                    filePath = HttpContext.Current.Server.MapPath(filePath + "/" + fileName);
                    //将上传来的 文件数据 保存在 对应的 物理路径上  
                    hpFile.SaveAs(filePath);
                    //如果上传上来的是图片文件数据  
                    if (hpFile.ContentType.IndexOf("image") > -1)
                    {
                        //将上传上来的文件对象里的 数据流 转成 图片对象  
                        using (Image img = Image.FromStream(hpFile.InputStream))
                        {
                            //创建缩略图对象  
                            using (Bitmap thumbImg = new Bitmap(950, 450))
                            {
                                //创建 【画家】对象，并告诉他要在缩略图上作画  
                                using (Graphics g = Graphics.FromImage(thumbImg))
                                {
                                    //将 原图 img 画在 缩略图 thumbImg上  
                                    //第一个长方形参数：要把原图 画成多大  
                                    //第二个长方形参数：要画原图的哪个部分(要把原图的哪个部分画到缩略图上)  
                                    g.DrawImage(img, new Rectangle(0, 0, thumbImg.Width, thumbImg.Height), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                                    string thumbImgPath = HttpContext.Current.Server.MapPath("../upload/theme/" + fileName);
                                    thumbImg.Save(thumbImgPath);
                                    //context.Response.Write("制作小图成功：" + "/theme" + fileName);
                                }
                            }
                        }
                    }
                pic_text = "上传成功的文件名：" + hpFile.FileName + "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return pic_text;
        }
    }
}