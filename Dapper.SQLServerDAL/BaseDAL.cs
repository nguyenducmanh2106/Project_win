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
    public class BaseDAL : IBaseDAL
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        public T GenerationCode<T>(string tableName)
        {
            try
            {
                T result;
                string sqlQuery = $"SELECT * from {tableName} order by ID desc OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";
                using (Conn)
                {
                    result = Conn.Query<T>(sqlQuery).SingleOrDefault();
                    return result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region CRUD using raw dapper


        #endregion


    }
}