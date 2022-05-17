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
    public interface IKhachHangBLL
    {
        #region CRUD

        bool Insert(KhachHang book);

        bool Update(KhachHang book);

        bool Delete(KhachHang book);

        bool Delete(int id);

        IList<KhachHang> GetList(CoreModel obj);

        KhachHang GetEntity(int id);

        #endregion
    }
}
