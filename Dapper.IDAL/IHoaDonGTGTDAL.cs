using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

/*
 * create by 
 */

namespace Dapper.IDAL
{
    public interface IHoaDonGTGTDAL
    {
        #region CRUD
        IDbConnection GetDbConnection();
        HoaDonGTGT InsertTableHoaDonGTGT(HoaDonGTGT model);
        int InsertTableChiTietHoaDonGTGT(List<CTHDGTGT> model);

        int UpdateTableHoaDonGTGT(HoaDonGTGT model);

        int Delete(HoaDonGTGT model);

        int Delete(int id);

        IList<HoaDonGTGTModel> GetList(CoreModel obj);

        HoaDonGTGTDetail GetEntity(string code);
        HoaDonGTGTDetail GetEntity(int id);

        int DeleteTableChiTietHoaDonGTGT(int HoaDonGTGT_ID);

        #endregion
    }
}
