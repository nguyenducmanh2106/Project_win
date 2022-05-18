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
    public class HoaDonGTGTBLL : IHoaDonGTGTBLL
    {
        private static readonly IHoaDonGTGTDAL dal = DALFactory.CreateHoaDonGTGTDAL();

        public bool Insert(HoaDonGTGT model, List<CTHDGTGT> modelChiTiet)
        {
            using (TransactionScope scope = new TransactionScope())
            using (var conn = dal.GetDbConnection())
            {
                try
                {
                    var insertTableHoaDonGTGT = dal.InsertTableHoaDonGTGT(model);
                    int recordInsertedChiTietHoaDonGTGT = 0;
                    if (insertTableHoaDonGTGT != null)
                    {
                        modelChiTiet.ForEach(c => c.HoaDonGTGT_ID = insertTableHoaDonGTGT.ID);
                        recordInsertedChiTietHoaDonGTGT = dal.InsertTableChiTietHoaDonGTGT(modelChiTiet);
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

        public bool Update(HoaDonGTGT model, List<CTHDGTGT> modelChiTiet)
        {
            using (TransactionScope scope = new TransactionScope())
            using (var conn = dal.GetDbConnection())
            {
                try
                {
                    var insertTableHoaDonGTGT = dal.UpdateTableHoaDonGTGT(model);
                    int recordInsertedChiTietHoaDonGTGT = 0;
                    if (insertTableHoaDonGTGT > 0)
                    {
                        int resultDeleteTableChiTietHoaDonGTGT = dal.DeleteTableChiTietHoaDonGTGT(model.ID);
                        modelChiTiet.ForEach(c => c.HoaDonGTGT_ID = model.ID);
                        recordInsertedChiTietHoaDonGTGT = dal.InsertTableChiTietHoaDonGTGT(modelChiTiet);
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

        public bool Delete(HoaDonGTGT model)
        {
            return dal.Delete(model) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<HoaDonGTGTModel> GetList(CoreModel obj)
        {
            return dal.GetList(obj);
        }

        public HoaDonGTGTDetail GetEntity(string code)
        {
            return dal.GetEntity(code);
        }

        public HoaDonGTGTDetail GetEntity(int id)
        {
            return dal.GetEntity(id);
        }
    }
}
