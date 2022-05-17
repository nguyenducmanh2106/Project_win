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
    public interface IKhachHangDAL
    {
        #region CRUD

        int Insert(KhachHang model);

        int Update(KhachHang model);

        int Delete(KhachHang model);

        int Delete(int id);

        IList<KhachHang> GetList(CoreModel obj);

        /// <summary>
        /// Lấy bản ghi theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        KhachHang GetEntity(int id);

        #endregion
    }
}
