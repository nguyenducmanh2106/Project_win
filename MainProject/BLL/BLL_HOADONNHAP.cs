using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KETOANDOANHTHU.BLL
{
    class BLL_HOADONNHAP
    {
        DAL data = new DAL();
        //xử lý với bảng hóa đơn nhập
        //hàm lấy thông tin về bảng hóa đơn nhập đổ ra datagridview
        public DataTable showHoaDonNhap()
        {
            string query = "select * from PNHAP";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy các mã nhà cung cấp đổ ra combobox nhà cung cấp
        public DataTable getMaNCC()
        {
            string query = "select * from NHACC";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm insert hóa đơn nhập
        public void insertHoaDonNhap(string soPhieu, string ngay, string maKh)
        {
            string query = "insert into PNHAP values('" + soPhieu + "','" + ngay + "','" + maKh + "'  )";
            data.executeNonQuery(query);
        }
        //hàm update hóa đơn nhập
        public void updateHoaDonNhap(string soPhieu, string ngay, string maKh)
        {
            string query = "update PNHAP set NgayNhap='" + ngay + "', MaNhaCc='" + maKh + "' where SoPn='" + soPhieu + "'";
            data.executeNonQuery(query);
        }
        //hàm xóa hóa đơn nhập dựa vào số phiếu truyền vào
        public void deleteHoaDonNhap(string soPhieu)
        {
            string query = "delete from PNHAP where SoPn='" + soPhieu + "'";
            data.executeNonQuery(query);
        }
        //hàm tìm hóa đơn nhập với số phiếu truyền vào
        public DataTable searchHoaDonNhap(string soPhieu)
        {
            string query = "select * from PNHAP where SoPn='" + soPhieu + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lọc các bản ghi hóa đơn nhập với ngày bd và ngày kt truyền vào
        public DataTable searchHoaDonNhapWithDate(string ngayBd, string ngayKt)
        {
            string query = "select * from PNHAP where NgayNhap between convert(date,'" + ngayBd + "') and convert(date,'" + ngayKt + "')";

            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }

        //-----------xử lý với chi tiết hóa đơn nhập
        //hàm lấy thông tin về bảng chi tiết hóa đơn nhập đổ ra datagridview
        public DataTable showChiTietHoaDonNhap()
        {
            string query = "select * from CTPNHAP";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy các số phiếu nhập đổ ra combobox số phiếu nhập
        public DataTable getSoPN()
        {
            string query = "select * from PNHAP";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy các mã sản phẩm đổ ra combobox mã sản phẩm
        public DataTable getMaSP()
        {
            string query = "select * from SANPHAM";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy các đơn giá nhập đổ ra combobox đơn giá nhập
        public DataTable getDonGiaNhap(string maSP)
        {
            string query = "select * from GIA_BAN where MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }

        //hàm insert chi tiết hóa đơn nhập
        public void insertChiTietHoaDonNhap(string soPhieu, string maSP, int soluong, int dongia)
        {
            string query = "insert into CTPNHAP values('" + soPhieu + "','" + maSP + "'," + soluong + " ," + dongia + " )";
            data.executeNonQuery(query);
        }
        //hàm update chi tiết hóa đơn nhập
        public void updateChiTietHoaDonNhap(string soPhieu, string maSP, int soluong, int dongia)
        {
            string query = "update CTPNHAP set SlNhap=" + soluong + ", DgNhap=" + dongia + " where SoPn='" + soPhieu + "' and MaSP='" + maSP + "'";
            data.executeNonQuery(query);
        }
        //hàm xóa chi tiết hóa đơn nhập dựa vào số phiếu truyền vào
        public void deleteChiTietHoaDonNhap(string soPhieu, string maSP)
        {
            string query = "delete from CTPNHAP where SoPn='" + soPhieu + "' and MaSP='" + maSP + "'";
            data.executeNonQuery(query);
        }
        //hàm tìm chi tiết hóa đơn nhập với số phiếu truyền vào
        public DataTable searchChiTietHoaDonNhapWithSoPn(string soPhieu)
        {
            string query = "select * from CTPNHAP where SoPn='" + soPhieu + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchChiTietHoaDonNhapWithMaSP(string maSP)
        {
            string query = "select * from CTPNHAP where MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchChiTietHoaDonNhapWithSoPnandMaSP(string soPhieu, string maSP)
        {
            string query = "select * from CTPNHAP where SoPn='" + soPhieu + "' and MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
    }
}
