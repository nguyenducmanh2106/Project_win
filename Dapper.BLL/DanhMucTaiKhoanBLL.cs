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
    public class DanhMucTaiKhoanBLL : IDanhMucTaiKhoanBLL
    {
        private static readonly IDanhMucTaiKhoanDAL dal = DALFactory.CreateDanhMucTaiKhoanDAL();

        public bool Insert(DanhMucTaiKhoanKeToanModel model)
        {
            return dal.Insert(model) > 0 ? true : false;
        }

        public bool Update(DanhMucTaiKhoanKeToanModel model)
        {
            return dal.Update(model) > 0 ? true : false;
        }

        public bool Delete(DanhMucTaiKhoanKeToanModel model)
        {
            return dal.Delete(model) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<DanhMucTaiKhoanKeToanModel> GetList(CoreModel obj)
        {
            return dal.GetList(obj);
        }

        public DanhMucTaiKhoanKeToanModel GetEntity(int id)
        {
            return dal.GetEntity(id);
        }


        public IList<DanhMucTaiKhoanKeToanModel> GetListActive()
        {
            try
            {
                return dal.GetListActive();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
