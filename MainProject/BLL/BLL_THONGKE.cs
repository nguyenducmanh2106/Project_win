using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KETOANDOANHTHU.BLL
{
    class BLL_THONGKE
    {
        DAL data = new DAL();
        //------------------xử lý với THỐNG KÊ
        //hàm lấy thông tin thông tin bảng sp bán gồm (mã sp,tên sp,số lượng bán,đơn giá bán)
        public DataTable showTableProductSale()
        {
            string query = "select SANPHAM.TenSP,SANPHAM.MaSP,sum(CTPXUAT.SlXuat) as SlXuat,CTPXUAT.DgXuat"

                    + " from CTPXUAT inner join SANPHAM on CTPXUAT.MaSP=SANPHAM.MaSP"

                    + " group by SANPHAM.TenSP,SANPHAM.MaSP,CTPXUAT.DgXuat";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }

        // hàm lấy thông tin thông tin bảng sp nhập gồm(mã sp, tên sp, số lượng nhập, đơn giá nhập)
        public DataTable showTableProductImported()
        {
            string query = "select SANPHAM.TenSP,SANPHAM.MaSP,sum(CTPNHAP.SlNhap) as SlNhap,CTPNHAP.DgNhap"

                    + " from CTPNHAP inner join SANPHAM on CTPNHAP.MaSP=SANPHAM.MaSP"

                    + " group by SANPHAM.TenSP,SANPHAM.MaSP,CTPNHAP.DgNhap";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lọc dữ liệu theo năm tháng
        public DataTable getTableProductExportedWithMonthandYear(int month, int year)
        {
            string query1 = "select SANPHAM.TenSP,SANPHAM.MaSP,sum(CTPXUAT.SlXuat) as SlXuat,CTPXUAT.DgXuat"
                   + " from CTPXUAT inner join SANPHAM on CTPXUAT.MaSP=SANPHAM.MaSP inner join PXUAT on PXUAT.SoPx=CTPXUAT.SoPx where month(NgayXuat)=" + month + " and year(NgayXuat)=" + year + ""
                   + " group by SANPHAM.TenSP,SANPHAM.MaSP,CTPXUAT.DgXuat;";

            DataTable dt = new DataTable();
            dt = data.GetDataTable(query1);
            return dt;
        }
        public DataTable getTableProductImportedWithMonthandYear(int month, int year)
        {
            string query = "select SANPHAM.TenSP,SANPHAM.MaSP,sum(CTPNHAP.SlNhap) as SlNhap,CTPNHAP.DgNhap"
                    + " from CTPNHAP inner join SANPHAM on CTPNHAP.MaSP=SANPHAM.MaSP inner join PNHAP on PNHAP.SoPn=CTPNHAP.SoPn where month(NgayNhap)=" + month + " and year(NgayNhap)=" + year + ""
                    + " group by SANPHAM.TenSP,SANPHAM.MaSP,CTPNHAP.DgNhap;";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
    }
}
