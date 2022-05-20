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
    public interface ISoSachDAL
    {
        #region CRUD
        IDbConnection GetDbConnection();
        List<SoCaiChiTietModel> GetDataTableSoCaiTaiKhoan(CoreModel obj);

        #endregion
    }
}
