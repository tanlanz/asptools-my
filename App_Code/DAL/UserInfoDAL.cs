using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// UserInfoDAL 的摘要说明
/// </summary>
/// 
namespace DAL
{
    public class UserInfoDAL
    {
        public UserInfoDAL()
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
            UserInfo UserInfoIns      一个UserInfo实例         
        ** 输出参数：
            bool                插入成功与否
        ******************************/
        #region ### Insert_UserInfo 插入一个UserInfo对象
        public bool Insert_UserInfo(UserInfo UserInfoIns)
        {
            try
            {
                db.UserInfo.InsertOnSubmit(UserInfoIns);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Insert_UserInfo exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者： zhu 
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个UserInfo对象唯一识别码         
        ** 输出参数：
            bool                删除成功与否
        ******************************/
        #region ### Detele_UserInfoById  依据ID删除一个UserInfo对象
        public bool Detele_UserInfoById(int id)
        {
            try
            {
                db.UserInfo.DeleteOnSubmit(Get_UserInfoById(id));
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{1} Detele_UserInfoById exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：  zhu
        ** 创建时间：  2016年7月3日
        ** 输入参数：
            UserInfo UserInfoIns             一个UserInfo实例         
        ** 输出参数：
            bool                       更新成功与否
        ******************************/
        #region ### Update_UserInfo  更新一个UserInfo对象
        public bool Update_UserInfo(UserInfo UserInfoIns)
        {
            try
            {
                UserInfo a = db.UserInfo.First(t => t.id == UserInfoIns.id);
                a.username = UserInfoIns.username;
                a.age = UserInfoIns.age;
                a.email = UserInfoIns.email;
                a.ID_Card = UserInfoIns.ID_Card;
                a.phone = UserInfoIns.phone;
                a.photo = UserInfoIns.photo;
                a.sex = UserInfoIns.sex;
                a.userId = UserInfoIns.userId;
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{2} Update_UserInfo exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个UserInfo对象唯一识别码         
        ** 输出参数：
            UserInfo               一个UserInfo实例
        ******************************/
        #region ### Get_UserInfoById  依据id获取一个UserInfo对象
        public UserInfo Get_UserInfoById(int id)
        {
            try
            {
                return db.UserInfo.First(a => a.id.Equals(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_UserInfoById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            int id              一个UserInfo对象唯一识别码         
        ** 输出参数：
            UserInfo               一个UserInfo实例
        ******************************/
        #region ### Get_UserInfoByUserInfo 依据id获取一个UserInfo对象
        public UserInfo Get_UserInfoByUserInfo(string UserInfo)
        {
            try
            {
                return db.UserInfo.First(a => a.username.Equals(UserInfo));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_UserInfoById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年7月3日
        ** 输入参数：
            string ip              一个UserInfo对象d的ip        
        ** 输出参数：
            UserInfo               一个UserInfo实例
        ******************************/
        #region ### Get_UserInfoBytoken  依据id获取一个UserInfo对象
        public List<UserInfo> Get_UserInfoBytoken(string  state)
        {
            try
            {
                return db.UserInfo.Where(a => a.photo == state).ToList();
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