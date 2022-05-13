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
    public class DangNhapBLL : IDangNhapBLL
    {
        private static readonly IDangNhapDAL dal = DALFactory.CreateDangNhapDAL();

        public bool Insert(DangNhap model)
        {
            return dal.Insert(model) > 0 ? true : false;
        }

        public bool Update(DangNhap model)
        {
            return dal.Update(model) > 0 ? true : false;
        }

        public bool Delete(DangNhap model)
        {
            return dal.Delete(model) > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            return dal.Delete(id) > 0 ? true : false;
        }

        public IList<DangNhap> GetBookList()
        {
            return dal.GetList();
        }

        public DangNhap GetEntity(int id)
        {
            return dal.GetEntity(id);
        }

        public DangNhap Login(string userName, string passWord)
        {
            try
            {
                return dal.Login(userName, passWord);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
