using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by
 */

namespace Dapper.IDAL
{
    public interface IUserDAL
    {
        #region CRUD

        int Insert(DangNhap model);

        int Update(DangNhap model);

        int Delete(DangNhap model);

        int Delete(int id);

        IList<DangNhapGridView> GetList(CoreModel obj);

        /// <summary>
        /// DANGNHAP
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DangNhap GetEntity(int id);

        /// <summary>
        /// Đăng nhập tài khoản
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        DangNhap Login(string userName,string passWord);


        /// <summary>
        /// Update 1 vài thông tin user đang đăng nhập
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int UpdateUserLogin(DangNhap model);

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int ChangePassWord(DangNhap model);
        #endregion
    }
}
