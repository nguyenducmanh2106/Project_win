using Dapper.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Model;
using Dapper.IDAL;
using Dapper.Factory;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.BLL
{
    public class UserBLL : IUserBLL
    {
        private static readonly IUserDAL dal = DALFactory.CreateUserDAL();

        public bool Insert(DangNhap model)
        {
            return dal.Insert(model) > 0 ? true : false;
        }

        public bool Update(DangNhap model)
        {
            return dal.Update(model) > 0 ? true : false;
        }

        public bool Delete(DangNhap model)
        {
            return dal.Delete(model) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<DangNhapGridView> GetList(CoreModel obj)
        {
            return dal.GetList(obj);
        }

        public DangNhap GetEntity(int id)
        {
            return dal.GetEntity(id);
        }

        /// <summary>
        /// Đăng nhập tài khoản
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public DangNhap Login(string userName, string passWord)
        {
            try
            {
                return dal.Login(userName, passWord);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Update 1 vài thông tin của tài khoản đăng nhập
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool UpdateUserLogin(DangNhap model)
        {
            try
            {
                int result = dal.UpdateUserLogin(model);
                return result > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ChangePassWord(DangNhap model)
        {
            try
            {
                int result = dal.ChangePassWord(model);
                return result > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
