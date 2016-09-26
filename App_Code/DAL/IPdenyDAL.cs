using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IPdeny 的摘要说明
/// </summary>
/// 
namespace DAL
{
    public class IPdenyDAL
    {
        public IPdenyDAL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        private DataClassesDataContext db = new DataClassesDataContext();

        /******************************
        ** 作者：zhu 
        ** 创建时间：2016年7月3日
        ** 输入参数：
            IPdeny IPdenyIns      一个IPdeny实例         
        ** 输出参数：
            bool                插入成功与否
        ******************************/
        #region ### Insert_IPdeny 插入一个IPdeny对象
        public bool Insert_IPdeny(IPdeny IPdenyIns)
        {
            try
            {
                db.IPdeny.InsertOnSubmit(IPdenyIns);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Insert_IPdeny exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者： zhu 
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个IPdeny对象唯一识别码         
        ** 输出参数：
            bool                删除成功与否
        ******************************/
        #region ### Detele_IPdenyById  依据ID删除一个IPdeny对象
        public bool Detele_IPdenyById(int id)
        {
            try
            {
                db.IPdeny.DeleteOnSubmit(Get_IPdenyById(id));
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{1} Detele_IPdenyById exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：  zhu
        ** 创建时间：  2016年7月3日
        ** 输入参数：
            IPdeny IPdenyIns             一个IPdeny实例         
        ** 输出参数：
            bool                       更新成功与否
        ******************************/
        #region ### Update_IPdeny  更新一个IPdeny对象
        public bool Update_IPdeny(IPdeny IPdenyIns)
        {
            try
            {
                IPdeny a = db.IPdeny.First(t => t.id == IPdenyIns.id);
                a.ip = IPdenyIns.ip;
                a.state = IPdenyIns.state;
                a.logindate = IPdenyIns.logindate;
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{2} Update_IPdeny exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个IPdeny对象唯一识别码         
        ** 输出参数：
            IPdeny               一个IPdeny实例
        ******************************/
        #region ### Get_IPdenyById  依据id获取一个IPdeny对象
        public IPdeny Get_IPdenyById(int id)
        {
            try
            {
                return db.IPdeny.First(a => a.id.Equals(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_IPdenyById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个IPdeny对象唯一识别码         
        ** 输出参数：
            IPdeny               一个IPdeny实例
        ******************************/
        #region ### Get_IPdenyByIPdeny 依据id获取一个IPdeny对象
        public IPdeny Get_IPdenyByIPdeny(string IPdeny)
        {
            try
            {
                return db.IPdeny.First(a => a.ip.Equals(IPdeny));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_IPdenyById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            string ip              一个IPdeny对象d的ip        
        ** 输出参数：
            IPdeny               一个IPdeny实例
        ******************************/
        #region ### Get_IPdenyBytoken  依据id获取一个IPdeny对象
        public List<IPdeny> Get_IPdenyBytoken(int state)
        {
            try
            {
                return db.IPdeny.Where(a => a.state == state).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("{4} Get_userByloginName exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            string ip              一个IPdeny对象d的ip        
        ** 输出参数：
            IPdeny               一个IPdeny实例
        ******************************/
        #region ### Get_IPdenyBytoken  依据id获取一个IPdeny对象
        public List<IPdeny> Get_IPdenyByIP()
        {
            try
            {
                return db.IPdeny.Where(a => a.ip !=null).Distinct().ToList();
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