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
    public interface IDangNhapBLL
    {
        #region CRUD

        bool Insert(DangNhap book);

        bool Update(DangNhap book);

        bool Delete(DangNhap book);

        bool Delete(int id);

        IList<DangNhap> GetBookList();

        DangNhap GetEntity(int id);

        DangNhap Login(string userName,string passWord);


        #endregion
    }
}
