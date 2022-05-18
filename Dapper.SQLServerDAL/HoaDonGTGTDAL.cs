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
using System.Data.SqlClient;

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

        public HoaDonGTGT InsertTableHoaDonGTGT(HoaDonGTGT model)
        {
            try
            {
                string sqlQuery = "INSERT INTO HoaDonGTGT(SOHD,NGAYLAP,KhachHangID,TKNOTHANHTOAN,TKCODOANHTHU,TKCOTHUE,TIENTHANHTOAN,TIENDOANHTHU,TKCK,DIENGIAI,LOAITIEN,TONGTIENCK,TONGTIENTHUE) OUTPUT INSERTED.ID VALUES (@SOHD,@NGAYLAP,@KhachHangID,@TKNOTHANHTOAN,@TKCODOANHTHU,@TKCOTHUE,@TIENTHANHTOAN,@TIENDOANHTHU,@TKCK,@DIENGIAI,@LOAITIEN,@TONGTIENCK,@TONGTIENTHUE)";
                HoaDonGTGT result = Conn.QueryFirst<HoaDonGTGT>(sqlQuery, new { SOHD = model.SOHD, NGAYLAP = model.NGAYLAP, KhachHangID = model.KhachHangID, TKNOTHANHTOAN = model.TKNOTHANHTOAN, TKCODOANHTHU = model.TKCODOANHTHU, TKCOTHUE = model.TKCOTHUE, TIENTHANHTOAN = model.TIENTHANHTOAN, TIENDOANHTHU = model.TIENDOANHTHU, TKCK = model.TKCK, DIENGIAI = model.DIENGIAI, LOAITIEN = model.LOAITIEN, TONGTIENCK = model.TONGTIENCK, TONGTIENTHUE = model.TONGTIENTHUE });
                return result;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    throw new Exception("Mã hóa đơn đã tồn tại");
                }
            }
            return default;
        }

        public int UpdateTableHoaDonGTGT(HoaDonGTGT model)
        {
            try
            {
                string sqlQuery = "UPDATE HOADONGTGT SET SOHD= @SOHD,NGAYLAP = @NGAYLAP,KhachHangID = @KhachHangID,TKNOTHANHTOAN = @TKNOTHANHTOAN,TKCODOANHTHU=@TKCODOANHTHU,TKCOTHUE=@TKCOTHUE,TIENDOANHTHU=@TIENDOANHTHU,TIENTHANHTOAN=@TIENTHANHTOAN,TKCK=@TKCK,DIENGIAI=@DIENGIAI,LOAITIEN=@LOAITIEN,TONGTIENCK=@TONGTIENCK,TONGTIENTHUE=@TONGTIENTHUE WHERE ID = @ID";
                int result = Conn.Execute(sqlQuery, new { SOHD = model.SOHD, NGAYLAP = model.NGAYLAP, KhachHangID = model.KhachHangID, TKNOTHANHTOAN = model.TKNOTHANHTOAN, TKCODOANHTHU = model.TKCODOANHTHU, TKCOTHUE = model.TKCOTHUE, TIENTHANHTOAN = model.TIENTHANHTOAN, TIENDOANHTHU = model.TIENDOANHTHU, TKCK = model.TKCK, DIENGIAI = model.DIENGIAI, LOAITIEN = model.LOAITIEN, TONGTIENCK = model.TONGTIENCK, TONGTIENTHUE = model.TONGTIENTHUE, ID = model.ID });
                return result;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    throw new Exception("Mã hóa đơn đã tồn tại");
                }
            }
            return default;
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

        public int DeleteTableChiTietHoaDonGTGT(int HoaDonGTGT_ID)
        {
            using (Conn)
            {
                string sqlQuery = "DELETE FROM CTHDGTGT WHERE HoaDonGTGT_ID=@HoaDonGTGT_ID";
                return Conn.Execute(sqlQuery, new { HoaDonGTGT_ID = HoaDonGTGT_ID });
            }
        }

        public int Delete(int id)
        {
            using (Conn)
            {
                string sqlQuery = "DELETE FROM HOADONGTGT WHERE ID = @ID;DELETE FROM CTHDGTGT WHERE HoaDonGTGT_ID = @ID";
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

        public HoaDonGTGTDetail GetEntity(string code)
        {
            using (Conn)
            {

                string sqlQuery = "select *,(select ct.*,ct.HangHoaID as MAHH,hh.TENHH,hh.DVT,hh.SOLUONG as KHO,(ct.SOLUONG* ct.DONGIA-TIENCK + TIENTHUE) as THANHTIEN from HOADONGTGT hd left join CTHDGTGT ct on hd.ID = ct.HoaDonGTGT_ID left join HANGHOA hh on ct.HangHoaID = hh.ID where hd.SOHD = @SOHD FOR JSON PATH) as ChiTiet from HOADONGTGT hd where hd.SOHD = @SOHD";
                return Conn.QueryFirst<HoaDonGTGTDetail>(sqlQuery, new { SOHD = code });
            }
        }

        public int InsertTableChiTietHoaDonGTGT(List<CTHDGTGT> models)
        {
            using (Conn)
            {
                var objectParams = new object[models.Count];
                for (var index = 0; index < models.Count; index++)
                {
                    var model = models[index];
                    objectParams[index] = new
                    {
                        HangHoaID = model.HangHoaID,
                        HoaDonGTGT_ID = model.HoaDonGTGT_ID,
                        SOLUONG = model.SOLUONG,
                        DONGIA = model.DONGIA,
                        TYLECK = model.TYLECK,
                        TIENCK = model.TIENCK,
                        THUESUAT = model.THUESUAT,
                        TIENTHUE = model.TIENTHUE,
                    };
                }
                string sqlQuery = "INSERT INTO CTHDGTGT(HangHoaID,HoaDonGTGT_ID,SOLUONG,DONGIA,TYLECK,TIENCK,THUESUAT,TIENTHUE) VALUES (@HangHoaID,@HoaDonGTGT_ID,@SOLUONG,@DONGIA,@TYLECK,@TIENCK,@THUESUAT,@TIENTHUE)";
                return Conn.Execute(sqlQuery, objectParams);
            }
        }

        public IDbConnection GetDbConnection()
        {
            return Conn;
        }

        public HoaDonGTGTDetail GetEntity(int id)
        {
            using (Conn)
            {
                string sqlQuery = "select *,(select ct.* from HOADONGTGT hd left join CTHDGTGT ct on hd.ID = ct.HoaDonGTGT_ID where hd.ID = @ID FOR JSON AUTO) as ChiTietHoaDonGTGT from HOADONGTGT hd where hd.ID = @ID";
                return Conn.QueryFirst<HoaDonGTGTDetail>(sqlQuery, new { ID = id });
            }
        }
        #endregion


    }
}