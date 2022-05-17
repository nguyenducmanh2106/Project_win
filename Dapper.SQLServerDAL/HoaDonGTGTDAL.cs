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
    public class HoaDonGTGTDAL : IHoaDonGTGTDAL
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

        public int InsertTableHoaDonGTGT(HoaDonGTGT model)
        {
            using (Conn)
            {
                string sqlQuery = "INSERT INTO HoaDonGTGT(SOHD,NGAYLAP,KhachHangID,TKNOTHANHTOAN,TKCODOANHTHU,TKCOTHUE,TIENTHANHTOAN,TIENDOANHTHU,THUESUAT,TIENTHUE,TYLECK,TIENCK,TKCK,DIENGIAI,LOAITIEN) VALUES (@SOHD,@NGAYLAP,@KhachHangID,@TKNOTHANHTOAN,@TKCODOANHTHU,@TKCOTHUE,@TIENTHANHTOAN,@TIENDOANHTHU,@THUESUAT,@TIENTHUE,@TYLECK,@TIENCK,@TKCK,@DIENGIAI,@LOAITIEN)";
                return Conn.Execute(sqlQuery, new { SOHD = model.SOHD, NGAYLAP = model.NGAYLAP, KhachHangID = model.KhachHangID, TKNOTHANHTOAN = model.TKNOTHANHTOAN, TKCODOANHTHU = model.TKCODOANHTHU, TKCOTHUE = model.TKCOTHUE, TIENTHANHTOAN = model.TIENTHANHTOAN, TIENDOANHTHU = model.TIENDOANHTHU, TKCK = model.TKCK, DIENGIAI = model.DIENGIAI, LOAITIEN = model.LOAITIEN });
            }
        }

        public int Update(HoaDonGTGT model)
        {
            using (Conn)
            {
                string sqlQuery = "";
                return Conn.Execute(sqlQuery);
            }
        }

        public int Delete(HoaDonGTGT model)
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
                string sqlQuery = "DELETE FROM HANGHOA WHERE ID = @ID";
                return Conn.Execute(sqlQuery, new { ID = id });
            }
        }

        public IList<HoaDonGTGTModel> GetList(CoreModel obj)
        {
            using (Conn)
            {
                var param = obj.CustomData;
                DynamicParameters dynamicParameters = new DynamicParameters();
                foreach (var item in param)
                {
                    dynamicParameters.Add(item.Key, item.Value);
                }
                string sqlQuery = "sp_HoaDonGTGT_Grid";
                return Conn.Query<HoaDonGTGTModel>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }

        public HoaDonGTGTModel GetEntity(string code)
        {
            using (Conn)
            {

                string sqlQuery = "SELECT hh.*,ncc.TENNCC,ncc.MANCC from HANGHOA hh LEFT JOIN NCC ncc on hh.NhaCungCapID = ncc.ID WHERE hh.MAHH = @MAHH";
                return Conn.QueryFirst<HoaDonGTGTModel>(sqlQuery, new { MAHH = code });
            }
        }

        public int InsertTableChiTietHoaDonGTGT(CTHDGTGT model)
        {
            using (Conn)
            {
                string sqlQuery = "INSERT INTO CTHDGTGT(HangHoaID,HoaDonGTGT_ID,SOLUONG,DONGIA) VALUES (@HangHoaID,@HoaDonGTGT_ID,@SOLUONG,@DONGIA)";
                return Conn.Execute(sqlQuery, new { HangHoaID = model.HangHoaID, HoaDonGTGT_ID = model.HoaDonGTGT_ID, SOLUONG = model.SOLUONG, DONGIA = model.DONGIA });
            }
        }

        public IDbConnection GetDbConnection()
        {
            return Conn;
        }
        #endregion


    }
}