using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KETOANDOANHTHU.BLL
{
    class BLL_HOADONXUAT
    {
        DAL data = new DAL();
        //xử lý với bảng hóa đơn xuất
        //hàm lấy các mã sản phẩm đổ ra combobox mã sản phẩm
        public DataTable getMaSP()
        {
            string query = "select * from SANPHAM";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy thông tin về bảng hóa đơn xuất đổ ra datagridview
        public DataTable showHoaDonXuat()
        {
            string query = "select * from PXUAT";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy các mã khách hàng đổ ra combobox mã khách hàng
        public DataTable getMaKhachHang()
        {
            string query = "select * from KHACHHANG";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm insert hóa đơn xuất
        public void insertHoaDonXuat(string soPhieu, string ngay, string maKh)
        {
            string query = "insert into PXUAT values('" + soPhieu + "','" + ngay + "','" + maKh + "'  )";
            data.executeNonQuery(query);
        }
        //hàm update hóa đơn xuất
        public void updateHoaDonXuat(string soPhieu, string ngay, string maKh)
        {
            string query = "update PXUAT set NgayXuat='" + ngay + "', Makh='" + maKh + "' where SoPx='" + soPhieu + "'";
            data.executeNonQuery(query);
        }
        //hàm xóa hóa đơn xuất dựa vào số phiếu truyền vào
        public void deleteHoaDonXuat(string soPhieu)
        {
            string query = "delete from PXUAT where SoPx='" + soPhieu + "'";
            data.executeNonQuery(query);
        }
        //hàm tìm hóa đơn xuất với số phiếu truyền vào
        public DataTable searchHoaDonXuat(string soPhieu)
        {
            string query = "select * from PXUAT where SoPx='" + soPhieu + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy các số phiếu xuất đổ ra combobox số phiếu xuất
        public DataTable getSoPx()
        {
            string query = "select * from PXUAT";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lọc các bản ghi hóa đơn xuất với ngày bd và ngày kt truyền vào
        public DataTable searchHoaDonXuatWithDate(string ngayBd, string ngayKt)
        {
            string query = "select * from PXUAT where NgayXuat between convert(date,'" + ngayBd + "') and convert(date,'" + ngayKt + "')";

            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }

        //-----------xử lý với chi tiết hóa đơn xuất
        //hàm lấy thông tin về bảng chi tiết hóa đơn xuất đổ ra datagridview
        public DataTable showChiTietHoaDonXuat()
        {
            string query = "select * from CTPXUAT";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy các đơn giá xuất đổ ra combobox đơn giá xuất
        public DataTable getDonGiaXuat(string maSP)
        {
            string query = "select * from GIA_BAN where MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }

        //hàm insert chi tiết hóa đơn xuất
        public void insertChiTietHoaDonXuat(string soPhieu, string maSP, int soluong, int dongia)
        {
            string query = "insert into CTPXUAT values('" + soPhieu + "','" + maSP + "'," + soluong + " ," + dongia + " )";
            data.executeNonQuery(query);
        }
        //hàm update chi tiết hóa đơn xuất
        public void updateChiTietHoaDonXuat(string soPhieu, string maSP, int soluong, int dongia)
        {
            string query = "update CTPXUAT set SlXuat=" + soluong + ", DgXuat=" + dongia + " where SoPx='" + soPhieu + "' and MaSP='" + maSP + "'";
            data.executeNonQuery(query);
        }
        //hàm xóa chi tiết hóa đơn nhập dựa vào số phiếu truyền vào
        public void deleteChiTietHoaDonXuat(string soPhieu, string maSP)
        {
            string query = "delete from CTPXUAT where SoPx='" + soPhieu + "' and MaSP='" + maSP + "'";
            data.executeNonQuery(query);
        }
        //hàm tìm chi tiết hóa đơn xuất với số phiếu truyền vào
        public DataTable searchChiTietHoaDonXuatWithSoPx(string soPhieu)
        {
            string query = "select * from CTPXUAT where SoPx='" + soPhieu + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchChiTietHoaDonXuatWithMaSP(string maSP)
        {
            string query = "select * from CTPXUAT where MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchChiTietHoaDonXuatWithSoPnandMaSP(string soPhieu, string maSP)
        {
            string query = "select * from CTPXUAT where SoPx='" + soPhieu + "' and MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
    }
}
