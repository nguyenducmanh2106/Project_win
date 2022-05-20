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
    public class PhieuGiamGiaDAL : IPhieuGiamGiaDAL
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

        public PhieuGiamGiaModel InsertTablePhieuGiamGia(PhieuGiamGiaModel model)
        {
            try
            {
                string sqlQuery = "INSERT INTO PhieuGiamGia(SOHD,NGAYLAP,KhachHangID,TKNOGIAMTRU,TKNOTHUE,TKCOTHANHTOAN,TIENTHANHTOAN,TIENDOANHTHU,TKCK,DIENGIAI,LOAITIEN,TONGTIENCK,TONGTIENTHUE) OUTPUT INSERTED.ID VALUES (@SOHD,@NGAYLAP,@KhachHangID,@TKNOGIAMTRU,@TKNOTHUE,@TKCOTHANHTOAN,@TIENTHANHTOAN,@TIENDOANHTHU,@TKCK,@DIENGIAI,@LOAITIEN,@TONGTIENCK,@TONGTIENTHUE)";
                PhieuGiamGiaModel result = Conn.QueryFirst<PhieuGiamGiaModel>(sqlQuery, new { SOHD = model.SOHD, NGAYLAP = model.NGAYLAP, KhachHangID = model.KhachHangID, TKNOGIAMTRU = model.TKNOGIAMTRU, TKNOTHUE = model.TKNOTHUE, TKCOTHANHTOAN = model.TKCOTHANHTOAN, TIENTHANHTOAN = model.TIENTHANHTOAN, TIENDOANHTHU = model.TIENDOANHTHU, TKCK = model.TKCK, DIENGIAI = model.DIENGIAI, LOAITIEN = model.LOAITIEN, TONGTIENCK = model.TONGTIENCK, TONGTIENTHUE = model.TONGTIENTHUE });
                return result;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    throw new Exception("Mã phiếu giảm giá đã tồn tại");
                }
            }
            return default;
        }

        public int UpdateTablePhieuGiamGia(PhieuGiamGiaModel model)
        {
            try
            {
                string sqlQuery = "UPDATE PhieuGiamGia SET SOHD= @SOHD,NGAYLAP = @NGAYLAP,KhachHangID = @KhachHangID,TKNOGIAMTRU = @TKNOGIAMTRU,TKNOTHUE = @TKNOTHUE,TKCOTHANHTOAN = @TKCOTHANHTOAN,TIENTHANHTOAN=@TIENTHANHTOAN,TIENDOANHTHU = @TIENDOANHTHU,TKCK=@TKCK,LOAITIEN=@LOAITIEN,TONGTIENCK=@TONGTIENCK,TONGTIENTHUE=@TONGTIENTHUE,DIENGIAI=@DIENGIAI WHERE ID = @ID";
                int result = Conn.Execute(sqlQuery, new { SOHD = model.SOHD, NGAYLAP = model.NGAYLAP, KhachHangID = model.KhachHangID, TKNOGIAMTRU = model.TKNOGIAMTRU, TKNOTHUE = model.TKNOTHUE, TKCOTHANHTOAN = model.TKCOTHANHTOAN, TIENTHANHTOAN = model.TIENTHANHTOAN, TIENDOANHTHU = model.TIENDOANHTHU, TKCK = model.TKCK, DIENGIAI = model.DIENGIAI, LOAITIEN = model.LOAITIEN, TONGTIENCK = model.TONGTIENCK, TONGTIENTHUE = model.TONGTIENTHUE, ID = model.ID });
                return result;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601)
                {
                    throw new Exception("Mã phiếu giảm giá đã tồn tại");
                }
            }
            return default;
        }

        public int Delete(PhieuGiamGiaModel model)
        {
            using (Conn)
            {
                string methodCurrent = new StackTrace().GetFrame(1).GetMethod().Name;
                string sqlQuery = JSONObject.GetQueryFromJSON($"SqlQuery/sql_query.json", nameof(PhieuGiamGiaModel), methodCurrent);
                return Conn.Execute(sqlQuery, model);
            }
        }

        public int DeleteTableChiTietPhieuGiamGia(int PhieuGiamGia_ID)
        {
            using (Conn)
            {
                string sqlQuery = "DELETE FROM CTPGG WHERE PhieuGiamGia_ID=@PhieuGiamGia_ID";
                return Conn.Execute(sqlQuery, new { PhieuGiamGia_ID = PhieuGiamGia_ID });
            }
        }

        public int Delete(int id)
        {
            using (Conn)
            {
                string sqlQuery = "DELETE FROM PhieuGiamGia WHERE ID = @ID;DELETE FROM CTPGG WHERE PhieuGiamGia_ID = @ID";
                return Conn.Execute(sqlQuery, new { ID = id });
            }
        }

        public IList<PhieuGiamGiaModel> GetList(CoreModel obj)
        {
            using (Conn)
            {
                var param = obj.CustomData;
                DynamicParameters dynamicParameters = new DynamicParameters();
                foreach (var item in param)
                {
                    dynamicParameters.Add(item.Key, item.Value);
                }
                string sqlQuery = "sp_PhieuGiamGia_Grid";
                return Conn.Query<PhieuGiamGiaModel>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }

        public PhieuGiamGiaDetail GetEntity(string code)
        {
            using (Conn)
            {
                PhieuGiamGiaDetail result = new PhieuGiamGiaDetail();
                string sqlQuery = "select *,(select ct.*,ct.HangHoaID as MAHH,hh.TENHH,hh.DVT,hh.SOLUONG as KHO,(ct.SOLUONG* ct.DONGIA-TIENCK + TIENTHUE) as THANHTIEN from PhieuGiamGia hd left join CTPGG ct on hd.ID = ct.PhieuGiamGia_ID left join HANGHOA hh on ct.HangHoaID = hh.ID where hd.SOHD = @SOHD FOR JSON PATH) as ChiTiet from PhieuGiamGia hd where hd.SOHD = @SOHD";
                result = Conn.QueryFirst<PhieuGiamGiaDetail>(sqlQuery, new { SOHD = code });
                return result;
            }
        }

        public int InsertTableChiTietPhieuGiamGia(List<CTPGG> models)
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
                        PhieuGiamGia_ID = model.PhieuGiamGia_ID,
                        SOLUONG = model.SOLUONG,
                        DONGIA = model.DONGIA,
                        TYLECK = model.TYLECK,
                        TIENCK = model.TIENCK,
                        THUESUAT = model.THUESUAT,
                        TIENTHUE = model.TIENTHUE,
                    };
                }
                string sqlQuery = "INSERT INTO CTPGG(HangHoaID,PhieuGiamGia_ID,SOLUONG,DONGIA,TYLECK,TIENCK,THUESUAT,TIENTHUE) VALUES (@HangHoaID,@PhieuGiamGia_ID,@SOLUONG,@DONGIA,@TYLECK,@TIENCK,@THUESUAT,@TIENTHUE)";
                return Conn.Execute(sqlQuery, objectParams);
            }
        }

        public IDbConnection GetDbConnection()
        {
            return Conn;
        }

        public PhieuGiamGiaDetail GetEntity(int id)
        {
            using (Conn)
            {
                PhieuGiamGiaDetail result = new PhieuGiamGiaDetail();
                string sqlQuery = "select *,(select ct.*,ct.HangHoaID as MAHH,hh.TENHH,hh.DVT,hh.SOLUONG as KHO,(ct.SOLUONG* ct.DONGIA-TIENCK + TIENTHUE) as THANHTIEN from PhieuGiamGia hd left join CTPGG ct on hd.ID = ct.PhieuGiamGia_ID left join HANGHOA hh on ct.HangHoaID = hh.ID where hd.ID = @ID FOR JSON PATH) as ChiTiet from PhieuGiamGia hd where hd.ID = @ID";
                result = Conn.QueryFirst<PhieuGiamGiaDetail>(sqlQuery, new { ID = id });
                return result;
            }
        }
        #endregion


    }
}