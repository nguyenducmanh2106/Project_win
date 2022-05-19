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
    public class DanhMucTaiKhoanDAL : IDanhMucTaiKhoanDAL
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

        public int Insert(DanhMucTaiKhoanKeToanModel model)
        {
            using (Conn)
            {
                string sqlQuery = "INSERT INTO DANHMUCTAIKHOAN(MATK,TENTK,CAPTK,TKCT) VALUES (@MATK,@TENTK,@CAPTK,@TKCT)";
                return Conn.Execute(sqlQuery, new { MATK = model.MATK, TENTK = model.TENTK, CAPTK = model.CAPTK, TKCT = model.TKCT });
            }
        }

        public int Update(DanhMucTaiKhoanKeToanModel model)
        {
            using (Conn)
            {
                string sqlQuery = "UPDATE DANHMUCTAIKHOAN SET MATK = @MATK,TENTK=@TENTK,CAPTK=@CAPTK,TKCT = @TKCT where ID = @ID";
                return Conn.Execute(sqlQuery, new { MATK = model.MATK, TENTK = model.TENTK, CAPTK = model.CAPTK, TKCT = model.TKCT, ID = model.ID });
            }
        }

        public int Delete(DanhMucTaiKhoanKeToanModel model)
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
                string sqlQuery = "DELETE FROM DANHMUCTAIKHOAN WHERE ID = @ID";
                return Conn.Execute(sqlQuery, new { ID = id });
            }
        }

        public IList<DanhMucTaiKhoanKeToanModel> GetList(CoreModel obj)
        {
            using (Conn)
            {
                var param = obj.CustomData;
                DynamicParameters dynamicParameters = new DynamicParameters();
                foreach (var item in param)
                {
                    dynamicParameters.Add(item.Key, item.Value);
                }
                string sqlQuery = "sp_DanhMucTaiKhoanKeToan_Grid";
                return Conn.Query<DanhMucTaiKhoanKeToanModel>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }

        public DanhMucTaiKhoanKeToanModel GetEntity(int id)
        {
            DanhMucTaiKhoanKeToanModel model;
            string sqlQuery = "SELECT * FROM DANHMUCTAIKHOAN WHERE ID = @ID";
            using (Conn)
            {
                model = Conn.Query<DanhMucTaiKhoanKeToanModel>(sqlQuery, new { ID = id })?.SingleOrDefault();
                return model;
            }
        }

        public IList<DanhMucTaiKhoanKeToanModel> GetListActive(int? id)
        {
            using (Conn)
            {
                string sqlQuery = "Select ID,CONCAT(TENTK,' (',MATK,')') as TENTK from DANHMUCTAIKHOAN WHERE (@ID is null or @ID = 0 or ID != @ID)";
                return Conn.Query<DanhMucTaiKhoanKeToanModel>(sqlQuery, new { ID = id })?.ToList();
            }
        }


        #endregion


    }
}