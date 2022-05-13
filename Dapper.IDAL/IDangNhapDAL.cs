using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.IDAL
{
    public interface IDangNhapDAL
    {
        #region CRUD

        int Insert(DangNhap model);

        int Update(DangNhap model);

        int Delete(DangNhap model);

        int Delete(int id);

        IList<DangNhap> GetList();

        /// <summary>
        /// 根据主键获得Book
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DangNhap GetEntity(int id);

        DangNhap Login(string userName,string passWord);


        #endregion
    }
}
