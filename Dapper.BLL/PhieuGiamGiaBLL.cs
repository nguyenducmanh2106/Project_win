using Dapper.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Model;
using Dapper.IDAL;
using Dapper.Factory;
using System.Transactions;

/*
 * create by
 */

namespace Dapper.BLL
{
    public class PhieuGiamGiaBLL : IPhieuGiamGiaBLL
    {
        private static readonly IPhieuGiamGiaDAL dal = DALFactory.CreatePhieuGiamGiaDAL();

        public bool Insert(PhieuGiamGiaModel model, List<CTPGG> modelChiTiet)
        {
            using (TransactionScope scope = new TransactionScope())
            using (var conn = dal.GetDbConnection())
            {
                try
                {
                    var insertTablePhieuGiamGia = dal.InsertTablePhieuGiamGia(model);
                    int recordInsertedChiTietHoaDonGTGT = 0;
                    if (insertTablePhieuGiamGia != null)
                    {
                        modelChiTiet.ForEach(c => c.PhieuGiamGia_ID = insertTablePhieuGiamGia.ID);
                        recordInsertedChiTietHoaDonGTGT = dal.InsertTableChiTietPhieuGiamGia(modelChiTiet);
                        //trans.Commit();
                        scope.Complete();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    //trans.Rollback();
                    conn.BeginTransaction().Rollback();
                    throw ex;
                }
            }

        }

        public bool Update(PhieuGiamGiaModel model, List<CTPGG> modelChiTiet)
        {
            using (TransactionScope scope = new TransactionScope())
            using (var conn = dal.GetDbConnection())
            {
                try
                {
                    var insertTableHoaDonGTGT = dal.UpdateTablePhieuGiamGia(model);
                    int recordInsertedChiTietHoaDonGTGT = 0;
                    if (insertTableHoaDonGTGT > 0)
                    {
                        int resultDeleteTableChiTietHoaDonGTGT = dal.DeleteTableChiTietPhieuGiamGia(model.ID);
                        modelChiTiet.ForEach(c => c.PhieuGiamGia_ID = model.ID);
                        recordInsertedChiTietHoaDonGTGT = dal.InsertTableChiTietPhieuGiamGia(modelChiTiet);
                        //trans.Commit();
                        scope.Complete();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    //trans.Rollback();
                    conn.BeginTransaction().Rollback();
                    throw ex;
                }
            }
        }

        public bool Delete(PhieuGiamGiaModel model)
        {
            return dal.Delete(model) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<PhieuGiamGiaModel> GetList(CoreModel obj)
        {
            return dal.GetList(obj);
        }

        public PhieuGiamGiaDetail GetEntity(string code)
        {
            return dal.GetEntity(code);
        }

        public PhieuGiamGiaDetail GetEntity(int id)
        {
            return dal.GetEntity(id);
        }
    }
}
