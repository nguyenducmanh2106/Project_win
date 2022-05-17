using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Dapper.Model
{
    public class HoaDonGTGT
    {
        public int ID { get; set; }

        /// <summary>
        /// số hóa đơn giá trị gia tăng
        /// </summary>
        public string SOHD { get; set; }
        public DateTime? NGAYLAP { get; set; }

        /// <summary>
        ///  khóa ngoài liên kết với bảng Khách hàng(KHACHHANG)
        /// </summary>
        public int? KhachHangID { get; set; }

        /// <summary>
        ///  tài khoản ghi nợ thanh toán
        /// </summary>
        public int? TKNOTHANHTOAN { get; set; }

        /// <summary>
        /// tài khoản ghi có doanh thu
        /// </summary>
        public int? TKCODOANHTHU { get; set; }

        /// <summary>
        /// tài khoản ghi có thuế
        /// </summary>
        public int? TKCOTHUE { get; set; }

        /// <summary>
        /// tổng tiền thanh toán
        /// </summary>
        public decimal? TIENTHANHTOAN { get; set; }

        /// <summary>
        /// tiền doanh thu
        /// </summary>
        public decimal? TIENDOANHTHU { get; set; }

        /// <summary>
        /// tài khoản chiết khấu
        /// </summary>
        public int? TKCK { get; set; }
        public string DIENGIAI { get; set; }

        /// <summary>
        /// Loại tiền tệ
        /// </summary>
        public string LOAITIEN { get; set; }
    }

    public class CTHDGTGT
    {
        public int HangHoaID { get; set; }
        public int HoaDonGTGT_ID { get; set; }
        public int SOLUONG { get; set; }
        public decimal DONGIA { get; set; }

        /// <summary>
        /// tỷ lệ chiết khấu
        /// </summary>
        public decimal? TYLECK { get; set; }

        /// <summary>
        /// tiền chiết khấu
        /// </summary>
        public decimal? TIENCK { get; set; }

        public decimal? THUESUAT { get; set; }
        public decimal? TIENTHUE { get; set; }
    }

    public class HoaDonGTGTModel
    {
        public int ID { get; set; }

        /// <summary>
        /// số hóa đơn giá trị gia tăng
        /// </summary>
        public string SOHD { get; set; }
        public DateTime? NGAYLAP { get; set; }

        /// <summary>
        ///  khóa ngoài liên kết với bảng Khách hàng(KHACHHANG)
        /// </summary>
        public int? KhachHangID { get; set; }

        /// <summary>
        /// tiền doanh thu
        /// </summary>
        public decimal? TIENDOANHTHU { get; set; }

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public string TENKH { get; set; }

        public string DIENGIAI { get; set; }
    }

}
