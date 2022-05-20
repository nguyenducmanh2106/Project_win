using Dapper;
using Dapper.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Factory;
using System.Data;
using Dapper.Model;
using DapperExtensions;
using DapperExtensions.Mapper;
using SV.HRM.Core.Utils;
using System.Reflection;
using System.Diagnostics;
using System.IO;

/*
 * create by ndmanh
 */

namespace Dapper.SQLServerDAL
{
    public class SoSachDAL : ISoSachDAL
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        public List<SoCaiChiTietModel> GetDataTableSoCaiTaiKhoan(CoreModel obj)
        {
            using (Conn)
            {
                try
                {
                    var param = obj.CustomData;
                    DynamicParameters dynamicParameters = new DynamicParameters();
                    foreach (var item in param)
                    {
                        dynamicParameters.Add(item.Key, item.Value);
                    }
                    string sqlQuery = "sp_SoCaiTaiKhoan";
                    return Conn.Query<SoCaiChiTietModel>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure)?.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IDbConnection GetDbConnection()
        {
            return this.Conn;
        }

        #region CRUD using raw dapper


        #endregion


    }
}