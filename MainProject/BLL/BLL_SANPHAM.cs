using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KETOANDOANHTHU.BLL
{
    class BLL_SANPHAM
    {
        DAL data = new DAL();
        //Quản lý sản phẩm
        //hàm lấy thông tin Xe đổ ra datagridview
        public DataTable showSanPham()
        {
            string query = "select * from SANPHAM";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy các mã Hãng xe cấp đổ ra combobox nhà cung cấp
        public DataTable getMaHangXe()
        {
            string query = "select * from HANGXE";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy Tìm Kiếm theo nhu cầu
        public DataTable searchByMaSP(String MaSP)
        {
            string query = "select * from SANPHAM where MaSP = '" + MaSP + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchByTenSP(String TenSP)
        {
            string query = "select * from SANPHAM where TenSP like N'%" + TenSP + "%'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchByMausac(String MauSac)
        {
            string query = "select * from SANPHAM where MauSac like N'%" + MauSac + "%'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm insert Sản Phẩm
        public void insertSANPHAM(string MaSP, string TenSP, string MauSac, string Loaixe, string Mahangxe)
        {
            string query = "insert into SANPHAM values('" + MaSP + "',N'" + TenSP + "',N'" + MauSac + "',N'" + Loaixe + "','" + Mahangxe + "'  )";
            data.executeNonQuery(query);
        }
        //hàm update Sản Phẩm
        public void updateSANPHAM(string MaSP, string TenSP, string MauSac, string Loaixe, string Mahangxe)
        {
            string query = "update SANPHAM set TenSP =N'" + TenSP + "', MauSac=N'" + MauSac + "' , Loaixe=N'" + Loaixe + "' , Mahangxe='" + Mahangxe + "' where MaSP='" + MaSP + "'";
            data.executeNonQuery(query);
        }

        //hàm xóa Sản Phẩm dựa vào MaSP truyền vào
        public void deleteSANPHAM(string MaSP)
        {
            string query = "delete from SANPHAM where MaSP='" + MaSP + "'";
            data.executeNonQuery(query);

        }
    }
}
