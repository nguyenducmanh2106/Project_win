using Dapper.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Model;
using Dapper.IDAL;
using Dapper.Factory;

/*
 * create by
 */

namespace Dapper.BLL
{
    public class HoaDonGTGTBLL : IHoaDonGTGTBLL
    {
        private static readonly IHoaDonGTGTDAL dal = DALFactory.CreateHoaDonGTGTDAL();

        public bool Insert(HoaDonGTGT model, CTHDGTGT modelChiTiet)
        {
            using (var trans = dal.GetDbConnection().BeginTransaction())
            {
                try
                {
                    var insertTableHoaDonGTGT = dal.InsertTableHoaDonGTGT(model);
                    int recordInsertedChiTietHoaDonGTGT = 0;
                    if (insertTableHoaDonGTGT > 0)
                    {
                        recordInsertedChiTietHoaDonGTGT = dal.InsertTableChiTietHoaDonGTGT(modelChiTiet);
                        trans.Commit();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return false;
                }
            }

        }

        public bool Update(HoaDonGTGT model)
        {
            return dal.Update(model) > 0 ? true : false;
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

        public HoaDonGTGTModel GetEntity(string code)
        {
            return dal.GetEntity(code);
        }
    }
}
