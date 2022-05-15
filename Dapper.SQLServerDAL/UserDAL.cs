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
    public class UserDAL : IUserDAL
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

        public int Insert(DangNhap model)
        {
            using (Conn)
            {
                string sqlQuery = "INSERT INTO DANGNHAP(TENDANGNHAP,TENTK,MATKHAU,CAPTK,TRANGTHAI) VALUES (@TENDANGNHAP,@TENTK,@MATKHAU,@CAPTK,@TRANGTHAI)";
                return Conn.Execute(sqlQuery, new { TENDANGNHAP = model.TENDANGNHAP, TENTK = model.TENTK, MATKHAU = model.MATKHAU, CAPTK = model.CAPTK, TRANGTHAI = model.TRANGTHAI });
            }
        }

        public int Update(DangNhap model)
        {
            using (Conn)
            {
                string sqlQuery = "UPDATE DANGNHAP SET TENTK = @TENTK,CAPTK=@CAPTK,TRANGTHAI = @TRANGTHAI where TENDANGNHAP = @TENDANGNHAP";
                return Conn.Execute(sqlQuery, new { TENTK = model.TENTK,CAPTK = model.CAPTK,TRANGTHAI = model.TRANGTHAI, TENDANGNHAP = model.TENDANGNHAP });
            }
        }

        public int Delete(DangNhap model)
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
                string sqlQuery = "DELETE FROM DANGNHAP WHERE ID = @ID";
                return Conn.Execute(sqlQuery, new { ID = id });
            }
        }

        public IList<DangNhapGridView> GetList(CoreModel obj)
        {
            using (Conn)
            {
                var param = obj.CustomData;
                DynamicParameters dynamicParameters = new DynamicParameters();
                foreach(var item in param)
                {
                    dynamicParameters.Add(item.Key, item.Value);
                }
                string sqlQuery = "sp_DanhMucTaiKhoan_Grid";
                return Conn.Query<DangNhapGridView>(sqlQuery, dynamicParameters,null,true,null,CommandType.StoredProcedure).ToList();
            }
        }

        public DangNhap GetEntity(int id)
        {
            DangNhap book;
            string methodCurrent = new StackTrace().GetFrame(1).GetMethod().Name;
            string sqlQuery = JSONObject.GetQueryFromJSON($"SqlQuery/sql_query.json", nameof(DangNhap), methodCurrent);
            using (Conn)
            {
                book = Conn.Query<DangNhap>(sqlQuery, new { id = id })?.SingleOrDefault();
                return book;
            }
        }

        public DangNhap Login(string userName, string passWord)
        {
            using (Conn)
            {
                string methodCurrent = new StackTrace().GetFrame(1).GetMethod().Name;
                //string sqlQuery = JSONObject.GetQueryFromJSON($"SqlCommand/sql_query.json", nameof(DangNhap), methodCurrent);
                string sqlQuery = "Select * from DANGNHAP where TENDANGNHAP = @userName and MATKHAU = @passWord";
                return Conn.Query<DangNhap>(sqlQuery, new { userName = userName, passWord = passWord })?.SingleOrDefault();
            }
        }

        /// <summary>
        /// Update 1 vài thông tin user đang đăng nhập
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateUserLogin(DangNhap model)
        {
            using (Conn)
            {
                string sqlQuery = "UPDATE DANGNHAP set TENTK = @TENTK WHERE ID = @ID";
                return Conn.Execute(sqlQuery, new { TENTK = model.TENTK, ID = model.ID });
            }
        }

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int ChangePassWord(DangNhap model)
        {
            using (Conn)
            {
                string sqlQuery = "UPDATE DANGNHAP set MATKHAU = @MATKHAU WHERE ID = @ID and MATKHAU = @OldPass";
                return Conn.Execute(sqlQuery, new { MATKHAU = model.MATKHAU, ID = model.ID, OldPass = model.OldPassWord });
            }
        }


        #endregion


    }
}