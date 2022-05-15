using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by ndmanh 
 */

namespace Dapper.IBLL
{
    public interface IUserBLL
    {
        #region CRUD

        bool Insert(DangNhap book);

        bool Update(DangNhap book);

        bool Delete(DangNhap book);

        bool Delete(int id);

        IList<DangNhapGridView> GetList(CoreModel obj);

        DangNhap GetEntity(int id);

        /// <summary>
        /// Đăng nhập tài khoản
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        DangNhap Login(string userName,string passWord);

        /// <summary>
        /// Update 1 vài thông tin của tài khoản đăng nhập
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        bool UpdateUserLogin(DangNhap book);

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool ChangePassWord(DangNhap book);

        #endregion
    }
}
