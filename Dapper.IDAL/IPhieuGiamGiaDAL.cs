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
    public interface IPhieuGiamGiaDAL
    {
        #region CRUD
        IDbConnection GetDbConnection();
        PhieuGiamGiaModel InsertTablePhieuGiamGia(PhieuGiamGiaModel model);
        int InsertTableChiTietPhieuGiamGia(List<CTPGG> model);

        int UpdateTablePhieuGiamGia(PhieuGiamGiaModel model);

        int Delete(PhieuGiamGiaModel model);

        int Delete(int id);

        IList<PhieuGiamGiaModel> GetList(CoreModel obj);

        PhieuGiamGiaDetail GetEntity(string code);
        PhieuGiamGiaDetail GetEntity(int id);

        int DeleteTableChiTietPhieuGiamGia(int HoaDonGTGT_ID);

        #endregion
    }
}
