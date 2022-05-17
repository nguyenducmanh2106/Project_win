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
    public class HangHoaBLL : IHangHoaBLL
    {
        private static readonly IHangHoaDAL dal = DALFactory.CreateHangHoaDAL();

        public bool Insert(HangHoa model)
        {
            return dal.Insert(model) > 0 ? true : false;
        }

        public bool Update(HangHoa model)
        {
            return dal.Update(model) > 0 ? true : false;
        }

        public bool Delete(HangHoa model)
        {
            return dal.Delete(model) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<HangHoaModel> GetList(CoreModel obj)
        {
            return dal.GetList(obj);
        }

        public HangHoaModel GetEntity(string code)
        {
            return dal.GetEntity(code);
        }

        public HangHoaModel GetEntity(int id)
        {
            return dal.GetEntity(id);
        }

        public IList<HangHoaModel> GetListCanUse()
        {
            return dal.GetListCanUse();
        }
    }
}
