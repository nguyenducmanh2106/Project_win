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
        int InsertTableHoaDonGTGT(HoaDonGTGT model);
        int InsertTableChiTietHoaDonGTGT(CTHDGTGT model);

        int Update(HoaDonGTGT model);

        int Delete(HoaDonGTGT model);

        int Delete(int id);

        IList<HoaDonGTGTModel> GetList(CoreModel obj);

        HoaDonGTGTModel GetEntity(string code);

        #endregion
    }
}
