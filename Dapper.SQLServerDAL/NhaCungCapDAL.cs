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
    public class NhaCungCapDAL : INhaCungCapDAL
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }

        #region CRUD using raw dapper

        public int Insert(NhaCungCap model)
        {
            using (Conn)
            {
                string sqlQuery = "INSERT INTO NCC(MANCC,TENNCC,DIACHI,SDT,EMAIL,NGUNGHOPTAC) VALUES (@MANCC,@TENNCC,@DIACHI,@SDT,@EMAIL,@NGUNGHOPTAC)";
                return Conn.Execute(sqlQuery, new { MANCC = model.MANCC, TENNCC = model.TENNCC, DIACHI = model.DIACHI, SDT = model.SDT, EMAIL = model.EMAIL, NGUNGHOPTAC = model.NGUNGHOPTAC });
            }
        }

        public int Update(NhaCungCap model)
        {
            using (Conn)
            {
                string sqlQuery = "UPDATE NCC SET MANCC = @MANCC,TENNCC=@TENNCC,DIACHI = @DIACHI,SDT = @SDT,EMAIL=@EMAIL,NGUNGHOPTAC=@NGUNGHOPTAC where ID = @ID";
                return Conn.Execute(sqlQuery, new { MANCC = model.MANCC, TENNCC = model.TENNCC, DIACHI = model.DIACHI, SDT = model.SDT, EMAIL = model.EMAIL, NGUNGHOPTAC = model.NGUNGHOPTAC, ID = model.ID });
            }
        }

        public int Delete(NhaCungCap model)
        {
            using (Conn)
            {
                string methodCurrent = new StackTrace().GetFrame(1).GetMethod().Name;
                string sqlQuery = JSONObject.GetQueryFromJSON($"SqlQuery/sql_query.json", nameof(DangNhap), methodCurrent);
                return Conn.Execute(sqlQuery, model);
            }
        }

        public int Delete(int id)
        {
            using (Conn)
            {
                string sqlQuery = "DELETE FROM NCC WHERE ID = @ID";
                return Conn.Execute(sqlQuery, new { ID = id });
            }
        }

        public IList<NhaCungCap> GetList(CoreModel obj)
        {
            using (Conn)
            {
                var param = obj.CustomData;
                DynamicParameters dynamicParameters = new DynamicParameters();
                foreach (var item in param)
                {
                    dynamicParameters.Add(item.Key, item.Value);
                }
                string sqlQuery = "sp_NhaCungCap_Grid";
                return Conn.Query<NhaCungCap>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }

        public IList<NhaCungCap> GetListActive()
        {
            using (Conn)
            {
                string sqlQuery = "SELECT ID,MANCC,TENNCC FROM NCC WHERE NGUNGHOPTAC = 1";
                return Conn.Query<NhaCungCap>(sqlQuery).ToList();
            }
        }
        #endregion


    }
}