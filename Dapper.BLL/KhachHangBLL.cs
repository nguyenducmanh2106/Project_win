using Dapper.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Model;
using Dapper.IDAL;
using Dapper.Factory;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.BLL
{
    public class KhachHangBLL : IKhachHangBLL
    {
        private static readonly IKhachHangDAL dal = DALFactory.CreateKhachHangDAL();

        public bool Insert(KhachHang model)
        {
            return dal.Insert(model) > 0 ? true : false;
        }

        public bool Update(KhachHang model)
        {
            return dal.Update(model) > 0 ? true : false;
        }

        public bool Delete(KhachHang model)
        {
            return dal.Delete(model) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<KhachHang> GetList(CoreModel obj)
        {
            return dal.GetList(obj);
        }

    }
}
