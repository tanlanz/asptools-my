using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// LoginBLL 的摘要说明
/// </summary>
/// 
namespace BLL
{
    public class LoginBLL
    {
        public LoginBLL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        private usersDAL usd = new usersDAL();
        private IPdenyDAL ipdd = new IPdenyDAL();
       
        //检测ip访问 state=0时禁止访问
        public string ipcheck(string ip)
        {
            string ipstatus = "allow";
            try
            {
                IPdeny ii = ipdd.Get_IPdenyByIPdeny(ip);
                if (ii != null)
                {
                    if (ii.state == 0)
                    {
                        ipstatus = "deny";
                    }
                }
                else
                {
                    IPdeny i2 = new IPdeny();
                    i2.ip = ip;
                    i2.state = 1;
                    i2.logindate = DateTime.Now.ToString();
                    ipdd.Insert_IPdeny(i2);
                    ipstatus = "insert";
                }
            }
            catch(Exception e)
            {
                return "";
            }
            return ipstatus;
        }

        //ip直接禁止访问 state=0
        public string ipdeny(string ip)
        {            
            string ipstatus = "deny";
            try
            {
                IPdeny ii = ipdd.Get_IPdenyByIPdeny(ip);
                if (ii != null)
                {
                    ii.state = 0;
                    ipdd.Update_IPdeny(ii);
                }
                else
                {
                    IPdeny i2 = new IPdeny();
                    i2.ip = ip;
                    i2.state = 0;
                    i2.logindate = DateTime.Now.ToString();
                    ipdd.Insert_IPdeny(i2);
                }
            }
            catch(Exception e)
            {
                return "";
            }
            return ipstatus;
        }
        //ip管理页面的加载
        public string ipmanage(string ip)
        {
            string ipstatus = "";
            {
                try
                {
                    List<IPdeny> ii = ipdd.Get_IPdenyByIP();
                    if (ii != null)
                    {
                        foreach (IPdeny i2 in ii)
                        {
                            ipstatus += "<div class=\"tab - pane active in\"><label>访问IP：" + i2.ip + " | "+ i2.logindate +" </label>&nbsp;&nbsp;";
                            ipstatus += "处理 ：<input id=\"state\" class=\"input - xlarge\" value=\"" + i2.state + "\" />";
                            ipstatus += "<a href=\"javascript:void(0)\" class=\"btn btn-primary\"  onclick=\"save(" + i2.id+")\">save</a></div>";
                        }
                    }
                }
                catch (Exception e)
                {
                    return "";
                }
            }
            return ipstatus;
        }
        //ip管理页面的更改
        public string ipmanage(int id, int state)
        {
            string ipstatus = "";
            {
                try
                {
                    IPdeny ip1 = ipdd.Get_IPdenyById(id);
                    if (ip1 != null)
                    {
                        ip1.state = state;
                        ipdd.Update_IPdeny(ip1);
                        ipstatus = "succ";
                    }
                }
                catch (Exception e)
                {
                    return "";
                }
            }
            return ipstatus;
        }

        //检测页面登陆情况
        public string Check_Login(string username)
        {
            users u1 = usd.Get_usersByusers(username);
            if (u1 != null)
            {
                return "succLogin";
            }
            else return "nologi";
        }
        
        //登陆逻辑
        public string Login(string username,string pwd)
        {
            string loginstatus = "";
            users u1 = usd.Get_usersByusers(username);
            if (u1 != null)
            {
                pwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
                if (u1.password == pwd)
                {
                    //    loginstatus = "succ";
                    //}
                    //loginstatus = "密码不正确";
                    //if (pwd == u1.password.ToString())
                    //{
                    if (u1.state == 0)
                    {
                        loginstatus = "succ1";
                    }
                    else if (u1.state == 1)
                    {
                        loginstatus = "succ2";
                    }
                    u1.signInTime = DateTime.Now;
                    usd.Update_users(u1);
                }
                else
                {
                    loginstatus = "密码不正确";
                }
            }
            else
            {
                loginstatus = "用户不存在";
            }
            return loginstatus;
        }
        //注册
        public string Register(string name,string username, string pwd,string ip2)
        {
            string registerStatus = "";
            IPdeny i1 = ipdd.Get_IPdenyByIPdeny(ip2);            
            users u2 = usd.Get_usersByusers(username);
            if (i1.state == 1)//该ip状态为1时不允许注册
            {
                registerStatus = "请联系管理员";
            }
            else
            {
                try
                {
                    if (u2 == null)
                    {
                        users u1 = new users();
                        u1.username = username;
                        u1.password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
                        u1.name = name;
                        u1.signInTime = DateTime.Now;
                        usd.Insert_users(u1);
                        registerStatus = "succ";
                    }
                    else registerStatus = "用户名已被注册";
                }
                catch (Exception ex)
                {
                    return "error";
                }
            }
            return registerStatus;
        }

        //加解密算法
        public string Decry(string acc)//解密
        {
            string ret = "";
            ret = base_64(acc, false);
            if (acc != null)
            {
                char[] separator = { '*' };
                string[] arr = acc.Split(separator);
                string str1 = arr[0];
                string str2 = arr[1];
                string str3 = arr[2];
                string str4 = arr[3];
                string str5 = arr[4];
                string username2 = str4 + str2, password2 = str3 + str1;
                users u1 = usd.Get_usersByusers(username2);
                try
                {
                    if (u1 != null)
                    {
                        if (str5 == u1.signInTime.ToString())
                        {
                            ret = password2;
                        }
                    }
                }
                catch( Exception ex)
                {
                    return "";
                }
            
                //读取数据库中上次登陆时间，调换后从字符串尾减
                //ret = CheckUser(username2, password2);//登录
            }
            return ret;
        }
        public string EncryptionCookies(string username, string password)//加密
        {
            users u2 = usd.Get_usersByusers(username);
            try
            {
                if (u2 != null)
                {
                    u2.signInTime = DateTime.Now;
                    usd.Update_users(u2);
                    //判断用户是否存在，将当前时间保存进数据库的登陆时间，读取数据库中的保存的登陆时间，调换前从字符串尾加
                    string str = username + "*" + password;
                    string tSt1, tSt2;
                    int i = 1;
                    tSt1 = str.Substring(str.Length - i, i);//右
                    tSt2 = str.Substring(0, i);
                    str = str.Remove(0, 1);
                    str = str.Remove(str.Length - 1, 1);
                    str = tSt1 + "*" + str + "*" + tSt2 + "*" + u2.signInTime;
                    str = base_64(str, true);
                    return str;
                    //Base64加密
                }
                else return "";
            }
            catch(Exception ex)
            {
                return "";
            }
            
        }
        /// <summary>
        /// Base64加密，解密方法
        /// </summary>
        /// <paramname="s">输入字符串</param>
        /// <paramname="c">true-加密,false-解密</param>
        static public string base_64(string s, bool c)
        {
            if (c)
            {
                return System.Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(s));
            }
            else
            {
                try
                {
                    return System.Text.Encoding.Default.GetString(System.Convert.FromBase64String(s));
                }
                catch (Exception exp)
                {
                    return exp.Message;
                }
            }
        }
    }
}