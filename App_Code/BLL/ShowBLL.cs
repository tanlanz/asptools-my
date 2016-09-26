using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// ShowBLL 的摘要说明
/// </summary>
/// 
namespace BLL
{
    public class ShowBLL
    {
        public ShowBLL()
        {
        }
        private showDAL sd = new showDAL();
        public string load()//加载普通页面
        {
            string text = "";
            List<show> s1 = sd.Get_showBytoken(1);
            foreach(show s in s1)
            {
                text += "<div class=\"4u 12u$(mobile)\" ><article class=\"item\"><header><h3> " + s.title + "  </h3></header>";
                text += "<span>" + s.text + "</span></article></div>";

            }
            return text;
        }
        public string adminload()//加载管理员页面
        {
            string text = "";
            List<show> s1 = sd.Get_showBytoken();
            foreach (show s in s1)
            {
                text += "标题：<input type='text' id=\"ss" + s.id + "\" value=\"" + s.title + "\"style=\"width:80%;\"/><br />";
                text += "内容：<textarea id=\"tt" + s.id + "\" style=\"width:80%;height:100px;\">" + s.text + "</textarea><br /><a href=\"javascript:void(0)\" onclick=\"save(" + s.id + ")\">保存</a>&nbsp;";
                text += "<a href=\"javascript:void(0)\" onclick=\"delete1(" + s.id + ")\">删除</a>&nbsp;";
                if (s.state == 0)
                {
                    text += "<a href=\"javascript:void(0)\" onclick=\"permitShow(" + s.id + ")\">设置为可见</a>&nbsp;<hr />";
                }
                if (s.state == 1)
                {
                    text += "<a href=\"javascript:void(0)\" onclick=\"denyShow(" + s.id + ")\">设置为不可见</a>&nbsp;<hr />";
                }
            }
            text += "<script type=\"text/javascript\">document.getElementById(\"exit\").style.display = \"\";</script>";
            return text;
        }


        //文字板块
        public string saveload(string ss,string tt,string id)//管理员保存修改
        {
            int id1 = Convert.ToInt32(id);
            string text = "";
            show s2 = sd.Get_showById(id1);
            try
            {
                s2.title = ss;
                s2.text = tt;
                sd.Update_show(s2);
            }
            catch(Exception ex)
            {
                return "";
            }
            text = "succ";
            return text;
        }
        public string deleteload(int id)//管理员删除
        {
            string text = "";
            try
            {
                sd.Detele_showById(id);
            }
            catch (Exception ex)
            {
                return "";
            }
            text = "succ";
            return text;
        }
        public string addload()//管理员添加
        {
            string text = "";
            show sh = new show();
            sh.title = "";
            sh.text = "";
            sh.state = 0;
            try
            {
                sd.Insert_show(sh);
            }
            catch (Exception ex)
            {
                return "";
            }
            text = "succ";
            return text;
        }
        public string permitShow(int id)//管理员允许显示
        {
            string text = "";
            show s2 = sd.Get_showById(id);
            try
            {
                s2.state = 1;
                sd.Update_show(s2);
            }
            catch (Exception ex)
            {
                return "";
            }
            text = "succ";
            return text;
        }
        public string denyShow(int id)//管理员禁止查看
        {
            string text = "";
            show s2 = sd.Get_showById(id);
            try
            {
                s2.state = 0;
                sd.Update_show(s2);
            }
            catch (Exception ex)
            {
                return "";
            }
            text = "succ";
            return text;
        }
    }
}