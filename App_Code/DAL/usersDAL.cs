using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// usersDAL 的摘要说明
/// </summary>
/// 
namespace DAL
{
    public class usersDAL
    {
        public usersDAL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /*  数据库连接  */
        private DataClassesDataContext db = new DataClassesDataContext();

        /******************************
        ** 作者：zhu 
        ** 创建时间：2016年7月3日
        ** 输入参数：
            users usersIns      一个users实例         
        ** 输出参数：
            bool                插入成功与否
        ******************************/
        #region ### Insert_users 插入一个users对象
        public bool Insert_users(users usersIns)
        {
            try
            {
                db.users.InsertOnSubmit(usersIns);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Insert_users exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者： zhu 
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个users对象唯一识别码         
        ** 输出参数：
            bool                删除成功与否
        ******************************/
        #region ### Detele_usersById  依据ID删除一个users对象
        public bool Detele_usersById(int id)
        {
            try
            {
                db.users.DeleteOnSubmit(Get_usersById(id));
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{1} Detele_usersById exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：  zhu
        ** 创建时间：  2016年7月3日
        ** 输入参数：
            users usersIns             一个users实例         
        ** 输出参数：
            bool                       更新成功与否
        ******************************/
        #region ### Update_users  更新一个users对象
        public bool Update_users(users usersIns)
        {
            try
            {
                users a = db.users.First(t => t.id == usersIns.id);
                a.username = usersIns.username;
                a.password = usersIns.password;
                a.signInTime = usersIns.signInTime;
                a.state = usersIns.state;
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{2} Update_users exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个users对象唯一识别码         
        ** 输出参数：
            users               一个users实例
        ******************************/
        #region ### Get_usersById  依据id获取一个users对象
        public users Get_usersById(int id)
        {
            try
            {
                return db.users.First(a => a.id.Equals(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_usersById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个users对象唯一识别码         
        ** 输出参数：
            users               一个users实例
        ******************************/
        #region ### Get_usersByusers 依据id获取一个users对象
        public users Get_usersByusers(string users)
        {
            try
            {
                return db.users.First(a => a.username.Equals(users));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_usersById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            string ip              一个users对象d的ip        
        ** 输出参数：
            users               一个users实例
        ******************************/
        #region ### Get_usersBytoken  依据id获取一个users对象
        public List<users> Get_usersBytoken(int state)
        {
            try
            {
                return db.users.Where(a => a.state == state ).ToList();
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