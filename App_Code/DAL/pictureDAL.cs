using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// picture 的摘要说明
/// </summary>
/// 
namespace DAL
{
    public class pictureDAL
    {
        public pictureDAL()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        private DataClassesDataContext db = new DataClassesDataContext();

        /******************************
        ** 作者：zhu 
        ** 创建时间：2016年9月26日
        ** 输入参数：
            picture pictureIns      一个picture实例         
        ** 输出参数：
            bool                插入成功与否
        ******************************/
        #region ### Insert_picture 插入一个picture对象
        public bool Insert_picture(picture pictureIns)
        {
            try
            {
                db.picture.InsertOnSubmit(pictureIns);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Insert_picture exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者： zhu 
        ** 创建时间：2016年9月26日
        ** 输入参数：
            int id              一个picture对象唯一识别码         
        ** 输出参数：
            bool                删除成功与否
        ******************************/
        #region ### Detele_pictureById  依据ID删除一个picture对象
        public bool Detele_pictureById(int id)
        {
            try
            {
                db.picture.DeleteOnSubmit(Get_pictureById(id));
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{1} Detele_pictureById exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：  zhu
        ** 创建时间：  2016年9月26日
        ** 输入参数：
            picture pictureIns             一个picture实例         
        ** 输出参数：
            bool                       更新成功与否
        ******************************/
        #region ### Update_picture  更新一个picture对象
        public bool Update_picture(picture pictureIns)
        {
            try
            {
                picture a = db.picture.First(t => t.id == pictureIns.id);
                a.u_id = pictureIns.u_id;
                a.changetime = pictureIns.changetime;
                a.pic_name = pictureIns.pic_name;
                a.pic_type = pictureIns.pic_type;
                a.read_text = pictureIns.read_text;
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{2} Update_picture exception caught." + e);
                return false;
            }
        }
        #endregion


        /******************************
        ** 作者：zhu
        ** 创建时间：2016年9月26日
        ** 输入参数：
            int id              一个picture对象唯一识别码         
        ** 输出参数：
            picture               一个picture实例
        ******************************/
        #region ### Get_pictureById  依据id获取一个picture对象
        public picture Get_pictureById(int id)
        {
            try
            {
                return db.picture.First(a => a.id.Equals(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_pictureById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年9月26日
        ** 输入参数：
            int id              一个picture对象唯一识别码         
        ** 输出参数：
            picture               一个picture实例
        ******************************/
        #region ### Get_pictureBypicture 依据id获取一个picture对象
        public picture Get_pictureBypicture(string picture)
        {
            try
            {
                return db.picture.First(a => a.pic_name.Equals(picture));
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_pictureById exception caught." + e);
                return null;
            }
        }
        #endregion

        /******************************
        ** 作者：zhu
        ** 创建时间：2016年9月26日
        ** 输入参数：
            string ip              一个picture对象d的ip        
        ** 输出参数：
            picture               一个picture实例
        ******************************/
        #region ### Get_pictureBytoken  依据id获取一个picture对象
        public List<picture> Get_pictureBytoken(int state)
        {
            try
            {
                return db.picture.Where(a => a.id == state).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("{4} Get_userByloginName exception caught." + e);
                return null;
            }
        }
        #endregion

        #region ### Get_pictureBypicture 依据id获取一个picture对象
        public picture Get_pictureForHead()
        {
            try
            {
                return db.picture.First(a => a.pic_type=="head");
            }
            catch (Exception e)
            {
                Console.WriteLine("{3} Get_pictureById exception caught." + e);
                return null;
            }
        }
        #endregion
    }
}