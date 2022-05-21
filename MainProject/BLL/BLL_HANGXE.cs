using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KETOANDOANHTHU.BLL
{
    class BLL_HANGXE
    {
        DAL data = new DAL();
        //Quản lý Hãng Xe
        //hàm lấy thông tin Xe đổ ra datagridview
        public DataTable showHANGXE()
        {
            string query = "select * from HANGXE";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }

        //hàm lấy Tìm Kiếm hãng xe
        public DataTable searchHANGXE(String Mahangxe)
        {
            string query = "select * from HANGXE where Mahangxe = '" + Mahangxe + "'";
            DataTable dt = new DataTable();
            dt = data.GetDataTable(query);
            return dt;
        }

        //hàm insert Hãng xe
        public void insertHANGXE(string Mahangxe, string Tenhang)
        {
            string query = "insert into HANGXE values('" + Mahangxe + "',N'" + Tenhang + "')";
            data.executeNonQuery(query);
        }
        //hàm update Hãng xe
        public void updateHANGXE(string Mahangxe, string Tenhang)
        {
            string query = "update HANGXE set Tenhang =N'" + Tenhang + "'  where Mahangxe ='" + Mahangxe + "'";
            data.executeNonQuery(query);
        }

        //hàm xóa Hãng xe dựa vào Mahangxe truyền vào
        public void deleteHANGXE(string Mahangxe)
        {
            string query = "delete from HANGXE where Mahangxe='" + Mahangxe + "'";
            data.executeNonQuery(query);
        }
    }
}
