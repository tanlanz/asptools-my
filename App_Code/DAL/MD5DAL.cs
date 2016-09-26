using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// md5DAL 的摘要说明
/// </summary>
/// 
namespace DAL
{
    public class md5DAL
    {
        public md5DAL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /*  数据库连接  */
        private DataClassesDataContext db = new DataClassesDataContext();

        /******************************
        ** 作者：zhu 
        ** 创建时间：2016年6月23日
        ** 输入参数：
            md5 md5Ins      一个md5实例         
        ** 输出参数：
            bool                插入成功与否
        ******************************/
        #region ### Insert_md5 插入一个md5对象
        public bool Insert_md5(md5 md5Ins)
        {
            try
            {
                db.md5.InsertOnSubmit(md5Ins);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Insert_md5 exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者： zhu 
        ** 创建时间：2016年6月23日
        ** 输入参数：
            int id              一个md5对象唯一识别码         
        ** 输出参数：
            bool                删除成功与否
        ******************************/
        #region ### Detele_md5ById  依据ID删除一个md5对象
        public bool Detele_md5ById(int id)
        {
            try
            {
                db.md5.DeleteOnSubmit(Get_md5ById(id));
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{1} Detele_md5ById exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：  zhu
        ** 创建时间：  2016年6月23日
        ** 输入参数：
            md5 md5Ins             一个md5实例         
        ** 输出参数：
            bool                       更新成功与否
        ******************************/
        #region ### Update_md5  更新一个md5对象
        public bool Update_md5(md5 md5Ins)
        {
            try
            {
                md5 a = db.md5.First(t => t.id == md5Ins.id);
                a.text1 = md5Ins.text1;
                a.text2 = md5Ins.text2;
                a.ip = md5Ins.ip;
                a.time = md5Ins.time;
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{2} Update_md5 exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：zhu
        ** 创建时间：2016年6月23日
        ** 输入参数：
            int id              一个md5对象唯一识别码         
        ** 输出参数：
            md5               一个md5实例
        ******************************/
        #region ### Get_md5ById  依据id获取一个md5对象
        public md5 Get_md5ById(int id)
        {
            try
            {
                return db.md5.First(a => a.id.Equals(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_md5ById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年6月23日
        ** 输入参数：
            int id              一个md5对象唯一识别码         
        ** 输出参数：
            md5               一个md5实例
        ******************************/
        #region ### Get_md5Bymd5 依据id获取一个md5对象
        public md5 Get_md5Bymd5(string md5)
        {
            try
            {
                return db.md5.First(a => a.text1.Equals(md5));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_md5ById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年6月23日
        ** 输入参数：
            string ip              一个md5对象d的ip        
        ** 输出参数：
            md5               一个md5实例
        ******************************/
        #region ### Get_md5Bytoken  依据id获取一个md5对象
        public List<md5> Get_md5Bytoken(string ip)
        {
            try
            {
                return db.md5.Where(a => a.ip == ip).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("{4} Get_userByloginName exception caught." + e);
                return null;
            }
        }
        #endregion
    }
}