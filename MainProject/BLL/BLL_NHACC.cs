using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KETOANDOANHTHU.BLL
{
    class BLL_NHACC
    {
        DAL data = new DAL();
        //hàm lấy thông tin NhaCC đổ ra datagridview
        public DataTable showNHACC()
        {
            string query = "select * from NHACC";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }

        //hàm insert NHACC
        public void insertNHACC(string MaNHACc, string TenNhaCC, string DiaChi, string DienThoai)
        {
            string query = "insert into NHACC values('" + MaNHACc + "',N'" + TenNhaCC + "',N'" + DiaChi + "','" + DienThoai + "')";
            data.executeNonQuery(query);
        }
        //hàm update Hãng xe
        public void updateNHACC(string MaNHACc, string TenNhaCC, string DiaChi, string DienThoai)
        {
            string query = "update NHACC set TenNhaCc =N'" + TenNhaCC + "', DiaChi =N'" + DiaChi + "', DienThoai ='" + DienThoai + "'  where MaNhaCc ='" + MaNHACc + "'";
            data.executeNonQuery(query);
        }

        //hàm xóa Hãng xe dựa vào Mahangxe truyền vào
        public void deleteNHACC(string MaNHACc)
        {
            string query = "delete from NHACC where MaNHACc='" + MaNHACc + "'";
            data.executeNonQuery(query);
        }
        //hàm lấy Tìm Kiếm NHACC
        public DataTable searchbyMaNhaCC(String MaNHACc)
        {
            string query = "select * from NHACC where MaNHACc = '" + MaNHACc + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchbyTenNCC(String TenNhaCc)
        {
            string query = "select * from NHACC where TenNhaCc like N'%" + TenNhaCc + "%'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
        public DataTable searchbyDiaChi(String DiaChi)
        {
            string query = "select * from NHACC where DiaChi like N'%" + DiaChi + "%'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }
    }
}
