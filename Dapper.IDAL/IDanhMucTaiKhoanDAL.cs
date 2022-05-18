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
    public interface IDanhMucTaiKhoanDAL
    {
        #region CRUD

        int Insert(DanhMucTaiKhoanKeToanModel model);

        int Update(DanhMucTaiKhoanKeToanModel model);

        int Delete(DanhMucTaiKhoanKeToanModel model);

        int Delete(int id);

        IList<DanhMucTaiKhoanKeToanModel> GetList(CoreModel obj);

        IList<DanhMucTaiKhoanKeToanModel> GetListActive();

        /// <summary>
        /// DANGNHAP
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DanhMucTaiKhoanKeToanModel GetEntity(int id);
        #endregion
    }
}
