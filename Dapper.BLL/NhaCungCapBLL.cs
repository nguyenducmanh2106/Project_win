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
    public class NhaCungCapBLL : INhaCungCapBLL
    {
        private static readonly INhaCungCapDAL dal = DALFactory.CreateNhaCungCapDAL();

        public bool Insert(NhaCungCap model)
        {
            return dal.Insert(model) > 0 ? true : false;
        }

        public bool Update(NhaCungCap model)
        {
            return dal.Update(model) > 0 ? true : false;
        }

        public bool Delete(NhaCungCap model)
        {
            return dal.Delete(model) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<NhaCungCap> GetList(CoreModel obj)
        {
            return dal.GetList(obj);
        }

        public IList<NhaCungCap> GetListActive()
        {
            return dal.GetListActive();
        }
    }
}
