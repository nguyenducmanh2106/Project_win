using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KETOANDOANHTHU.BLL
{
    class BLL_HANGTON
    {
        DAL data = new DAL();
        //hàm xử lý Hàm tồn
        //hàm lấy các mã sản phẩm đổ ra combobox mã sản phẩm
        public DataTable getMaSP()
        {
            string query = "select * from SANPHAM";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable getTableHangTon()
        {
            string query = "select * from hangton";//lấy thông tin từ bảng view hangton
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable getTableHangTonWithMaSP(string masp)
        {
            String query = "select * from hangton where masp='" + masp + "'";//lấy thông tin từ bảng view hangton
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
    }
}
