using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// showDAL 的摘要说明
/// </summary>
/// 
namespace DAL
{
    public class showDAL
    {
        public showDAL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        private DataClassesDataContext db = new DataClassesDataContext();

        /******************************
        ** 作者：zhu 
        ** 创建时间：2016年7月19日
        ** 输入参数：
            show showIns      一个show实例         
        ** 输出参数：
            bool                插入成功与否
        ******************************/
        #region ### Insert_show 插入一个show对象
        public bool Insert_show(show showIns)
        {
            try
            {
                db.show.InsertOnSubmit(showIns);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Insert_show exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者： zhu 
        ** 创建时间：2016年7月19日
        ** 输入参数：
            int id              一个show对象唯一识别码         
        ** 输出参数：
            bool                删除成功与否
        ******************************/
        #region ### Detele_showById  依据ID删除一个show对象
        public bool Detele_showById(int id)
        {
            try
            {
                db.show.DeleteOnSubmit(Get_showById(id));
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{1} Detele_showById exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：  zhu
        ** 创建时间：  2016年7月19日
        ** 输入参数：
            show showIns             一个show实例         
        ** 输出参数：
            bool                       更新成功与否
        ******************************/
        #region ### Update_show  更新一个show对象
        public bool Update_show(show showIns)
        {
            try
            {
                show a = db.show.First(t => t.id == showIns.id);
                a.title = showIns.title;
                a.name = showIns.name;
                a.sort = showIns.sort;
                a.changeTime = showIns.changeTime;
                a.text = showIns.text;
                a.state = showIns.state;
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{2} Update_show exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月19日
        ** 输入参数：
            int id              一个show对象唯一识别码         
        ** 输出参数：
            show               一个show实例
        ******************************/
        #region ### Get_showById  依据id获取一个show对象
        public show Get_showById(int id)
        {
            try
            {
                return db.show.First(a => a.id.Equals(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_showById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月19日
        ** 输入参数：
            int id              一个show对象唯一识别码         
        ** 输出参数：
            show               一个show实例
        ******************************/
        #region ### Get_showByshow 依据id获取一个show对象
        public show Get_showByshow(string show)
        {
            try
            {
                return db.show.First(a => a.title.Equals(show));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_showById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月19日
        ** 输入参数：
            string ip              一个show对象d的ip        
        ** 输出参数：
            show               一个show实例
        ******************************/
        #region ### Get_showBytoken  依据id获取一个show对象
        public List<show> Get_showBytoken(int state)
        {
            try
            {
                return db.show.Where(a => a.state == state).OrderByDescending(a=>a.changeTime).ToList();
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
        ** 创建时间：2016年7月20日
        ** 输入参数：
            string ip              一个show对象d的ip        
        ** 输出参数：
            show               一个show实例
        ******************************/
        #region ### Get_showBytoken  依据id获取一个show对象
        public List<show> Get_showBytoken()
        {
            try
            {
                return db.show.Where(a => a.state != null).OrderByDescending(a => a.changeTime).ToList();
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