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
    public interface IDanhMucTaiKhoanBLL
    {
        #region CRUD

        bool Insert(DanhMucTaiKhoanKeToanModel book);

        bool Update(DanhMucTaiKhoanKeToanModel book);

        bool Delete(DanhMucTaiKhoanKeToanModel book);

        bool Delete(int id);

        IList<DanhMucTaiKhoanKeToanModel> GetList(CoreModel obj);
        IList<DanhMucTaiKhoanKeToanModel> GetListActive(int? id);

        DanhMucTaiKhoanKeToanModel GetEntity(int id);
        #endregion
    }
}
