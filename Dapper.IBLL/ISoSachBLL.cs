﻿using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

/*
 * create by 
 */

namespace Dapper.IBLL
{
    public interface ISoSachBLL
    {
        #region CRUD
        List<SoCaiChiTietModel> GetDataTableSoCaiTaiKhoan(CoreModel obj);

        #endregion
    }
}
