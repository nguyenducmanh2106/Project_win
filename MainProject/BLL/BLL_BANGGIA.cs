using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBANXE.BLL
{
    class BLL_BANGGIA
    {
        DAL data = new DAL();
        //xử lý bảng giá
        //hàm lấy các mã sản phẩm đổ ra combobox mã sản phẩm
        public DataTable getMaSP()
        {
            string query = "select * from SANPHAM";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm lấy thông tin bảng giá bán
        public DataTable getTablePrice()
        {
            string query = "select * from GIA_BAN";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //hàm thêm bảng giá bán
        public void addPrice(string masp, int giaban, int giamua)
        {
            string query = "insert into GIA_BAN values('" + masp + "',getDate()," + giaban + "," + giamua + ")";
            data.executeNonQuery(query);
        }
        //hàm sửa bảng giá bán
        public void editPrice(string masp, string date, int giaban, int giamua)
        {
            string query = "update GIA_BAN set giaban=" + giaban + ",giamua=" + giamua + " where MaSP='" + masp + "' and Ngaylamgia='" + date + "'";
            data.executeNonQuery(query);
        }
        public void deletePrice(string masp, string date)
        {
            string query = "delete from GIA_BAN where MaSP='" + masp + "' and Ngaylamgia='" + date + "'";
            data.executeNonQuery(query);
        }
        //hàm tìm giá theo mã sản phẩm
        public DataTable searchPriceWithMaSP(string maSP)
        {
            string query = "select * from GIA_BAN where MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
    }
}
