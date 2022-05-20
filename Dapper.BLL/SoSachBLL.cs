using Dapper.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Model;
using Dapper.IDAL;
using Dapper.Factory;
using System.Data;

/*
 * create by
 */

namespace Dapper.BLL
{
    public class SoSachBLL : ISoSachBLL
    {
        private static readonly ISoSachDAL dal = DALFactory.CreateSoSachDAL();

        public List<SoCaiChiTietModel> GetDataTableSoCaiTaiKhoan(CoreModel obj)
        {
            return dal.GetDataTableSoCaiTaiKhoan(obj);
        }
    }
}
