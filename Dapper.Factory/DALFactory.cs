using Dapper.IDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

/*
 * create by
 */

namespace Dapper.Factory
{
    /// <summary>
    /// DAL factory，đọc key trong App.config
    /// </summary>
    public class DALFactory
    {
        private static readonly string path = ConfigurationManager.AppSettings["ConsoleDAL"];

        public DALFactory() { }

        public static IBookDAL CreateBookDAL()
        {
            try
            {
                string className = path + ".BookDAL";
                return (IBookDAL)Assembly.Load(path).CreateInstance(className);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static IBookReviewDAL CreateBookReviewDAL()
        {
            try
            {
                string className = path + ".BookReviewDAL";
                return (IBookReviewDAL)Assembly.Load(path).CreateInstance(className);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static IUserDAL CreateUserDAL()
        {
            try
            {
                string className = path + ".UserDAL";
                return (IUserDAL)Assembly.Load(path).CreateInstance(className);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IDanhMucTaiKhoanDAL CreateDanhMucTaiKhoanDAL()
        {
            try
            {
                string className = path + ".DanhMucTaiKhoanDAL";
                return (IDanhMucTaiKhoanDAL)Assembly.Load(path).CreateInstance(className);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static INhaCungCapDAL CreateNhaCungCapDAL()
        {
            try
            {
                string className = path + ".NhaCungCapDAL";
                return (INhaCungCapDAL)Assembly.Load(path).CreateInstance(className);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IKhachHangDAL CreateKhachHangDAL()
        {
            try
            {
                string className = path + ".KhachHangDAL";
                return (IKhachHangDAL)Assembly.Load(path).CreateInstance(className);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IHangHoaDAL CreateHangHoaDAL()
        {
            try
            {
                string className = path + ".HangHoaDAL";
                return (IHangHoaDAL)Assembly.Load(path).CreateInstance(className);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IHoaDonGTGTDAL CreateHoaDonGTGTDAL()
        {
            try
            {
                string className = path + ".HoaDonGTGTDAL";
                return (IHoaDonGTGTDAL)Assembly.Load(path).CreateInstance(className);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
