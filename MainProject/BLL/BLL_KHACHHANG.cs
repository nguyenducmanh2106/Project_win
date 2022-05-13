using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLBANXE.BLL
{
    class BLL_KHACHHANG
    {
        DAL data = new DAL();
        //Quản lý Khách Hàng
        //hàm lấy thông tin KHACHHANG đổ ra datagridview
        public DataTable showKHACHHANG()
        {
            string query = "select * from KHACHHANG";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        //insert KHACHHANG
        public void insertKHACHHANG(string Makh, string Tenkh, int gender, string DiaChi, string DienThoai)
        {
            string query = "insert into KHACHHANG values('" + Makh + "',N'" + Tenkh + "','" + gender + "',N'" + DiaChi + "','" + DienThoai + "')";
            data.executeNonQuery(query);
        }
        //hàm update Hãng xe
        public void updateKHACHHANG(string Makh, string Tenkh, int gender, string DiaChi, string DienThoai)
        {
            string query = "update KHACHHANG set Tenkh =N'" + Tenkh + "', gender ='" + gender + "', DiaChi =N'" + DiaChi + "', DienThoai ='" + DienThoai + "'  where Makh ='" + Makh + "'";
            data.executeNonQuery(query);
        }

        //hàm xóa Hãng xe dựa vào Mahangxe truyền vào
        public void deleteKHACHHANG(string Makh)
        {
            string query = "delete from KHACHHANG where Makh='" + Makh + "'";
            data.executeNonQuery(query);
        }


        public DataTable searchbyMaKHACHHANG(String Makh)
        {
            string query = "select * from KHACHHANG where Makh = '" + Makh + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchbyTenKHACHHANG(String Tenkh)
        {
            string query = "select * from KHACHHANG where Tenkh like N'%" + Tenkh + "%'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchbyDiaChiKH(String DiaChi)
        {
            string query = "select * from KHACHHANG where DiaChi like N'%" + DiaChi + "%'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
    }
}
