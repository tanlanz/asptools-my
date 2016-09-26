using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

/// <summary>
/// adminBLL 的摘要说明
/// </summary>
/// 
namespace BLL
{
    public class adminBLL
    {
        public adminBLL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        private reportDAL red = new reportDAL();
        public string save(string email, string name, string message,string ip)
        {
            try
            {
                report re = red.Get_reportByreport(ip);
                if (re != null)
                {
                    if(re.send_time.ToString().Substring(0,8) == DateTime.Now.ToString().Substring(0,8)) {
                        //return "name=" + name + ";email=" + email + ";message=" + message + DateTime.Now.ToString().Substring(0,9);
                        return "请明天再试，或者联系管理员";
                    }
                    else
                    {
                        //return re.send_time.ToString().Substring(5);
                        report re2 = new report();
                        re2.email = email;
                        re2.ip = ip;
                        re2.name = name;
                        re2.send_time = DateTime.Now;
                        re2.message1 = message;
                        red.Insert_report(re2);
                        return "成功提交";
                    }
                }
                else
                {
                    report re2 = new report();
                    re2.email = email;
                    re2.ip = ip;
                    re2.name = name;
                    re2.send_time = DateTime.Now;
                    re2.message1 = message;
                    red.Insert_report(re2);
                    return "成功提交";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}