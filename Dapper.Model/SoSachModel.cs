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
    public class SoCaiTaiKhoanModel
    {
        public DateTime? NgayThangGhiSo { get; set; }
        public string SoHieu { get; set; }
        public DateTime? NgayThangChungTu { get; set; }
        public string DIENGIAI { get; set; }
        public int? TRANGSO { get; set; }
        public int? STT_DONG { get; set; }
        public string TKDOIUNG { get; set; }
        public int? SONO { get; set; }
        public int? CO { get; set; }
    }

    public class SoCaiChiTietTaiKhoanModel
    {
        public DateTime? NgayThangGhiSo { get; set; }
        public string SoHieu { get; set; }
        public DateTime? NgayThangChungTu { get; set; }
        public string DIENGIAI { get; set; }
        public string TKDOIUNG { get; set; }
        public int? SONO { get; set; }
        public int? CO { get; set; }
        public int? TON { get; set; }
    }


}
