using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Dapper.Model
{
    public class PhieuGiamGiaModel
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
        ///  tài khoản nợ giảm trừ
        /// </summary>
        public int? TKNOGIAMTRU { get; set; }

        /// <summary>
        ///  tài khoản nợ thuế
        /// </summary>
        public int? TKNOTHUE { get; set; }

        /// <summary>
        /// tài khoản ghi có thanh toán
        /// </summary>
        public int? TKCOTHANHTOAN { get; set; }

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

        public decimal? TONGTIENCK { get; set; }

        public decimal? TONGTIENTHUE { get; set; }


        //thêm
        public string MAKH { get; set; }
        public string TENKH { get; set; }
    }

    public class CTPGG
    {
        public int HangHoaID { get; set; }
        public int PhieuGiamGia_ID { get; set; }
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

    public class CTPGGModel : CTHDGTGT
    {
        public string DVT { get; set; }
        public int? KHO { get; set; }
        public decimal THANHTIEN { get; set; }
        public string TENHH { get; set; }
        public int MAHH { get; set; }
    }
    public class PhieuGiamGiaDetail : PhieuGiamGiaModel
    {
        public string ChiTiet { get; set; }
        public List<CTPGGModel> ChiTietPGG { get; set; }

    }

}
