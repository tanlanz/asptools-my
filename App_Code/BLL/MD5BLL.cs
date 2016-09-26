using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using DAL;

/// <summary>
/// MD5BLL 对文本进行加密MD5
/// </summary>
/// 
namespace BLL
{   
    public class MD5BLL
    { 
        public md5DAL md5D = new md5DAL();
        md5 md5 = new md5();
        public MD5BLL()
        {

        }
        public string md5Code(string text)//加密
        {
            string codetext="";
            try
            {
                codetext = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(text, "MD5");
                md5 md5test = md5D.Get_md5Bymd5(text);
                if (md5test != null)
                {
                    if (md5test.text2 != codetext)
                    {
                            insertmd5(text, codetext);
                    }
                }
                else
                {
                    insertmd5(text, codetext);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Insert_PublishNews exception caught." + e);
            }
            return codetext;
        }

        //将md5加入数据库
        public void insertmd5(string text, string codetext)
        {
            try
            {
                md5.text1 = text;
                md5.text2 = codetext;
                md5.time = DateTime.Now;
                md5D.Insert_md5(md5);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Insert_PublishNews exception caught." + e);
            }
        }
    }
}