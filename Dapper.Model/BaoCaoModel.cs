using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * create by 
 */

namespace Dapper.Model
{
    public class BaoCaoDoanhThuTheoKhachHangModel
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public decimal DOANHTHU { get; set; }
    }

    public class BaoCaoDoanhThuTheoHangHoaModel
    {
        public string MAHH { get; set; }
        public string TENHH { get; set; }
        public decimal DOANHTHU { get; set; }
    }

    public class BaoCaoGiamTruDoanhThuModel
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public decimal DOANHTHU { get; set; }
        public decimal GIAMTRUDOANHTHU { get; set; }
        public decimal DOANHTHUTHUAN { get; set; }
    }

    public class BaoCaoTongHopDoanhThuModel
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public decimal DOANHTHU { get; set; }
        public decimal GIAMTRUDOANHTHU { get; set; }
        public decimal DOANHTHUTHUAN { get; set; }
    }
}
