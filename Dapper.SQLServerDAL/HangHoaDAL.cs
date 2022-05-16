﻿using Dapper;
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
    public class HangHoaDAL : IHangHoaDAL
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

        public int Insert(HangHoa model)
        {
            using (Conn)
            {
                string sqlQuery = "INSERT INTO HANGHOA(MAHH,TENHH,DVT,NhaCungCapID,SOLUONG,GIAXUAT,GIANHAP,HINHANH) VALUES (@MAHH,@TENHH,@DVT,@NhaCungCapID,@SOLUONG,@GIAXUAT,@GIANHAP,@HINHANH)";
                return Conn.Execute(sqlQuery, new { MAHH = model.MAHH, TENHH = model.TENHH, DVT = model.DVT, NhaCungCapID = model.NhaCungCapID, SOLUONG = model.SOLUONG, GIAXUAT = model.GIAXUAT, GIANHAP = model.GIANHAP, HINHANH = model.HINHANH });
            }
        }

        public int Update(HangHoa model)
        {
            using (Conn)
            {
                string sqlQuery = "UPDATE HANGHOA SET MAHH = @MAHH,TENHH=@TENHH,DVT = @DVT,NhaCungCapID = @NhaCungCapID,SOLUONG=@SOLUONG,GIAXUAT=@GIAXUAT,GIANHAP = @GIANHAP,HINHANH = @HINHANH where ID = @ID";
                return Conn.Execute(sqlQuery, new { MAHH = model.MAHH, TENHH = model.TENHH, DVT = model.DVT, NhaCungCapID = model.NhaCungCapID, SOLUONG = model.SOLUONG, GIAXUAT = model.GIAXUAT, GIANHAP = model.GIANHAP, HINHANH = model.HINHANH, ID = model.ID });
            }
        }

        public int Delete(HangHoa model)
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

        public IList<HangHoaModel> GetList(CoreModel obj)
        {
            using (Conn)
            {
                var param = obj.CustomData;
                DynamicParameters dynamicParameters = new DynamicParameters();
                foreach(var item in param)
                {
                    dynamicParameters.Add(item.Key, item.Value);
                }
                string sqlQuery = "sp_HangHoa_Grid";
                return Conn.Query<HangHoaModel>(sqlQuery, dynamicParameters,null,true,null,CommandType.StoredProcedure).ToList();
            }
        }
        #endregion


    }
}