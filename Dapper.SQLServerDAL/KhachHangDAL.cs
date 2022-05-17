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
    public class KhachHangDAL : IKhachHangDAL
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

        public int Insert(KhachHang model)
        {
            using (Conn)
            {
                string sqlQuery = "INSERT INTO KHACHHANG(MAKH,TENKH,DIACHI,SDT,EMAIL,MST,NGAYDANGKY) VALUES (@MAKH,@TENKH,@DIACHI,@SDT,@EMAIL,@MST,@NGAYDANGKY)";
                return Conn.Execute(sqlQuery, new { MAKH = model.MAKH, TENKH = model.TENKH, DIACHI = model.DIACHI, SDT = model.SDT, EMAIL = model.EMAIL, MST = model.MST, NGAYDANGKY = model.NGAYDANGKY });
            }
        }

        public int Update(KhachHang model)
        {
            using (Conn)
            {
                string sqlQuery = "UPDATE KHACHHANG SET MAKH = @MAKH,TENKH=@TENKH,DIACHI = @DIACHI,SDT = @SDT,EMAIL=@EMAIL,MST=@MST,NGAYDANGKY = @NGAYDANGKY where ID = @ID";
                return Conn.Execute(sqlQuery, new { MAKH = model.MAKH, TENKH = model.TENKH, DIACHI = model.DIACHI, SDT = model.SDT, EMAIL = model.EMAIL, MST = model.MST, NGAYDANGKY = model.NGAYDANGKY, ID = model.ID });
            }
        }

        public int Delete(KhachHang model)
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
                string sqlQuery = "DELETE FROM KHACHHANG WHERE ID = @ID";
                return Conn.Execute(sqlQuery, new { ID = id });
            }
        }

        public IList<KhachHang> GetList(CoreModel obj)
        {
            using (Conn)
            {
                var param = obj.CustomData;
                DynamicParameters dynamicParameters = new DynamicParameters();
                foreach (var item in param)
                {
                    dynamicParameters.Add(item.Key, item.Value);
                }
                string sqlQuery = "sp_KhachHang_Grid";
                return Conn.Query<KhachHang>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }

        public KhachHang GetEntity(int id)
        {
            using (Conn)
            {
                string sqlQuery = "Select * from KHACHHANG WHERE ID = @ID";
                return Conn.QuerySingle<KhachHang>(sqlQuery, new { ID = id });
            }
        }
        #endregion


    }
}