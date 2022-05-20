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
    public class BaoCaoDAL : IBaoCaoDAL
    {
        private IDbConnection _conn;
        public IDbConnection Conn
        {
            get
            {
                return _conn = ConnectionFactory.CreateConnection();
            }
        }



        public IDbConnection GetDbConnection()
        {
            return this.Conn;
        }

        public List<BaoCaoDoanhThuTheoKhachHangModel> GetBaoCaoDoanhThuTheoKhachHang(CoreModel obj)
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
                    string sqlQuery = "sp_BaoCaoDoanhThuTheoKhachHang";
                    return Conn.Query<BaoCaoDoanhThuTheoKhachHangModel>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure)?.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<BaoCaoDoanhThuTheoHangHoaModel> GetBaoCaoDoanhThuTheoHangHoa(CoreModel obj)
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
                    string sqlQuery = "sp_BaoCaoDoanhThuTheoHangHoa";
                    return Conn.Query<BaoCaoDoanhThuTheoHangHoaModel>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure)?.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<BaoCaoGiamTruDoanhThuModel> GetBaoCaoGiamTruDoanhThu(CoreModel obj)
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
                    string sqlQuery = "sp_BaoCaoGiamTruDoanhThu";
                    return Conn.Query<BaoCaoGiamTruDoanhThuModel>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure)?.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<BaoCaoTongHopDoanhThuModel> GetBaoCaoTongHopDoanhThu(CoreModel obj)
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
                    string sqlQuery = "sp_BaoCaoTongHopDoanhThu";
                    return Conn.Query<BaoCaoTongHopDoanhThuModel>(sqlQuery, dynamicParameters, null, true, null, CommandType.StoredProcedure)?.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        #region CRUD using raw dapper


        #endregion


    }
}