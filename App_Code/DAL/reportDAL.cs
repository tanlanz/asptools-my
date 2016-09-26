using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// reportDAL 的摘要说明
/// </summary>
/// 
namespace DAL
{
    public class reportDAL
    {
        public reportDAL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        private DataClassesDataContext db = new DataClassesDataContext();

        /******************************
        ** 作者：zhu 
        ** 创建时间：2016年8月4日
        ** 输入参数：
            report reportIns      一个report实例         
        ** 输出参数：
            bool                插入成功与否
        ******************************/
        #region ### Insert_report 插入一个report对象
        public bool Insert_report(report reportIns)
        {
            try
            {
                db.report.InsertOnSubmit(reportIns);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Insert_report exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者： zhu 
        ** 创建时间：2016年8月4日
        ** 输入参数：
            int id              一个report对象唯一识别码         
        ** 输出参数：
            bool                删除成功与否
        ******************************/
        #region ### Detele_reportById  依据ID删除一个report对象
        public bool Detele_reportById(int id)
        {
            try
            {
                db.report.DeleteOnSubmit(Get_reportById(id));
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{1} Detele_reportById exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：  zhu
        ** 创建时间：  2016年8月4日
        ** 输入参数：
            report reportIns             一个report实例         
        ** 输出参数：
            bool                       更新成功与否
        ******************************/
        #region ### Update_report  更新一个report对象
        public bool Update_report(report reportIns)
        {
            try
            {
                report a = db.report.First(t => t.id == reportIns.id);
                a.name = reportIns.name;
                a.email = reportIns.email;
                a.ip = reportIns.ip;
                a.message1 = reportIns.message1;
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{2} Update_report exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：zhu
        ** 创建时间：2016年8月4日
        ** 输入参数：
            int id              一个report对象唯一识别码         
        ** 输出参数：
            report               一个report实例
        ******************************/
        #region ### Get_reportById  依据id获取一个report对象
        public report Get_reportById(int id)
        {
            try
            {
                return db.report.First(a => a.id.Equals(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_reportById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年8月4日
        ** 输入参数：
            int id              一个report对象唯一识别码         
        ** 输出参数：
            report               一个report实例
        ******************************/
        #region ### Get_reportByreport 依据id获取一个report对象
        public report Get_reportByreport(string ip)
        {
            try
            {
                return db.report.First(a => a.ip.Equals(ip));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_reportById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年8月4日
        ** 输入参数：
            string ip              一个report对象d的ip        
        ** 输出参数：
            report               一个report实例
        ******************************/
        #region ### Get_reportBytoken  依据id获取一个report对象
        public List<report> Get_reportBytoken(string ip)
        {
            try
            {
                return db.report.Where(a => a.ip == ip).ToList();
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